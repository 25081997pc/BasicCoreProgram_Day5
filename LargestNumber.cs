using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LargestNumber
    {
        public static void FindingLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the Largest of the three Number");

            Console.WriteLine("Input 1st Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 2nd Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 3rd Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st number is greatest among three");
                }
                else if (num3 > num2)
                {
                    Console.WriteLine("The 3rd number is greatest among three");
                }

            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd number is greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd number is greast among three");
            }
            

        }

    }
}
