using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    class Bird : Enemy
    {
        private Vector2 NewCoordinates;
        

        public Bird(int x, int y) : base(x,y) 
        {
            Appearance = new char[]{ 'X', 'B', '-', '-' };
            AttackPoints = 1;
            LifePoints = 1;
            ViewingDirection = 'E';
            ObjectAppearance = 'X';
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
                Move(NewCoordinates);
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
            if (typeof(Character) == ColissionObj.GetType())//Character durch Held ersetzen
            {
                Character hero = (Character) ColissionObj;
                hero.IsAttacked(AttackPoints);
            }
        }



        protected Vector2 NextStep(char viewingDirection, Vector2 coordinates)
        {
            switch (viewingDirection)
            {
                case 'E': // East
                    coordinates.X++;
                    return NewCoordinates = coordinates;
                case 'W': // West
                    coordinates.X--;
                    return NewCoordinates = coordinates;
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
