using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    public class Sword : GameObject
    {
        private char ObjectApperance = '┼';
        private Vector2 MyVector;

        public Sword(Vector2 myVector)
        {
            this.MyVector = myVector;
        }

        public char ObjectApperance1
        {
            get { return ObjectApperance; }
            set { ObjectApperance = value; }
        }

        protected override void Move()
        {
            throw new NotImplementedException();
            //Sword bewegt sich nicht
        }
    }
}
