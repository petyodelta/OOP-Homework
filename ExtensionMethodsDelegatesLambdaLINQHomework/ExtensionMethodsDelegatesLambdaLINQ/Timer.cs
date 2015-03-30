using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public delegate void MyDelegate();

    class Timer
    {
        public MyDelegate CallDelegate { get; set; }
        public int Interval { get; set; }
        
        public Timer(int interval, MyDelegate myDelegate)
        {
            this.Interval = interval;
            this.CallDelegate = myDelegate;
        }

        public void ExecuteTimer(int repeatTimes)
        {
            for (int i = 0; i < repeatTimes; i++)
            {
                CallDelegate();
                Thread.Sleep(this.Interval * 1000);
            }
        }

        public static void TestMethod()
        {
            Console.WriteLine("Called by delegate");
        }

    }
}
