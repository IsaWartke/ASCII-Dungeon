using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Map map = new Map(19, 19); //Größe des Levels

            PlayerController control = new PlayerController(3, 3, map); // Startposition des Spielers

            control.OnKeyPress += control.HandleKey;

            map.InitLevel();
            control.InitPlayer();
            map.Render();

            while (true)
            {
                if (!control.MoveCheck())   // erst weitermachen, wenn eine Taste gedrückt wurde
                    continue;
                map.NextRound();
                map.Flush();
                map.Render();
            }

        }

    }
}
