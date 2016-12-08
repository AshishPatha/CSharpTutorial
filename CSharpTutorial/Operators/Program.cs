using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // + operator

            int x = +5;

            Console.WriteLine(x);

            // - operator

            int y = -5;

            Console.WriteLine(y);

            // *

            int z = x * y;

            Console.WriteLine(z);

            // /

            int k = x / y;

            Console.WriteLine(k);          

            // | , || , & , &&

            // x | y , x|| y , x & y , x && y                       

            // condition is satisfied
            if (k==-1 || z==-1)
            {
                Console.WriteLine("||-1");
            }

            // condition is not satisfied
            if (k == 5 || z == -5)
            {
                Console.WriteLine("||-5");
            }

            if (k == -1 | z == -1)
            {
                Console.WriteLine("|88888888888888888888888");
            }

            if (k == -1 | z == -25)
            {
                Console.WriteLine("|88888888888888888888888");
            }

            if (k == -1 & z == -25)
            {
                Console.WriteLine("&-1");
            }

            if (k == -1 & z == -5)
            {
                Console.WriteLine("&-5");
            }

            if (k == -1 && z == -25)
            {
                Console.WriteLine("&&-1");
            }

            if (k == -1 && z == -5)
            {
                Console.WriteLine("&&-5");
            }


            // Nullable opertors  ??

            string xy = null;
            string varZ = xy ?? "sample";

            Console.WriteLine(varZ);

            string xy1 = "sample2";
            string varZ1 = xy1 ?? "sample";

            Console.WriteLine(varZ1);

            Console.ReadKey();

        }
    }
}
