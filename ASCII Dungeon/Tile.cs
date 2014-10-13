using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Tile
    {
        public int State;
        public int NextRoundState;

        //private int X;
        //private int Y;
        //private readonly Map _map;

        public Tile(int x, int y, Map map)
        {
            int X = x;
            int Y = y;
            Map _map = map;
        }

        public void Render()
        {
            switch (State)
            {
                case 0:
                    {
                        Console.Write(" ");
                    }
                    break;
                case 1:
                    {
                        Console.Write("x");
                    }
                    break;
                case 21: // Spieler nach oben gerichtet
                    {
                        Console.Write("O");
                    }
                    break;
                case 22: // Spieler nach unten gerichtet
                    {
                        Console.Write("U");
                    }
                    break;
                case 23: // Spieler nach links gerichtet
                    {
                        Console.Write("L");
                    }
                    break;
                case 24: // Spieler nach rechts gerichtet
                    {
                        Console.Write("R");
                    }
                    break;
                default:
                    {
                        Console.Write(" ");
                    }
                    break;
            }
        }

        public void Flush()
        {
            State = NextRoundState;
        }

        public void NextRound()
        {
            if (State == 1)
            {
                NextRoundState = 1;
            }
        }

    }
}
