using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace wallpaperChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            var wallpaperDirectory = "/home/jig/Pictures/wallpapers/";
            var randomWallpaper = new Random();
            var fileNames = Directory.GetFiles(wallpaperDirectory);
            var indexOfWallpaper = randomWallpaper.Next(0, fileNames.Length-1);

            Process fehStart = new Process();
            fehStart.StartInfo.FileName = "feh";

            if (fileNames[indexOfWallpaper] != (wallpaperDirectory+"blondebitch.jpg") 
                && fileNames[indexOfWallpaper] != (wallpaperDirectory+"15.jpg"))
        {
                fehStart.StartInfo.Arguments = "--bg-scale "+fileNames[indexOfWallpaper];
                fehStart.Start();
        }
            else
            {
                fehStart.StartInfo.Arguments = "--bg-center "+fileNames[indexOfWallpaper];
                fehStart.Start();
            }
         

        }
    }
}
