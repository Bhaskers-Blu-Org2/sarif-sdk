﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Microsoft.CodeAnalysis.Sarif.Multitool.Rules
{
    public class PreferMessageIdInsteadOfMessageText : SarifValidationSkimmerBase
    {
        private IList<ReportingDescriptor> currentRules;

        private readonly MultiformatMessageString _fullDescription = new MultiformatMessageString
        {
            Text = RuleResources.SARIF1022_PreferMessageIdInsteadOfMessageText
        };

        public override MultiformatMessageString FullDescription => _fullDescription;

        public override FailureLevel DefaultLevel => FailureLevel.Error;

        /// <summary>
        /// SARIF1019
        /// </summary>
        public override string Id => RuleId.PreferMessageIdInsteadOfMessageText;

        protected override IEnumerable<string> MessageResourceNames => new string[]
        {
            nameof(RuleResources.SARIF1022_RuleMetadataDoesntIncludeMessageId),
            nameof(RuleResources.SARIF1022_RuleMetadataIsNotConsistentWithArguments),
            nameof(RuleResources.SARIF1022_ResultShouldUseMessageIdInsteadOfMessageText)
        };

        protected override void Analyze(Run run, string runPointer)
        {
            this.currentRules = run?.Tool?.Driver?.Rules;
        }

        protected override void Analyze(Result result, string resultPointer)
        {
            // if message.text is not null, we have a problem
            if (!string.IsNullOrEmpty(result.Message.Text))
            {
                LogResult(resultPointer, nameof(RuleResources.SARIF1022_ResultShouldUseMessageIdInsteadOfMessageText), result.Message.Text);
                return;
            }

            // if message.id is not null, we have to check if that exists in rules
            if (!string.IsNullOrEmpty(result.Message.Id))
            {
                // we dont have rules or we didnt find a match, we have a problem
                if (this.currentRules == null || this.currentRules.Count == 0 || this.currentRules.All(r => !r.MessageStrings.ContainsKey(result.Message.Id)))
                {
                    LogResult(resultPointer, nameof(RuleResources.SARIF1022_RuleMetadataDoesntIncludeMessageId), result.Message.Id);
                    return;
                }

                // we have rules, we find it but, the count of parameters are invalid
                string messageText = this.currentRules
                    .First(r => r.MessageStrings.ContainsKey(result.Message.Id))
                    .MessageStrings[result.Message.Id].Text;
                if (!IsPlacehodlerInTextValid(messageText, result.Message.Arguments?.Count ?? 0))
                {
                    LogResult(resultPointer, nameof(RuleResources.SARIF1022_RuleMetadataIsNotConsistentWithArguments), messageText, result.Message.Arguments.Count.ToString());
                    return;
                }
            }
        }

        private bool IsPlacehodlerInTextValid(string text, int arguments)
        {
            for (int i = 0; i < arguments - 1; i++)
            {
                if (!text.Contains($"{i}"))
                {
                    return false;
                }
            }

            // checking the quantity of matches with quantity of arguments
            MatchCollection matchCollection = Regex.Matches(text, "{\\d+}");
            if (matchCollection.Count != arguments)
            {
                return false;
            }

            // checking if the index of the placeholders are right {0} {2} and 2 arguments is invalid
            int index = 0;
            var matches = new Match[matchCollection.Count];
            matchCollection.CopyTo(matches, 0);
            foreach (Match match in matches.OrderBy(q => q.Value))
            {
                if (match.Value == $"{{{index}}}")
                {
                    index++;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}