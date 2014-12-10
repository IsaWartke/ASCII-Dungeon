using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    public class Heart : GameObject
    {
        public override char ObjectAppearance
        {
            get { return '♥'; }
        }

        public Heart(int x, int y) : base(x,y) { }
    }
}
