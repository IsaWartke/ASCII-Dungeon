using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    public class Wall : GameObject
    {
        public const char Symbol = '█';


        public override char ObjectAppearance
        {
            get { return Symbol; }
        }

        public Wall(int x, int y) : base(x,y) 
        {
            Render(Coordin, Coordin, ObjectAppearance);
        }
    }
}
