using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    public class StopWatch
    {
        public void GetTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Watch start");
            Console.WriteLine("Enter the value for addition");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine(sum);
            stopwatch.Stop();
            Console.WriteLine("Watch stoped");
            Console.WriteLine("Time Elapsed: "+stopwatch.Elapsed);
        }
    }
}
