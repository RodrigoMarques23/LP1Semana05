using System;
using System.Threading;
using System.Diagnostics;

namespace Tempo
{
    class Program
    {

        static void Main(string[] args)
        {
            //Declarate vars
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();


            //Stopwatch commands
            crono1.Start();
            Thread.Sleep(500);
            crono2.Start();
            Thread.Sleep(300);
            crono1.Stop();
            crono2.Stop();

            //Get elapsed time from each stopwatch
            TimeSpan c1 = crono1.Elapsed;
            TimeSpan c2 = crono2.Elapsed;

            //Print Values
            Console.WriteLine($"Tempo no crono1: {c1.Seconds:f2}");
            Console.WriteLine($"Tempo no crono2: {c2.Seconds:f2}");

        }
    }
}
