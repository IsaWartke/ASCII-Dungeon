using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    abstract class Enemy : Character
    {
        public abstract void EnemyControl();

        protected byte LifePoints = 1;

        public bool IsDead { get { return LifePoints <= 0; } }
    }
}
