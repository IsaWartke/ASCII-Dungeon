using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Map
    {
        private readonly Tile[,] tiles;

        public Map(int width, int height)
        {
            tiles = new Tile[width, height];
            for (int x = 0; x <= tiles.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= tiles.GetUpperBound(1); y++)
                {
                    tiles[x, y] = new Tile(x, y, this);
                }
            }

        }

        public void Render()
        {
            for (int x = 0; x <= tiles.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= tiles.GetUpperBound(1); y++)
                {
                    Console.SetCursorPosition(x, y);
                    tiles[x, y].Render();
                }
            }
        }

        public Tile GetTile(int x, int y)
        {
            return tiles[x, y];
        }

        public void NextRound()
        {
            for (int x = 0; x <= tiles.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= tiles.GetUpperBound(1); y++)
                {
                    tiles[x, y].NextRound();
                }
            }
        }

        public void Flush()
        {
            for (int x = 0; x <= tiles.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= tiles.GetUpperBound(1); y++)
                {
                    tiles[x, y].Flush();
                }
            }
        }

        public void InitLevel()
        {
            for (int x = 0; x <= tiles.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= tiles.GetUpperBound(1); y++)
                {
                    if (x == 0 || y == 0 ||
                        x == tiles.GetUpperBound(0) || y == tiles.GetUpperBound(1))
                    {
                        tiles[x, y].State = 1;
                    }
                    else
                    {
                        tiles[x, y].State = 0;
                    }
                }
            }
        }
    }
}
