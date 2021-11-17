using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace LogicalPrograms
{
    public class Simulate
    {
        public void Calculate()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(6);
            }
            sw.Stop();
            Console.WriteLine("The lepse time is:{0:hh\\:mm\\:ss}", sw.Elapsed);
        }
    }
}
