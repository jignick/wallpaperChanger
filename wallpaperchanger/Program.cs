using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace wallpaperChanger
{

    class Program
    {

        public static int getRandomNumber(int lenght)
        {
            var randomNumber = new Random();
            return randomNumber.Next(0, lenght-1);
        }
        
        static void Main(string[] args)
        {
            var wallpaperDirectory = "/home/jig/Pictures/wallpapers/";
            
            var fileNames = Directory.GetFiles(wallpaperDirectory);
            var indexOfWallpaper = getRandomNumber(fileNames.Length);

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
