using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
        class Input
    {
        public bool KeyStroke()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    // PlayerController.upwards();
                    Console.WriteLine("Im a up key!");            
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    // PlayerController.downwards();
                    Console.WriteLine("Im a down key!");
                }

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    // PlayerController.leftwards();
                    Console.WriteLine("Im a left key!");
                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    // PlayerController.rightwards();
                    Console.WriteLine("Im a rigth key!");
                }

                if (key.Key == ConsoleKey.Spacebar)
                {
                    // PlayerController.strike();
                    Console.WriteLine("Im a spacebar!");
                } 
                return true;                 
            }
            return false;
        }
    }
}
