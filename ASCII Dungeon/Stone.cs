using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    class Stone : GameObject
    {
        private char ObjectApperance = '♦';

        public char ObjectApperance1
        {
            get { return ObjectApperance; }
            set { ObjectApperance = value; }
        }

    }
}
