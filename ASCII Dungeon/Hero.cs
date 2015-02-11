using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    public class Hero : Character
    {
        private Vector2 NewCoordinates;
        private Vector2 OldCoordinates;
        private bool sword = false;
        private char SwordAppearance = '┼';
        

        public Hero(int x, int y) : base(x, y)
        {
            Appearance = new char[] { '►', '◄', '▲', '▼' };
            AttackPoints = 1;
            LifePoints = 1;
            ViewingDirection = 'E';
            ObjectAppearance = '►';
        }

        public void upwards()
        {
            if (ViewingDirection != 'N')
            {
                ViewingDirection = 'N';
                Rotation(ViewingDirection);
                Render(Coordin, Coordin, ObjectAppearance);
            }
            else
            {
               Collision(NextStep(ViewingDirection, Coordin));
            }
        }

        public void downwards()
        {
            if (ViewingDirection != 'S')
            {
                ViewingDirection = 'S';
                Rotation(ViewingDirection);
                Render(Coordin, Coordin, ObjectAppearance);
            }
            else
            {
                Collision(NextStep(ViewingDirection, Coordin));
            }
        }

        public void rightwards()
        {
            if (ViewingDirection != 'E')
            {
                ViewingDirection = 'E';
                Rotation(ViewingDirection);
                Render(Coordin, Coordin, ObjectAppearance);
            }
            else
            {
                Collision(NextStep(ViewingDirection, Coordin));
            }
        }

        public void leftwards()
        {
            if (ViewingDirection != 'W')
            {
                ViewingDirection = 'W';
                Rotation(ViewingDirection);
                Render(Coordin, Coordin, ObjectAppearance);
            }
            else
            {
                Collision(NextStep(ViewingDirection, Coordin));
            }
        }

        public void strike()
        {
            if (sword == true)
            {
                switch (ViewingDirection)
                {
                    case 'N':
                        //Console.WriteLine("sword up");
                        SwordCollision(NextStep(ViewingDirection, Coordin));
                        break;

                    case 'S':
                        //Console.WriteLine("sword down");
                        SwordCollision(NextStep(ViewingDirection, Coordin));
                        break;

                    case 'E':
                        //Console.WriteLine("sword right");
                        SwordCollision(NextStep(ViewingDirection, Coordin));
                        break;

                    case 'W':
                        //Console.WriteLine("sword left");
                        SwordCollision(NextStep(ViewingDirection, Coordin));
                        break;
                }
            }
        }

        protected void Rotation(char ViewingDirection)
        {
            switch (ViewingDirection)
            {
                case 'N':
                    ObjectAppearance = Appearance[2];
                    break;

                case 'S':
                    ObjectAppearance = Appearance[3];
                    break;

                case 'E':
                    ObjectAppearance = Appearance[0];
                    break;

                case 'W':
                    ObjectAppearance = Appearance[1];
                    break;
            }
        }

        public void Collision(Vector2 check)
        {
            gotype CollisionObj = CollisionObject(check);

            switch (CollisionObj)
            {
                case gotype.Space:
                    Step(ViewingDirection);
                    break;

                case gotype.Wall:
                    break;

                case gotype.Stone:
                    /*if (CollisionObject(NextStep(ViewingDirection, NextStep(ViewingDirection, Coordin))) == gotype.Space)
                    {
                        Step(ViewingDirection);
                    }*/
                    break;

                case gotype.Enemy:
                    break;

                case gotype.Sword:
                    Step(ViewingDirection);
                    sword = true;
                    break;

                case gotype.Heart:
                    Step(ViewingDirection);
                    LifePoints += 1;
                    break;

                case gotype.Door:
                    Program.victory = true;
                    break;

                default:
                    break;
            }
        }

        public void SwordCollision(Vector2 check)
        {
            gotype swordcoll = CollisionObject(check);

            switch (swordcoll)
            {
                case gotype.Space:
                    // Render(check, check, SwordAppearance);
                    break;

                case gotype.Wall:
                    // play sound:bounceoff;
                    break;

                case gotype.Stone:
                    // play sound:bounceoff;
                    break;

                case gotype.Enemy:
                    // Render();
                    // Enemy.LifePoints -= Attackpoints;
                    break;

                case gotype.Heart:
                    // LifePoints += 1;
                    break;

                case gotype.Door:
                    // play sound:bounceoff;
                    break;

                default:
                    break;
            }
        }

        protected Vector2 NextStep(char viewingDirection, Vector2 coordinates)
        {
            switch (viewingDirection)
            {
                case 'N': // North
                    return new Vector2(coordinates.X - 1, coordinates.Y);
                case 'S': // South
                    return new Vector2(coordinates.X + 1, coordinates.Y);
                case 'E': // East
                    return new Vector2(coordinates.X, coordinates.Y + 1);
                case 'W': // West
                    return new Vector2(coordinates.X, coordinates.Y - 1);
            }
            return Coordin;
        }

        protected void Step(char viewingDirection)
        {
            OldCoordinates = new Vector2(Coordin.X, Coordin.Y);
            switch (viewingDirection)
            {
                case 'N': // North
                    Coordin.X--;
                    break;
                case 'S': // South
                    Coordin.X++;
                    break;
                case 'E': // East
                    Coordin.Y++;
                    break;
                case 'W': // West
                    Coordin.Y--;
                    break;
            }
            NewCoordinates = Coordin;
            Move(NewCoordinates, OldCoordinates);
        }
    }
}