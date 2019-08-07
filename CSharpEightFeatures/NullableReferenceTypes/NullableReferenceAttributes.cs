using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEightFeatures.NullableReferenceTypes
{
    public class NullableReferenceAttributes
    {
        [AllowNull]
        public string SomeValue { get; set; }

        [DisallowNull]
        public string? SomeOtherValue { get; set; }

    }
}
