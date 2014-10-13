using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ASCII_Dungeon
{
    public class Map
    {
        private char[,] _content;

        private List<Vector2> _dirtyFields = new List<Vector2>();

        public Map(string fileName)
        {
            LoadFromFile(fileName);
        }

        public void LoadFromFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            _content = new char[lines[0].Length, lines.Length];
            for (int x = 0; x <= _content.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= _content.GetUpperBound(1); y++)
                {
                    _content[x, y] = lines[y][x];
                }
            }
        }

        public void FullRender()
        {
            for (int x = 0; x <= _content.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= _content.GetUpperBound(1); y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(_content[x, y]);
                }
            }
        }

        public void Render()
        {
            foreach(Vector2 pos in _dirtyFields)
            {
                Console.SetCursorPosition(pos.X, pos.Y);
                Console.Write(_content[pos.X, pos.Y]);
            }
            _dirtyFields.Clear();
        }

        public void MarkAsDirty(Vector2 position)
        {
            _dirtyFields.Add(position);
        }
    }
}
