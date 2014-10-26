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
        private byte LifePoints = 1;
        private byte AttackPoints = 1;
        private char ObjectApperance = '⦕';
        char ViewingDirection = 'E';
        private Vector2 NewCoordinates;


        public bool EnemyControl()
        {
            if (LifePoints == 0)
            { 
                return false;
                // Was im kommentar steht muss in gamecontrol erfolgen
                // lösche feind aus der character liste in GameControl
                // erstelle an der aktuellen position ein space object 
                // füge das space object in die GameObject list in der Class Map ein
            }
            GameObject ColissionObj = CollisionObject(NextStep(ViewingDirection, Coordin));

            if (typeof(Space) == ColissionObj.GetType())
            {
                Move(NewCoordinates);
            }
            if (typeof(Stone) == ColissionObj.GetType())
            {
                Rotation(ViewingDirection);
                Render(Coordin, Coordin, ObjectApperance1);
            }
            if (typeof(Sword) == ColissionObj.GetType())
            {
                Rotation(ViewingDirection);
                Render(Coordin, Coordin, ObjectApperance1);
            }
            if (typeof( Wall) == ColissionObj.GetType())
            {
                Rotation(ViewingDirection);
                Render(Coordin, Coordin, ObjectApperance1);
            }
            if (typeof(Enemy) == ColissionObj.GetType())
            {
                Rotation(ViewingDirection);
                Render(Coordin, Coordin, ObjectApperance1);
            }
            if (typeof(Character) == ColissionObj.GetType())//Character durch Held ersetzen
            {
                Character hero = (Character) ColissionObj;
                hero.IsAttacked(AttackPoints);
            }
            return true;   
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
