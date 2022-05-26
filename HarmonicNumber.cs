using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class HarmonicNumber
    {
        public static void PrintNthHarmonic()
        {

            int n;
            double s = 0.0;
            
            Console.WriteLine("Calculate the Harmonic series and their sum :\n");
            Console.WriteLine("---------");

            Console.WriteLine("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(" 1/{0} + ", i);
                s += (double)1 / i;
            }
            Console.WriteLine("\nSum of series upto {0} terms : {1} \n", n, s);
        }
    }
}
