using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; 

namespace DriveFun
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
foreach (DriveInfo d in drives)
{
   Console.WriteLine("Name: {0}", d.Name);
   Console.WriteLine("Type: {0}", d.DriveType);
   if (d.IsReady)
   {
      Console.WriteLine("Free space: {0}", d.TotalFreeSpace);
      Console.WriteLine("Format: {0}", d.DriveFormat);
      Console.WriteLine("Label: {0}", d.VolumeLabel);
   }
   Console.WriteLine("***********************");
}

        }
    }
}
