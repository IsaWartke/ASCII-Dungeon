using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    abstract class Character : GameObject
    {
        protected char[] Appearance = new char[4];
        protected byte LifePoints;
        protected byte AttackPoints;
        protected char ViewingDirection;
        protected Vector2 Coordinates;




        protected bool IsAttacked(byte attackPoints) {
            return false;
        }

    }
}
