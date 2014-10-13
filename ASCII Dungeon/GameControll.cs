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
            Map map = new Map("Maps/Map.txt");
            map.FullRender();

            while(true)
            {
                map.Render();
                Console.ReadKey();
            }
        }
    }
}
