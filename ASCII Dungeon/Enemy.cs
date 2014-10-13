using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    abstract class Enemy : Character
    {
        protected enum BehaviorStatus { Death, Walk, HaveBreak, Fight, Rotation };


        protected override abstract void Move();
    }
}
