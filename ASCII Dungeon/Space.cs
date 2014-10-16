using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    class Space : GameObject
    {
         private char ObjectApperance = ' ';
        private Vector2 MyVector;

        public Space(Vector2 myVector)
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
            //Space bewegt sich nicht
        }
    }
}
