using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEightFeatures
{
    public interface IDefaultInterfaceMembers
    {
        string GenerateSomeValue();
        string GenerateOtherValue() => "TestValue";
    }
}
