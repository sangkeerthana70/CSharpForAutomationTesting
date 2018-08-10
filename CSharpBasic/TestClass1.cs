using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    //all methods, variables and properties which we create inside a class are called  members of the class.
    //When we create an object for the TestClass1 we will have access to all its members.

    class TestClass1
    {
        public void TestCase1()
        {
            Console.WriteLine("Executing Test case1");
            Console.Write("Hello World!");
            Console.Read();
        }

        public void TestCase2()
        {
            Console.WriteLine("Executing Test case2");
            Console.WriteLine("How are you");
            Console.Read();


        }
 
    }
}
