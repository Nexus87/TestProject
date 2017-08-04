using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Build.Framework;
using Xunit;

namespace TestProject
{
    public class Class1
    {
        [Fact]
        public void Test_Function()
        {
            
        }

        [Theory]
        [InlineData(1, "Test")]
        [InlineData(2, "Test2")]
        public void Test_Function2(int i, string s)
        {
            
        }
    }


    public class Class2
    {
        public class Class3
        {
            public void Test_Func() { }

            [Fact]
            [Bla]
            public void Test_Func2()
            {
                
            }

            [Fact]
            public void Test_Func3()
            {
                
            }
        }
    }

    public interface IClass
    {
        
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class BlaAttribute : Attribute
    {
        
    }
}
