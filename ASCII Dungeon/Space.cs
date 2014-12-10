using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    class Space : GameObject
    {
        public override char ObjectAppearance
        {
            get { return ' '; }
        }

        public Space(int x, int y) : base(x,y) { }

        public Space(Vector2 vec) : base(vec.X, vec.Y) { }
    }
}
