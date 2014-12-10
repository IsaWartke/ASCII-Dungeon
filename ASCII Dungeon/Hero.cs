using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    class Hero : Character
    {
        private Vector2 NewCoordinates;
        
        public Hero(int x, int y) : base(x,y) 
        {
            Appearance = new char[] { '►', '◄', '▲', '▼' };
            AttackPoints = 1;
            LifePoints = 1;
            ViewingDirection = 'E';
            ObjectAppearance = '►';
        }
    }
}
