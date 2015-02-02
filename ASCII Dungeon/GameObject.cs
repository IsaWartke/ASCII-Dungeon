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

        protected GameObject CollisionObject(Vector2 coordinates)       //CollisionDetection
        {
            Map map = Program.map;
            foreach (GameObject go in map.GameObjectList)
            {
                if (go.Coordin.X == coordinates.X && go.Coordin.Y == coordinates.Y)
                {
                    return go;
                }
            }
            return null;
        }


    }
}
