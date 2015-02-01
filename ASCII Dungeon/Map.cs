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

                case '►':
                    Hero hero = new Hero(x, y);
                    hero.Render(myVector, myVector, hero.ObjectAppearance);
                    GameObjectList.Add(hero);
                    break;

                case '>':
                    Space space2 = new Space(x, y);
                    space2.Render(myVector, myVector, space2.ObjectAppearance);
                    GameObjectList.Add(space2);
                    Bird bird = new Bird(x, y);
                    bird.Render(myVector, myVector, bird.ObjectAppearance);
                    GameObjectList.Add(bird);
                    break;
            }
            
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
