using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ASCII_Dungeon;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

          string[] lines = File.ReadAllLines("Maps/Map.txt");

          for (int i = 0; i < lines.Length; i++ )
          {
              Console.WriteLine(lines[i]);
          }


          Sound ton = new Sound();
          ton.BackgroundSound();


              Console.ReadKey();

        }
    }
}
