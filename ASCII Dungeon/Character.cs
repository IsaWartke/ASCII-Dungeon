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
        protected byte Xpos;
        protected byte Ypos;




        protected bool IsAttacked(byte attack_points) {
            return false;
        }


        protected override abstract void Move();
    }
}
