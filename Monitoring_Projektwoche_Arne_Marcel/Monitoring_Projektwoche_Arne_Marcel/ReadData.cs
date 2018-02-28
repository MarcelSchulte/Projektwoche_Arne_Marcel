using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Monitoring_Projektwoche_Arne_Marcel
{
    class ReadData
    {
        static PerformanceCounter CPU, RAM, RAMuse;

        static void InstallALL()
        {
            CPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            RAMuse = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            RAM = new PerformanceCounter("Memory", "Available MBytes");
        }

        static string GetCPU()
        {
            return CPU.NextValue() + "%";
        }

        static double GetRAM()
        {
            return RAM.NextValue();
        }

        static double GetRAMuse()
        {
            return RAMuse.NextValue();
        }

        static double GetHarddrive()
        {
            
            foreach (DriveInfo d in Festplatten)
            {
                return d.AvailableFreeSpace / (1024 * 1024 * 1024);
            }
        }

        static DriveInfo Festpaltte()
        {
            DriveInfo[] Festplatten = DriveInfo.GetDrives();
            return Festplatten;
        }
    }
}