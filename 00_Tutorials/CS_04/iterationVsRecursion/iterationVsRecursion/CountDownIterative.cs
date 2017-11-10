using System;
using System.Threading;

namespace iterationVsRecursion
{
    internal class CountDownIterative
    {
        public void countDown(int n)
        {
            while (n > 0)
            {
                Console.WriteLine(n + "...");
                waitASecond();
                n -= 1;
            }

        }

        public void waitASecond()
        {
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception ignore)
            {
            }
        }
    }
}