﻿using System;
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
            Input control = new Input();
            map.FullRender();

            while(true)
            {
                if (!control.KeyStroke())
                {
                    continue;
                }
                map.Render();
                Console.ReadKey();
            }
        }
    }
}
