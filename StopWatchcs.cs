using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatchcs
    {
        public void getStopWatch()
        {
            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();
            // Begin timing
            stopwatch.Start();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Shree");
            }
            // Stop timing
            stopwatch.Stop();
            Console.WriteLine("Total Time : {0}",stopwatch.Elapsed);
        }
    }
}
