using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    class Voegel : Enemy
    {
        protected override char EnemyBody(char richtung)
        {
            char[] Look = { '⦕', '⦖', ' ', ' ' };

            switch (richtung)
            {
                case 'r'://right
                    return richtung = Look[0];

                case 'l'://left
                    return richtung = Look[1];

                default:
                    return '4';//fehler
            }

            // Auf Map an aktueller Position setzen
        }



        protected override void CollisionDetection(char richtung)
        {
            throw new NotImplementedException();
            // In Welche Richtung schaut er?
            //Pruefe in der Richtung ob durchdringbar, undurchdringbar (Wand, Fels, Tuer) oder Held
            // Je nachdem setze behaviourStatus auf walk, rotation oder Fight
            // Jede 10te Round setze behaviourStatus braek und tue nichts
        }



        protected override void WalkSteps()
        {
            throw new NotImplementedException();
            // Gehe zwei Felder vor
            // Tausche dabei Leerzeichen gegen EnemyBody(Richtung)
        }



        protected override void RotationStep(char richtung)
        {
            switch (richtung)
            {
                case 'r':
                    Richtung = 'l';
                    break;

                case 'l':
                    Richtung = 'r';
                    break;
            }
            EnemyBody(Richtung);
        }



        protected override void Attack()
        {
            throw new NotImplementedException();
            // Angriffsanimation/Zeichen vielleicht kurzes invertieren oder Xen des Helden
            // HeroGetDamage an das Leben des Helden uebergeben
        }




        public override void PlayEnemy()
        {
            EnemyLife(EnemyGetDamage);

            while (behaviourStatus != BehaviorStatus.Death)
            {

                CollisionDetection(EnemyBody(Richtung));

                switch (behaviourStatus)
                {
                    case BehaviorStatus.Walk:
                        WalkSteps();
                        break;

                    case BehaviorStatus.Rotation:
                        RotationStep(Richtung);
                        break;

                    case BehaviorStatus.Fight:
                        Attack();
                        break;

                    case BehaviorStatus.HaveBreak:
                        break;
                }
            }
        }
    }
}
