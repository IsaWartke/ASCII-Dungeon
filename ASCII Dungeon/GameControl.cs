using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ASCII_Dungeon;


namespace ASCII_Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.CursorVisible = false;
            Map map = new Map("Maps/Map.txt");
            Input control = new Input();
            //map.FullRender();
            while(true)
            {
                map.PurgeDeadEnemies();

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
