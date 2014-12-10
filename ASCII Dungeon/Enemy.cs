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

        public Enemy(int x, int y) : base(x,y) { }

        public bool IsDead { get { return LifePoints <= 0; } }
    }
}
