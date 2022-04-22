using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typeofconstructors
{

    class CopyConDemo
    {
        int x;
        public CopyConDemo(int i)
        {
            x = i;
        }

        public CopyConDemo(CopyConDemo obj)
        {
            x = obj.x;
        }

        public void display()
        {


            Console.WriteLine("Value of x  is : "+x);
        }

        static void Main()
        {
            CopyConDemo c1 = new CopyConDemo(10);
            c1.display();
            CopyConDemo c2 = new CopyConDemo(c1);
            c2.display();
            Console.ReadLine();
        }

    }
}
