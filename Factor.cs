using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Factor
    {
        public static void PrimeFactor()
        {
            Console.WriteLine("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factors of given number :");

            if (num >= 2)
            {
                for (int i = 2; i <= num; i++)
                {
                    while (num % i == 0)
                    {
                        Console.Write("{0} ", i);
                        num = num / i;
                    }
                }
            }
        }
    }
}
