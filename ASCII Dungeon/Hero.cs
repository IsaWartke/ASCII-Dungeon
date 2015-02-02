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
                //if (CollisionDetecion.isfree(x,y-1) == true)
                OldCoordinates = new Vector2(Coordin.X, Coordin.Y);
                Coordin.X--;
                NewCoordinates = Coordin;
                Move(NewCoordinates, OldCoordinates);
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
                //if (CollisionDetecion.isfree(x,y+1) == true)
                OldCoordinates = new Vector2(Coordin.X, Coordin.Y);
                Coordin.X++;
                NewCoordinates = Coordin;
                Move(NewCoordinates, OldCoordinates);
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
                //if (CollisionDetecion.isfree(x+1,y) == true)
                OldCoordinates = new Vector2(Coordin.X, Coordin.Y);
                Coordin.Y++;
                NewCoordinates = Coordin;
                Move(NewCoordinates, OldCoordinates);
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
                //if (CollisionDetecion.isfree(x-1,y) == true)
                OldCoordinates = new Vector2(Coordin.X, Coordin.Y);
                Coordin.Y--;
                NewCoordinates = Coordin;
                Move(NewCoordinates, OldCoordinates);
            }
        }

        public void strike()
        {
            switch (ViewingDirection)
            {
                case 'N':
                    //if (CollisionDetecion.isfree(x,y-1) == true)
                    //show sword at PlayerX, PlayerY-1; upwards.
                    // else PlaySound error/wallbounce
                    break;

                case 'S':
                    //if (CollisionDetecion.isfree(x+1,y) == true)
                    //show sword at PlayerX+1, PlayerY; rightwards.
                    // else PlaySound error/wallbounce
                    break;

                case 'E':
                    //if (CollisionDetecion.isfree(x,y+1) == true)
                    //show sword at PlayerX, PlayerY+1; downwards.
                    // else PlaySound error/wallbounce
                    break;

                case 'W':
                    //if (CollisionDetecion.isfree(x-1,y) == true)
                    //show sword at PlayerX-1, PlayerY; leftwards.
                    // else PlaySound error/wallbounce
                    break;
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
    }
}