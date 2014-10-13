using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    abstract class Enemy
    {
        protected enum BehaviorStatus { Death, Walk, HaveBreak, Fight, Rotation };

        protected char[] Look = new char[4];
        protected BehaviorStatus behaviourStatus;
        protected byte Life;
        public byte EnemyGetDamage = 0;
        protected byte HeroGetDamage;
        protected char Richtung = 'r';



        protected abstract char EnemyBody(char richtung); // wie sieht der Feind aus

        protected abstract void CollisionDetection(); // wo sind Weande, Held, wohin kann ich gehen

        protected abstract void WalkSteps(); // gehe vorwearts 

        protected abstract void RotationStep(); // oder drehe

        protected abstract void Attack(); // greife an ziehe Held 1 Leben ab + Angriff Animation

        protected void EnemyLife(byte getDamage) // Wird mein leben verringert setze es runter oder behaviourStatus auf Death
        {
            Life -= getDamage;

            if (Life <= 0)
            {
                behaviourStatus = BehaviorStatus.Death;
            }
        }

        public abstract void PlayEnemy();







    }
}
