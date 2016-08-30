using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class LoopExamples
    {
        public void CountDownExampleUsingFor(int numberToCountDownFrom)
        {
            Console.WriteLine("Ready to count down from " + numberToCountDownFrom);
            for (int countDown = numberToCountDownFrom; countDown >= 0; countDown--)
            {
                Console.WriteLine(countDown);
            }

        }

        public void CountDownExampleUsingWhile(int numberToCountDownFrom)
        {
            Console.WriteLine("Ready to count down from " + numberToCountDownFrom);
            int countDown = numberToCountDownFrom;

            while (countDown >= 0)
            { 
                Console.WriteLine(countDown);
                countDown--;
            }

        }
        public void CountDownExampleUsingDo(int numberToCountDownFrom)
        {
            Console.WriteLine("Ready to count down from " + numberToCountDownFrom);
            int countDown = numberToCountDownFrom;

            do
            {
                Console.WriteLine(countDown);
                countDown--;
            } while (countDown >= 0);

        }
    }

}