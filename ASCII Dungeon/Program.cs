using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            //Map map = new Map(9, 9);

            //map.InitLvl();
            //map.Render();
            //    map.NextRound();
            //    map.Flush();

          string[] lines = File.ReadAllLines("Map.txt");

          for (int i = 0; i < lines.Length; i++ )
          {
              Console.WriteLine(lines[i]);
          }

              Console.ReadKey();

        }
    }
}
