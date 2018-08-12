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
            //class1.TestCase1("Hello World!");
            //class1.TestCase2("How are you");

            class1.SetValue(20);
            class1.GetValue();
            class1.SetValue(45);

            TestClass1 class2 = new TestClass1();
            class2.SetValue(40);
            class2.GetValue();

            //class1 called again has its own copy of the variable value which is a member
            class1.GetValue();


            Console.Read();
        }
    }
}
