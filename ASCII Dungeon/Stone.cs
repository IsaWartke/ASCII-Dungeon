using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    public class Stone : GameObject
    {
        public override char ObjectAppearance
        {
            get { return '♦'; }
        }

        public Stone(int x, int y) : base(x,y) 
        {
            Render(Coordin, Coordin, ObjectAppearance);
        }
    }
}

