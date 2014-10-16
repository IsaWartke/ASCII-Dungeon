using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    class Wall : GameObject
    {
 
        private Wall(Vector2 coordinates)
        {
        }

        private char ObjectApperance ='█';

        public char ObjectApperance1
        {
            get { return ObjectApperance; }
            set { ObjectApperance = value; }
        }


    }
}
