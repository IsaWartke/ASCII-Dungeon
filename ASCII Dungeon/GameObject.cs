using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;           


namespace ASCII_Dungeon
{
    public abstract class GameObject
    {
        public GameObject() : this(0,0) { }

        public gotype type;

        public GameObject(int x, int y)
        {
            Coordin = new Vector2(x,y);
        }

        public Vector2 Coordin;

        public virtual char ObjectAppearance { get; set; }

        protected virtual void Move(Vector2 newCoords, Vector2 oldCoords)
        {
            Render(oldCoords, newCoords, ObjectAppearance);
            Coordin = newCoords;
        }

        public virtual void Render(Vector2 oldCoords, Vector2 newCoords, char objectAppearance)
        {
            Console.SetCursorPosition(newCoords.Y, newCoords.X);
            Console.Write(objectAppearance);

            if (oldCoords != newCoords)
            {
            Console.SetCursorPosition(oldCoords.Y, oldCoords.X);
            Console.Write(" ");     //Leerzeichenobjekt einfügen und in Liste der Map schreiben
            }
        }

        protected gotype CollisionObject(Vector2 coordinates)       //CollisionDetection
        {
            Map map = Program.map;

            List<gotype> foundObjects = new List<gotype>();

            foreach (GameObject go in map.GameObjectList)
            {
                if (go.Coordin.X == coordinates.X && go.Coordin.Y == coordinates.Y)
                {
                    if (go == null)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    if (typeof(Space) == go.GetType())
                    {
                        type = gotype.Space;
                    }
                    if (typeof(Wall) == go.GetType())
                    {
                        type = gotype.Wall;
                    }
                    if (typeof(Stone) == go.GetType())
                    {
                        type = gotype.Stone;
                    }
                    if (typeof(Enemy) == go.GetType())
                    {
                        type = gotype.Enemy;
                    }
                    if (typeof(Sword) == go.GetType())
                    {
                        type = gotype.Sword;
                    }
                    if (typeof(Heart) == go.GetType())
                    {
                        type = gotype.Heart;
                    }
                    if (typeof(Door) == go.GetType())
                    {
                        type = gotype.Door;
                    }
                    if (typeof(Hero) == go.GetType())
                    {
                        type = gotype.Hero;
                    }
                    foundObjects.Add(type);
                }
            }

            if (foundObjects.Count == 1)
                return foundObjects[0];

            return foundObjects.Where(g => g != gotype.Space).First();
        }
    }

    public enum gotype
        { 
            Space,
            Wall,
            Stone,
            Enemy,
            Sword,
            Heart,
            Door,
            Hero,
            missingno
        };
}
