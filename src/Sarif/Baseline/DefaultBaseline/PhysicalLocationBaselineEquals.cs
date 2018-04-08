﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Sarif.Baseline.DefaultBaseline
{
    internal class PhysicalLocationBaselineEquals : IEqualityComparer<PhysicalLocation>
    {
        public static readonly PhysicalLocationBaselineEquals Instance = new PhysicalLocationBaselineEquals();
        public bool Equals(PhysicalLocation x, PhysicalLocation y)
        {
            if (!object.ReferenceEquals(x, y))
            {
                if (x == null || y == null)
                {
                    return false;
                }
                
                if (!FileLocationBaselineEquals.Instance.Equals(x.FileLocation, y.FileLocation))
                {
                    return false;
                }
            }
            
            return true;
        }

        public int GetHashCode(PhysicalLocation obj)
        {
            if (ReferenceEquals(obj, null) || obj.FileLocation?.Uri == null)
            {
                return 0;
            }
            else
            {
                return obj.FileLocation.Uri.GetNullCheckedHashCode();
            }
        }
    }
}
