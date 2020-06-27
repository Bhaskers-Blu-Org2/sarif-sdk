﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.Sarif.Multitool.Rules {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class RuleResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RuleResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.Sarif.Multitool.Rules.RuleResources", typeof(RuleResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The rule &apos;{1}&apos; has a &apos;name&apos; property that is identical to its &apos;id&apos; property. The required &apos;id&apos; property must be a &quot;stable, opaque identifier&quot; (the SARIF specification ([3.49.3](https://docs.oasis-open.org/sarif/sarif/v2.1.0/os/sarif-v2.1.0-os.html#_Toc34317839)) explains the reasons for this). The optional &apos;name&apos; property ([3.49.7](https://docs.oasis-open.org/sarif/sarif/v2.1.0/os/sarif-v2.1.0-os.html#_Toc34317843)) is an identifer that is understandable to an end user. Therefore if both &apos;id&apos; and &apos;name [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SARIF1001_RuleIdentifiersMustBeValid_Error_Default_Text {
            get {
                return ResourceManager.GetString("SARIF1001_RuleIdentifiersMustBeValid_Error_Default_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The two identity-related properties of a SARIF rule must be consistent. The required &apos;id&apos; property must be a &quot;stable, opaque identifier&quot; (the SARIF specification ([3.49.3](https://docs.oasis-open.org/sarif/sarif/v2.1.0/os/sarif-v2.1.0-os.html#_Toc34317839)) explains the reasons for this). The optional &apos;name&apos; property ([3.49.7](https://docs.oasis-open.org/sarif/sarif/v2.1.0/os/sarif-v2.1.0-os.html#_Toc34317843)) is an identifer that is understandable to an end user. Therefore if both &apos;id&apos; and &apos;name&apos; are pres [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SARIF1001_RuleIdentifiersMustBeValid_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1001_RuleIdentifiersMustBeValid_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The &apos;file&apos; URI &apos;{1}&apos; contains a &apos;..&apos; segment. This is dangerous because if symbolic links are present, &apos;..&apos; might have different meanings on the machine that produced the log file and the machine where an end user or a tool consumes it..
        /// </summary>
        internal static string SARIF1002_UrisMustBeValid_Error_FileUrisMustNotIncludeDotDotSegments_Text {
            get {
                return ResourceManager.GetString("SARIF1002_UrisMustBeValid_Error_FileUrisMustNotIncludeDotDotSegments_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The string &apos;{1}&apos; is not a valid URI reference. URIs must conform to [RFC 3986](https://tools.ietf.org/html/rfc3986)..
        /// </summary>
        internal static string SARIF1002_UrisMustBeValid_Error_UrisMustConformToRfc3986_Text {
            get {
                return ResourceManager.GetString("SARIF1002_UrisMustBeValid_Error_UrisMustConformToRfc3986_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify a valid URI reference for every URI-valued property.
        ///
        ///URIs must conform to [RFC 3986](https://tools.ietf.org/html/rfc3986). In addition, &apos;file&apos; URIs must not include &apos;..&apos; segments. If symbolic links are present, &apos;..&apos; might have different meanings on the machine that produced the log file and the machine where an end user or a tool consumes it..
        /// </summary>
        internal static string SARIF1002_UrisMustBeValid_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1002_UrisMustBeValid_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The URI &apos;{1}&apos; belonging to the &apos;{2}&apos; element of run.originalUriBaseIds is not an absolute URI..
        /// </summary>
        internal static string SARIF1004_ExpressUriBaseIdsCorrectly_Error_TopLevelUriBaseIdMustBeAbsolute_Text {
            get {
                return ResourceManager.GetString("SARIF1004_ExpressUriBaseIdsCorrectly_Error_TopLevelUriBaseIdMustBeAbsolute_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This fileLocation object contains a &quot;uriBaseId&quot; property, which means that the value of the &quot;uri&quot; property must be a relative URI reference, but &quot;{1}&quot; is an absolute URI reference..
        /// </summary>
        internal static string SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdRequiresRelativeUri_Text {
            get {
                return ResourceManager.GetString("SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdRequiresRelativeUri_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The URI &apos;{1}&apos; belonging to the &apos;{2}&apos; element of run.originalUriBaseIds does not end with a slash..
        /// </summary>
        internal static string SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustEndWithSlash_Text {
            get {
                return ResourceManager.GetString("SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustEndWithSlash_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: &apos;{1}&apos; &apos;{2}&apos; Placeholder: SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustNotContainDotDotSegment_Text.
        /// </summary>
        internal static string SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustNotContainDotDotSegment_Text {
            get {
                return ResourceManager.GetString("SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustNotContainDotDotSegm" +
                        "ent_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: &apos;{1}&apos; &apos;{2}&apos; Placeholder: SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustNotContainQueryOrFragment_Text.
        /// </summary>
        internal static string SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustNotContainQueryOrFragment_Text {
            get {
                return ResourceManager.GetString("SARIF1004_ExpressUriBaseIdsCorrectly_Error_UriBaseIdValueMustNotContainQueryOrFra" +
                        "gment_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Placeholder_SARIF1004_ExpressUriBaseIdsCorrectly_FullDescription_Text.
        /// </summary>
        internal static string SARIF1004_ExpressUriBaseIdsCorrectly_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1004_ExpressUriBaseIdsCorrectly_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The value of this property is required to be an absolute URI, but &quot;{1}&quot; is a relative URI reference..
        /// </summary>
        internal static string SARIF1005_UriMustBeAbsolute_Error_Default_Text {
            get {
                return ResourceManager.GetString("SARIF1005_UriMustBeAbsolute_Error_Default_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certain URIs are required to be absolute..
        /// </summary>
        internal static string SARIF1005_UriMustBeAbsolute_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1005_UriMustBeAbsolute_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The &apos;endTimeUtc&apos; value &apos;{1}&apos; precedes the &apos;startTimeUtc&apos; value &apos;{2}&apos;. The properties of an &apos;invocation&apos; object must be internally consistent..
        /// </summary>
        internal static string SARIF1006_InvocationPropertiesMustBeConsistent_Error_EndTimeMustNotPrecedeStartTime_Text {
            get {
                return ResourceManager.GetString("SARIF1006_InvocationPropertiesMustBeConsistent_Error_EndTimeMustNotPrecedeStartTi" +
                        "me_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The properties of an &apos;invocation&apos; object must be consistent.
        ///
        ///If the &apos;invocation&apos; object specifies both &apos;startTimeUtc&apos; and &apos;endTimeUtc&apos;, then &apos;endTimeUtc&apos; must not precede &apos;startTimeUtc&apos;. To allow for the possibility that the duration of the run is less than the resolution of the string representation of the time, the start time and the end time may be equal..
        /// </summary>
        internal static string SARIF1006_InvocationPropertiesMustBeConsistent_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1006_InvocationPropertiesMustBeConsistent_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: In this &apos;region&apos; object, the &apos;endColumn&apos; property &apos;{1}&apos; is less than the &apos;startColumn&apos; property &apos;{2}&apos;. The properties of a &apos;region&apos; object must be internally consistent..
        /// </summary>
        internal static string SARIF1007_RegionPropertiesMustBeConsistent_Error_EndColumnMustNotPrecedeStartColumn_Text {
            get {
                return ResourceManager.GetString("SARIF1007_RegionPropertiesMustBeConsistent_Error_EndColumnMustNotPrecedeStartColu" +
                        "mn_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: In this &apos;region&apos; object, the &apos;endLine&apos; property &apos;{1}&apos; is less than the &apos;startLine&apos; property &apos;{2}&apos;. The properties of a &apos;region&apos; object must be internally consistent..
        /// </summary>
        internal static string SARIF1007_RegionPropertiesMustBeConsistent_Error_EndLineMustNotPrecedeStartLine_Text {
            get {
                return ResourceManager.GetString("SARIF1007_RegionPropertiesMustBeConsistent_Error_EndLineMustNotPrecedeStartLine_T" +
                        "ext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This &apos;region&apos; object does not specify &apos;startLine&apos;, &apos;charOffset&apos;, or &apos;byteOffset&apos;. As a result, it is impossible to determine whether this &apos;region&apos; object describes a line/column text region, a character offset/length text region, or a binary region..
        /// </summary>
        internal static string SARIF1007_RegionPropertiesMustBeConsistent_Error_RegionStartPropertyMustBePresent_Text {
            get {
                return ResourceManager.GetString("SARIF1007_RegionPropertiesMustBeConsistent_Error_RegionStartPropertyMustBePresent" +
                        "_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The properties of a &apos;region&apos; object must be consistent.
        ///
        ///SARIF can specify a &apos;region&apos; (a contiguous portion of a file) in a variety of ways: with line and column numbers, with a character offset and count, or with a byte offset and count. The specification states certain constraints on these properties, both within each property group (for example, the start line cannot be greater than end line) and between the groups (for example, if more than one group is present, they must independently specify the sam [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SARIF1007_RegionPropertiesMustBeConsistent_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1007_RegionPropertiesMustBeConsistent_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This &apos;physicalLocation&apos; object contains both a &apos;region&apos; and a &apos;contextRegion&apos; property, but &apos;contextRegion&apos; is not a proper superset of &apos;region&apos;. This is invalid because the purpose of &apos;contextRegion&apos; is to provide a viewing context around the &apos;region&apos; which is the location of the result. It&apos;s possible that the tool reversed &apos;region&apos; and &apos;contextRegion&apos;. If &apos;region&apos; and &apos;contextRegion&apos; are identical, the tool must omit &apos;contextRegion&apos;..
        /// </summary>
        internal static string SARIF1008_PhysicalLocationPropertiesMustBeConsistent_Error_ContextRegionMustBeProperSupersetOfRegion_Text {
            get {
                return ResourceManager.GetString("SARIF1008_PhysicalLocationPropertiesMustBeConsistent_Error_ContextRegionMustBePro" +
                        "perSupersetOfRegion_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This &apos;physicalLocation&apos; object contains a &apos;contextRegion&apos; property, but it does not contain a &apos;region&apos; property. This is invalid because the purpose of &apos;contextRegion&apos; is to provide a viewing context around the &apos;region&apos; which is the location of the result. If a tool associates only one region with a result, it must populate &apos;region&apos;, not &apos;contextRegion&apos;..
        /// </summary>
        internal static string SARIF1008_PhysicalLocationPropertiesMustBeConsistent_Error_ContextRegionRequiresRegion_Text {
            get {
                return ResourceManager.GetString("SARIF1008_PhysicalLocationPropertiesMustBeConsistent_Error_ContextRegionRequiresR" +
                        "egion_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ensure consistency among the properties of a &apos;physicalLocation&apos; object.
        ///
        ///A SARIF &apos;physicalLocation&apos; object has two related properties &apos;region&apos; and &apos;contextRegion&apos;. If &apos;contextRegion&apos; is present, then &apos;region&apos; must also be present, and &apos;contextRegion&apos; must be a &quot;proper superset&quot; of &apos;region&apos;. That is, &apos;contextRegion&apos; must completely contain &apos;region&apos;, and it must be larger than &apos;region&apos;. To understand why this is so we must understand the roles of the &apos;region&apos; and &apos;contextRegion&apos; properties.
        ///
        ///&apos;region&apos; allo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SARIF1008_PhysicalLocationPropertiesMustBeConsistent_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1008_PhysicalLocationPropertiesMustBeConsistent_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This &apos;{1}&apos; object contains a property &apos;{2}&apos; with value {3}, but &apos;{4}&apos; has fewer than {5} elements. An index-valued properties must be valid for the array that it refers to..
        /// </summary>
        internal static string SARIF1009_IndexPropertiesMustBeConsistentWithArrays_Error_TargetArrayMustBeLongEnough_Text {
            get {
                return ResourceManager.GetString("SARIF1009_IndexPropertiesMustBeConsistentWithArrays_Error_TargetArrayMustBeLongEn" +
                        "ough_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This &apos;{1}&apos; object contains a property &apos;{2}&apos; with value {3}, but &apos;{4}&apos; does not exist. An index-valued property always refers to an array, so the array must be present..
        /// </summary>
        internal static string SARIF1009_IndexPropertiesMustBeConsistentWithArrays_Error_TargetArrayMustExist_Text {
            get {
                return ResourceManager.GetString("SARIF1009_IndexPropertiesMustBeConsistentWithArrays_Error_TargetArrayMustExist_Te" +
                        "xt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If an object contains a property that is used as an array index (an &quot;index-valued property&quot;), then that array must be present and must contain at least &quot;index + 1&quot; elements..
        /// </summary>
        internal static string SARIF1009_IndexPropertiesMustBeConsistentWithArrays_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1009_IndexPropertiesMustBeConsistentWithArrays_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The result contains neither result.ruleId nor result.rule.id..
        /// </summary>
        internal static string SARIF1010_RuleIdMustBeConsistent_Error_ResultMustSpecifyRuleId_Text {
            get {
                return ResourceManager.GetString("SARIF1010_RuleIdMustBeConsistent_Error_ResultMustSpecifyRuleId_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The result contains both the ruleId property &apos;{1}&apos; and the rule.id property &apos;{2}&apos;, and they are not equal..
        /// </summary>
        internal static string SARIF1010_RuleIdMustBeConsistent_Error_ResultRuleIdMustBeConsistent_Text {
            get {
                return ResourceManager.GetString("SARIF1010_RuleIdMustBeConsistent_Error_ResultRuleIdMustBeConsistent_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In every result, at least one of the properties result.ruleId and result.rule.id must be present. If both are present, they must be equal..
        /// </summary>
        internal static string SARIF1010_RuleIdMustBeConsistent_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1010_RuleIdMustBeConsistent_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The $schema property value &apos;{1}&apos; does not refer to the final version of the SARIF 2.1.0 schema. If you are using an earlier version of the SARIF format, consider upgrading your analysis tool to produce the final version. If this file does in fact conform to the final version of the schema, upgrade the tool to populate the $schema property with a URL that refers to the final version of the schema..
        /// </summary>
        internal static string SARIF1011_ReferenceFinalSchema_Error_Default_Text {
            get {
                return ResourceManager.GetString("SARIF1011_ReferenceFinalSchema_Error_Default_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The $schema property must refer to the final version of the SARIF 2.1.0 schema. This enables IDEs to provide Intellisense for SARIF log files..
        /// </summary>
        internal static string SARIF1011_ReferenceFinalSchema_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF1011_ReferenceFinalSchema_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Follow authoring practices that make your rule messages readable, understandable, and actionable.
        ///
        ///Including &quot;dynamic content&quot; (information that varies among results from the same rule) makes your messages more specific. It avoids the &quot;wall of bugs&quot; phenomenon, where hundreds of occurrences of the same message appear unapproachable.
        ///
        ///Placing dynamic content in quotes sets it off from the static text, making it easier to spot. It&apos;s especially helpful when the dynamic content is a string that might contai [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SARIF2001_AuthorHighQualityMessages_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF2001_AuthorHighQualityMessages_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: In rule &apos;{1}&apos;, the message with id &apos;{2}&apos; includes dynamic content that is not enclosed in single quotes. Enquoting dynamic content makes it easier to spot, and single quotes give a less cluttered appearance..
        /// </summary>
        internal static string SARIF2001_AuthorHighQualityMessages_Warning_EnquoteDynamicContent_Text {
            get {
                return ResourceManager.GetString("SARIF2001_AuthorHighQualityMessages_Warning_EnquoteDynamicContent_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: In rule &apos;{1}&apos;, the message with id &apos;{2}&apos; does not include any dynamic content. Dynamic content makes your messages more specific and avoids the &quot;wall of bugs&quot; phenomenon..
        /// </summary>
        internal static string SARIF2001_AuthorHighQualityMessages_Warning_IncludeDynamicContent_Text {
            get {
                return ResourceManager.GetString("SARIF2001_AuthorHighQualityMessages_Warning_IncludeDynamicContent_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: In rule &apos;{1}&apos;, the message with id &apos;{2}&apos; does not end in a period. Write rule messages as complete sentences..
        /// </summary>
        internal static string SARIF2001_AuthorHighQualityMessages_Warning_TerminateWithPeriod_Text {
            get {
                return ResourceManager.GetString("SARIF2001_AuthorHighQualityMessages_Warning_TerminateWithPeriod_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Placeholder_SARIF2004_OptimizeFileSize_FullDescription_Text.
        /// </summary>
        internal static string SARIF2004_OptimizeFileSize_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF2004_OptimizeFileSize_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Placeholder_SARIF2004_OptimizeFileSize_Warning_EliminateLocationOnlyArtifacts_Text.
        /// </summary>
        internal static string SARIF2004_OptimizeFileSize_Warning_EliminateLocationOnlyArtifacts_Text {
            get {
                return ResourceManager.GetString("SARIF2004_OptimizeFileSize_Warning_EliminateLocationOnlyArtifacts_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provide information that makes it easy to identify the name and version of your tool.
        ///
        ///The tool&apos;s &apos;name&apos; property should be no more than three words long. This makes it easy to remember and allows it to fit into a narrow column when displaying a list of results. If you need to provide more information about your tool, use the &apos;fullName&apos; property.
        ///
        ///The tool should provide either or both of the &apos;version&apos; and &apos;semanticVersion&apos; properties. This enables the log file consumer to determine whether the file was [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SARIF2005_ProvideToolProperties_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF2005_ProvideToolProperties_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The tool name &apos;{1}&apos; contains {2} words, which is more than the recommended maximum of {3} words. A short tool name is easy to remember and fits into a narrow column when displaying a list of results. If you need to provide more information about your tool, use the &apos;fullName&apos; property..
        /// </summary>
        internal static string SARIF2005_ProvideToolProperties_Warning_ProvideConciseToolName_Text {
            get {
                return ResourceManager.GetString("SARIF2005_ProvideToolProperties_Warning_ProvideConciseToolName_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The tool &apos;{1}&apos; provides neither a &apos;version&apos; property nor a &apos;semanticVersion&apos; property. Providing a version enables the log file consumer to determine whether the file was produced by an up to date version, and to avoid accidentally comparing log files produced by different tool versions..
        /// </summary>
        internal static string SARIF2005_ProvideToolProperties_Warning_ProvideToolVersion_Text {
            get {
                return ResourceManager.GetString("SARIF2005_ProvideToolProperties_Warning_ProvideToolVersion_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The tool &apos;{1}&apos; contains the &apos;version&apos; property &apos;{2}&apos;, which is not numeric. To facilitate comparison between versions, specify a &apos;version&apos; that starts with at least two dot-separated integer components, optionally followed by any desired characters..
        /// </summary>
        internal static string SARIF2005_ProvideToolProperties_Warning_UseNumericToolVersions_Text {
            get {
                return ResourceManager.GetString("SARIF2005_ProvideToolProperties_Warning_UseNumericToolVersions_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Placeholder.
        /// </summary>
        internal static string SARIF2006_UrisShouldBeReachable_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF2006_UrisShouldBeReachable_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Placeholder {1}.
        /// </summary>
        internal static string SARIF2006_UrisShouldBeReachable_Warning_Default_Text {
            get {
                return ResourceManager.GetString("SARIF2006_UrisShouldBeReachable_Warning_Default_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The $schema property should be present.  This enables IDEs to provide Intellisense for SARIF log files..
        /// </summary>
        internal static string SARIF2008_ProvideSchema_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF2008_ProvideSchema_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The SARIF log file does not contain a $schema property. Add a $schema property that refers to the final version of the SARIF 2.1.0 schema. This enables IDEs to provide Intellisense for SARIF log files..
        /// </summary>
        internal static string SARIF2008_ProvideSchema_Warning_Default_Text {
            get {
                return ResourceManager.GetString("SARIF2008_ProvideSchema_Warning_Default_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adopt uniform naming conventions for the symbolic names that SARIF uses various contexts.
        ///
        ///Many tools follow a conventional format for the &apos;reportingDescriptor.id&apos; property: a short string identifying the tool concatenated with a numeric rule number,
        ///for example, &apos;CS2001&apos; for a diagnostic from the Roslyn C# compiler. For uniformity of experience across tools, we recommend this format.
        ///
        ///Many tool use similar names for &apos;uriBaseId&apos; symbols. We suggest &apos;REPOROOT&apos; for the root of a repository, &apos;SRCROOT&apos; for [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SARIF2009_ConsiderConventionalIdentifierValues_FullDescription_Text {
            get {
                return ResourceManager.GetString("SARIF2009_ConsiderConventionalIdentifierValues_FullDescription_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The &apos;id&apos; property of the rule &apos;{1}&apos; does not follow the recommended format: a short string identifying the tool concatenated with a numeric rule number, for example, `CS2001`. Using a conventional format for the rule id provides a more uniform experience across tools..
        /// </summary>
        internal static string SARIF2009_ConsiderConventionalIdentifierValues_Note_UseConventionalRuleIds_Text {
            get {
                return ResourceManager.GetString("SARIF2009_ConsiderConventionalIdentifierValues_Note_UseConventionalRuleIds_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The &apos;originalUriBaseIds&apos; symbol &apos;{1}&apos; is not one of the conventional symbols. We suggest &apos;REPOROOT&apos; for the root of a repository, &apos;SRCROOT&apos; for the root of the directory containing all source code, &apos;TESTROOT&apos; for the root of the directory containing all test code (if your repository is organized in that way), and &apos;BINROOT&apos; for the root of the directory containing build output (if your project places all build output in a common directory)..
        /// </summary>
        internal static string SARIF2009_ConsiderConventionalIdentifierValues_Note_UseConventionalUriBaseIdNames_Text {
            get {
                return ResourceManager.GetString("SARIF2009_ConsiderConventionalIdentifierValues_Note_UseConventionalUriBaseIdNames" +
                        "_Text", resourceCulture);
            }
        }
    }
}
