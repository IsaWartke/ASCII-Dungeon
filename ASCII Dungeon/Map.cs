using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ASCII_Dungeon
{
    public class Map
    {
        private GameObject[,] _content;
        private List<GameObject> GameObjectList = new List<GameObject>();

        private List<Vector2> _dirtyFields = new List<Vector2>();

        public Map(string fileName)
        {
            LoadFromFile(fileName);
        }

        public void LoadFromFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            for (int x = 1; x <= lines.Length; x++)
            {
                for (int y = 1; y <= lines[x-1].Length; y++)
                {
                    GameObject myObject = checkGameObject(lines[x-1][y-1], x-1, y-1);
                    if (myObject != null)
                    {
                        myObject.Render();
                        GameObjectList.Add(myObject);
                    }
                }
            }
        }

        //public void FullRender()
        //{
        //    for (int x = 0; x <= _content.GetUpperBound(0); x++)
        //    {
        //        for (int y = 0; y <= _content.GetUpperBound(1); y++)
        //        {
        //            Console.SetCursorPosition(x, y);
        //            Console.Write(_content[x, y]);
        //        }
        //    }
        //}

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

        public GameObject checkGameObject(char MapSymbol, int x, int y)
        {
            Vector2 myVector = new Vector2(x, y);
            Wall checkWall = new Wall (myVector);
            Heart checkHeart = new Heart(myVector);
            Stone checkStone = new Stone(myVector);
            Sword checkSword = new Sword(myVector);
            Door checkDoor = new Door(myVector);
            Space checkSpace = new Space(myVector);


            if (MapSymbol == checkWall.ObjectApperance1) 
            {
                return checkWall;
            }

            if (MapSymbol == checkHeart.ObjectApperance1)
            {
                return checkHeart;
            }

            if (MapSymbol == checkStone.ObjectApperance1)
            {
                return checkStone;
            }

            if (MapSymbol == checkSword.ObjectApperance1)
            {
                return checkSword;
            }

            if (MapSymbol == checkDoor.ObjectApperance1)
            {
                return checkDoor;
            }
            else
            {
                return checkSpace;
            }
        }
    }
}
