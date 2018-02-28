using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Test_Projekt
{
    class Program
    {
        static PerformanceCounter CPU;
        static PerformanceCounter RAM;

        static void Main(string[] args)
        {
            CPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            RAM = new PerformanceCounter("Memory", "Available MBytes");


            while (true)
            {
                Console.WriteLine(GetRAM());
                Console.WriteLine(GetCPU());
                System.Threading.Thread.Sleep(1000);
            }

        }

        static string GetCPU()
        {
            return CPU.NextValue() + "%";
        }

        static string GetRAM()
        {
            return RAM.NextValue() + "MB";
        }

    }
}
