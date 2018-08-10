using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class Program
    {
 
        //Entry point of our program
        static void Main(string[] args)
        {

            //instantiate an object of TestClass1

            TestClass1 class1 = new TestClass1();
            class1.TestCase1("Hello World!");
            class1.TestCase2("How are you");

            Console.Read();
        }
    }
}
