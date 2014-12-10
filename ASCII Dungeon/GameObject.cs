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

        protected virtual void Move(Vector2 coordinates)
        {
            Vector2 oldCoords = Coordin;
            Vector2 newCoords = coordinates;
            Render(oldCoords, newCoords, ObjectAppearance);
            Coordin = coordinates;
        }

        public virtual void Render(Vector2 oldCoords, Vector2 newCoords, char objectAppearance)
        {
            Console.SetCursorPosition(newCoords.Y, newCoords.X);
            Console.Write(objectAppearance);

            if (oldCoords != newCoords)
            {
            Console.SetCursorPosition(oldCoords.X, oldCoords.Y);
            Console.Write(" ");//Leerzeichenobjekt einfügen und in Liste der Map schreiben
            }
        }



        protected GameObject CollisionObject(Vector2 cordinates)
        {     
            return null;
        }


    }
}
