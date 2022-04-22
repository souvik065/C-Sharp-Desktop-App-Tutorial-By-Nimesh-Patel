using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typeofconstructors
{
    class Program
    {
        int i; bool b;
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Value of i is:  "+p.i);
            Console.WriteLine("Value of i is:  "+p.b);

            Console.ReadLine();

        }
    }
}
