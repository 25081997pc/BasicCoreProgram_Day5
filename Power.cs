using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Power
    {
        public static void Powerof2()
        {
            int N;
            Console.WriteLine("Enter the number");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Table of Power of 2: ");

            if (N > 0 && N <= 31)
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine("2^i : " + Math.Pow(2,i));

                    //Console.WriteLine("Table of 2 : 2 * {0} = {1}",i,(2 * i));
                }
            }
        }
    }
}
