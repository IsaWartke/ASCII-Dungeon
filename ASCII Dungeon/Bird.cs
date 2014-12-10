using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    class Bird : Enemy
    {
        private char[] Appearance = { '⦕', '⦖', ' ', ' ' }; // East, West, North, South
        private byte AttackPoints = 1;
        private char ObjectApperance = '⦕';
        char ViewingDirection = 'E';
        private Vector2 NewCoordinates;

        public override void EnemyControl()
        {
            GameObject ColissionObj = CollisionObject(NextStep(ViewingDirection, Coordin));

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
                ObjectApperance = Appearance[1];
            }
            else
            {
                ViewingDirection = 'E';
                ObjectApperance = Appearance[0];
            }
        }
    }
}
