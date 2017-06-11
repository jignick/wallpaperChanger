using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;


namespace wallpaperChanger
{

    class Program
    {

        public static int getRandomIndex(int lenght)
        {
            var randomNumber = new Random();
            return randomNumber.Next(0, lenght-1);
        }

        static void Main(string[] args)
        {
            var wallpaperDirectory = "/home/jig/Pictures/wallpapers/";
            var fileNames = Directory.GetFiles(wallpaperDirectory);
            var indexOfWallpaper = getRandomIndex(fileNames.Length);
            var fehStart = new Process();
            fehStart.StartInfo.FileName = "feh";
            while (true)
            {
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
                indexOfWallpaper = getRandomIndex(fileNames.Length);
                Thread.Sleep(new TimeSpan(0,10,0));
            }

        }
    }
}
