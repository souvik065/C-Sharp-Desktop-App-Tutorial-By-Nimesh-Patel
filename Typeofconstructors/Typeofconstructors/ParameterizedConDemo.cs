using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typeofconstructors
{
    class ParameterizedConDemo
    {
        int x; 
        public ParameterizedConDemo(int i)
        {
            x = i;
            Console.WriteLine("Parameterized Constructor is called: "+i);
        }

        public void Display()
        {
            Console.WriteLine("Value of x is : "+x);
        }

        static void Main()
        {
            ParameterizedConDemo c1 = new ParameterizedConDemo(10);
            ParameterizedConDemo c2 = new ParameterizedConDemo(20);
            Console.ReadLine();

            c1.Display();
            c2.Display();
            Console.ReadLine();

        }
    }
}
