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
            Map map = new Map(9, 9);

            map.InitLvl();
            map.Render();
                map.NextRound();
                map.Flush();
                Console.ReadKey();

        }
    }
}
