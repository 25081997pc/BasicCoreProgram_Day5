using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class EvenorOdd
    {
        public static void CheckNumberEvenorOdd()
        {
            int n;
            Console.WriteLine("Enter the number to check even or odd");
            n = Convert.ToInt32(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
        
    }
}
