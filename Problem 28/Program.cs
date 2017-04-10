using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberSpiralDiagonals());
            Console.Read();
        }

        private static long NumberSpiralDiagonals()
        {
            long sum = 1;
            int step = 2;
            int stepSum = 1;
            int counter = 0;
            long total = 1001 * 1001;

            while (stepSum < total)
            {
                while (counter < 4)
                {
                    stepSum += step;
                    sum += stepSum;
                               
                    counter++;
                }
                counter = 0;
                step += 2;
               
            }
            return sum;
        }
    }
}
