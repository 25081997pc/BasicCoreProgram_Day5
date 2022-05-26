using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FlipCoin
    {
        public static void PrintTheHeadAndTailPercentage()
        {
            Console.WriteLine("Enter the number of times to FlipCoin");
            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;
            int HeadPercentage;
            int TailPercentage;

            int FlipCoin = Convert.ToInt32(Console.ReadLine());
            if (FlipCoin > 0)
            {
                for (int i = 1; i <= FlipCoin; i++)
                {
                    Random random = new Random();
                    int num = random.Next(2);
                    if (num == 1)
                    {
                        HeadCount++;
                    }
                    else
                    {
                        TailCount++;
                    }
                    Console.WriteLine(num);
                }
                HeadPercentage = HeadCount * 100 / FlipCoin;
                TailPercentage = TailCount * 100 / FlipCoin;

                Console.WriteLine("HeadPercentage : " + HeadPercentage);
                Console.WriteLine("TailPercentage : " + TailPercentage);
            }
        }
    }
}

