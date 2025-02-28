using System;
using System.Net;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Start number:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Step number:");
            int step = int.Parse(Console.ReadLine());

            if (start <= 1)
            {
                Console.WriteLine("Out-of-Range Start or Step. Try again.");
                return;
            }
            
            if (step >= start)
            {
                Console.WriteLine("Start must be higher than step. Try again.");
                return;
            }
            
            if (start % step != 0) 
            {
                Console.WriteLine("Start not divisible by step. Try again.");
                return;
            }
            
            while (start != 0)
            {
                Console.WriteLine(start);
                start -= step;
            }
            Console.WriteLine(start);
        }
    }
}

