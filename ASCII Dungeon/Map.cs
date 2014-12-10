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
        public List<GameObject> GameObjectList = new List<GameObject>();

        private List<Vector2> _dirtyFields = new List<Vector2>();
        //Space-Objekt was bei Gegnertod erstellt wird in die GameObjectList speichern

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
                    InitGameObject(lines[x-1][y-1], x-1, y-1); 
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
        
        public void InitGameObject(char MapSymbol, int x, int y)
        {
            Vector2 myVector = new Vector2(x, y);
            switch (MapSymbol)
            {
                case '█':
                    Wall wall = new Wall(x,y);
                    wall.Render(myVector, myVector, wall.ObjectAppearance);
                    GameObjectList.Add(wall);
                    break;

                case ' ':
                    Space space = new Space(x, y);
                    space.Render(myVector, myVector, space.ObjectAppearance);
                    GameObjectList.Add(space);
                    break;

                case '♥':
                    Heart heart = new Heart(x, y);
                    heart.Render(myVector, myVector, heart.ObjectAppearance);
                    GameObjectList.Add(heart);
                    break;

                case '♦':
                    Stone stone = new Stone(x, y);
                    stone.Render(myVector, myVector, stone.ObjectAppearance);
                    GameObjectList.Add(stone);
                    break;

                case '┼':
                    Sword sword = new Sword(x, y);
                    sword.Render(myVector, myVector, sword.ObjectAppearance);
                    GameObjectList.Add(sword);
                    break;

                case '▒':
                    Door door = new Door(x, y);
                    door.Render(myVector, myVector, door.ObjectAppearance);
                    GameObjectList.Add(door);
                    break;

                case 'X':
                    Bird bird = new Bird(x, y);
                    bird.Render(myVector, myVector, bird.ObjectAppearance);
                    GameObjectList.Add(bird);
                    break;
            }
            
            //Wall checkWall = new Wall (x,y);
            //Heart checkHeart = new Heart(x,y);
            //Stone checkStone = new Stone(x,y);
            //Sword checkSword = new Sword(x,y);
            //Door checkDoor = new Door(x,y);
            //Space checkSpace = new Space(x,y);
            //Bird checkBird = new Bird(x, y);

            //if (MapSymbol == checkWall.ObjectAppearance) 
            //{
            //    checkWall.Render(myVector, myVector, checkWall.ObjectAppearance);
            //    GameObjectList.Add(checkWall);
            //}
            //else if (MapSymbol == checkBird.ObjectAppearance)
            //{
            //    checkBird.Render(myVector, myVector, checkBird.ObjectAppearance);
            //    GameObjectList.Add(checkBird);
            //}
            //else if (MapSymbol == checkHeart.ObjectAppearance)
            //{
            //    checkHeart.Render(myVector, myVector, checkHeart.ObjectAppearance);
            //    GameObjectList.Add(checkHeart);
            //}

            //else if (MapSymbol == checkStone.ObjectAppearance)
            //{
            //    checkStone.Render(myVector, myVector, checkStone.ObjectAppearance);
            //    GameObjectList.Add(checkStone);
            //}

            //else if (MapSymbol == checkSword.ObjectAppearance)
            //{
            //    checkSword.Render(myVector, myVector, checkSword.ObjectAppearance);
            //    GameObjectList.Add(checkSword);
            //}

            //else if (MapSymbol == checkDoor.ObjectAppearance)
            //{
            //    checkDoor.Render(myVector, myVector, checkDoor.ObjectAppearance);
            //    GameObjectList.Add(checkDoor);
            //}
            //else
            //{
            //    checkSpace.Render(myVector, myVector, checkSpace.ObjectAppearance);
            //    GameObjectList.Add(checkSpace);
            //}
        }

        public void PurgeDeadEnemies()
        {
            for (int i = GameObjectList.Count - 1; i >= 0; i--)
            {
                if (GameObjectList[i] is Enemy && (GameObjectList[i] as Enemy).IsDead)
                {
                    GameObjectList.Add(new Space(GameObjectList[i].Coordin));
                    GameObjectList.RemoveAt(i);
                }
            }
        }
    }
}
