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
        

        public Bird(int x, int y) : base(x,y) 
        {
            Appearance = new char[]{ '>', '<', '-', '-' };
            AttackPoints = 1;
            LifePoints = 1;
            ViewingDirection = 'E';
            ObjectAppearance = '>';
            //Render(Coordin, Coordin, 'X');
        }


        public override void EnemyControl()
        {
            GameObject ColissionObj = CollisionObject(NextStep(ViewingDirection, Coordin));

            if (ColissionObj == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (typeof(Space) == ColissionObj.GetType())
            {
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
            }
            if (typeof(Stone) == ColissionObj.GetType())
            {
                Rotation(ViewingDirection);
                Render(Coordin, Coordin, ObjectAppearance);
            }
            if (typeof(Sword) == ColissionObj.GetType())
            {
                Rotation(ViewingDirection);
                Render(Coordin, Coordin, ObjectAppearance);
            }
            if (typeof( Wall) == ColissionObj.GetType())
            {
                Rotation(ViewingDirection);
                Render(Coordin, Coordin, ObjectAppearance);
            }
            if (typeof(Enemy) == ColissionObj.GetType())
            {
                Rotation(ViewingDirection);
                Render(Coordin, Coordin, ObjectAppearance);
            }
            if (typeof(Hero) == ColissionObj.GetType())//Character durch Held ersetzen
            {
                Hero hero = (Hero)ColissionObj;
                hero.IsAttacked(AttackPoints);
            }
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
