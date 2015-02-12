using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    class Bird : Enemy
    {
        private Vector2 OldCoordinates;
        private Vector2 NewCoordinates;


        public Bird(int x, int y)
            : base(x, y)
        {
            Appearance = new char[] { '>', '<', '-', '-' };
            AttackPoints = 1;
            LifePoints = 1;
            ViewingDirection = 'E';
            ObjectAppearance = '>';
            //Render(Coordin, Coordin, 'X');
        }

        /*
        if (LifePoints <= 0)
         * {
         *  GameObject.this.destroy;
         * }
        */

        public override void EnemyControl()
        {
            gotype CollisionObj = CollisionObject(NextStep(ViewingDirection, Coordin));

            switch (CollisionObj)
            {
                case gotype.Space:
                    switch (ViewingDirection)
                    {
                        case 'E': // East
                            OldCoordinates = new Vector2(Coordin.X, Coordin.Y);
                            Coordin.Y++;
                            NewCoordinates = Coordin;
                            break;
                        case 'W':
                            OldCoordinates = new Vector2(Coordin.X, Coordin.Y);
                            Coordin.Y--;
                            NewCoordinates = Coordin;
                            break;
                    }
                    Move(NewCoordinates, OldCoordinates);
                    break;

                case gotype.Wall:
                    Rotation(ViewingDirection);
                    Render(Coordin, Coordin, ObjectAppearance);
                    break;

                case gotype.Stone:
                    Rotation(ViewingDirection);
                    Render(Coordin, Coordin, ObjectAppearance);
                    break;

                case gotype.Enemy:
                    Rotation(ViewingDirection);
                    Render(Coordin, Coordin, ObjectAppearance);
                    break;

                case gotype.Sword:
                    Rotation(ViewingDirection);
                    Render(Coordin, Coordin, ObjectAppearance);
                    break;

                case gotype.Heart:
                    Rotation(ViewingDirection);
                    Render(Coordin, Coordin, ObjectAppearance);
                    break;

                case gotype.Door:
                    Rotation(ViewingDirection);
                    Render(Coordin, Coordin, ObjectAppearance);
                    break;

                case gotype.Hero:
                    Attack((Hero)GetGameObject(NextStep(ViewingDirection, Coordin)));
                    break;

                default:
                    break;
            }
        }


        protected void Attack(Hero hero)
        {
            hero.IsAttacked(AttackPoints);
        }

        protected Vector2 NextStep(char viewingDirection, Vector2 coordinates)
        {
            switch (viewingDirection)
            {
                case 'E': // East
                    return new Vector2(coordinates.X, coordinates.Y + 1);
                case 'W': // West
                    return new Vector2(coordinates.X, coordinates.Y - 1);
            }
            return Coordin;
        }


        protected void Rotation(char viewingDirection)
        {
            if (viewingDirection == 'E')
            {
                ViewingDirection = 'W';
                ObjectAppearance = Appearance[1];
            }
            else
            {
                ViewingDirection = 'E';
                ObjectAppearance = Appearance[0];
            }
        }
    }
}
