using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typeofconstructors
{
    class ExplicitConDemo
    {
        public ExplicitConDemo()
        {
            Console.WriteLine("Constructor is called.");
        }

        static void Main()
        {
            ExplicitConDemo obj = new ExplicitConDemo();

            Console.ReadLine();
        }
    }
}
