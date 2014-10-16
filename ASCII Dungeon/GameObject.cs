using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;           


namespace ASCII_Dungeon
{
    abstract class GameObject
    {

        protected Vector2 Coordin;
        protected char ObjectApperance;

        protected virtual void Move(Vector2 coordinates)
        {
            Vector2 oldCoords = Coordin;
            Vector2 newCoords = coordinates;
            Render(oldCoords, newCoords);
            Coordin = coordinates;
        }

        public virtual void Render(Vector2 oldCoords, Vector2 newCoords)
        {
            Console.SetCursorPosition(newCoords.X, newCoords.Y);
            Console.Write(ObjectApperance);
            Console.SetCursorPosition(oldCoords.X, oldCoords.Y);
            Console.Write(" ");//Leerzeichenobjekt einfügen
        }
    }
}
