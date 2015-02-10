using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ASCII_Dungeon;


namespace ASCII_Dungeon
{
    static class Program
    {
        public static Map map;
        public static bool victory = false;

        static void Main(string[] args)
        {

            Console.CursorVisible = false;
            map = new Map("Maps/Map.txt");
            Input control = new Input();
            map.Render();

            while(!victory)
            {
                Console.SetCursorPosition(61,19);
                map.PurgeDeadEnemies();
                if (control.KeyStroke()) //warte auf Tasteneingabe
                {
                    foreach (GameObject testobject in map.GameObjectList)
                    {
                        if (typeof(Hero) == testobject.GetType());
                        {
                            //lass den Held laufen/angreifen/Aktionen durchführen
                        }
                        if (typeof(Bird) == testobject.GetType())
                        {
                            Bird enemy = (Bird)testobject;
                            enemy.EnemyControl();
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
