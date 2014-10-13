using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    abstract class Character
    {
        protected char[] Appearance = new char[4];
        protected byte LifePoints;
        protected byte AttackPoints;
        protected char ViewingDirection;
        protected byte Xpos;
        protected byte Ypos;



        protected abstract void Move();

        protected void IsAttacked(byte attack_points) { }

    }
}
