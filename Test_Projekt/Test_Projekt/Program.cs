using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Test_Projekt
{
    class Program
    {
        static PerformanceCounter CPU;
        static PerformanceCounter RAM;
        static PerformanceCounter RAMProzent;
        static PerformanceCounter CPUTemp;

        static void Main(string[] args)
        {
            CPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            RAM = new PerformanceCounter("Memory", "Available MBytes");
            RAMProzent = new PerformanceCounter("Memory", "% Committed Bytes In Use");

            while (true)
            {
                DriveInfo[] Festplatten = DriveInfo.GetDrives();
                Console.WriteLine(GetRAM() + " GB RAM noch frei");
                Console.WriteLine(GetRAM() + " RAM in gebrauch");
                Console.WriteLine(GetCPU() + " CPU auslastung");
                foreach (DriveInfo d in Festplatten)
                {
                    
                    Console.WriteLine((d.Name + d.TotalFreeSpace / (1024 * 1024 * 1024)) + " GB von insgesamt " + (d.TotalSize / (1024 * 1024 * 1024)) + " GB frei.");
                }
                System.Threading.Thread.Sleep(3000);
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
