using System;
using System.Threading;

namespace iterationVsRecursion
{
    internal class CountDown
    {
        public void countDown(int n)
        {
            if (n == 0) return;

            Console.WriteLine(n + "...");
            waitASecond();
            countDown(n - 1);
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