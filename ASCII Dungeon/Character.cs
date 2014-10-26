namespace ASCII_Dungeon
{
    abstract class Character : GameObject
    {
        protected char[] Appearance = new char[4];
        protected byte LifePoints;
        protected byte AttackPoints;
        protected char ViewingDirection;




        public void IsAttacked(byte attackPoints) {

        }

    }
}
