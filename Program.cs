using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeFG
{
    class Program
    {
        static bool primE (ulong x)
        {
            ulong ig = (ulong)Math.Sqrt(x);
            if (x % 2 == 0 && x > 2 || x == 1) return false;
            for (ulong i = 3; i <= ig; i+= 2)
            {
                if (x % ig == 0) return false;
            }
            return true;
        }
        static void Main()
        {
            for (ulong i = 1; i < 21; i++)
            {
                if (primE(i)) Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
