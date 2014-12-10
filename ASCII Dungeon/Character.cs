namespace ASCII_Dungeon
{
    abstract class Character : GameObject
    {
        protected char[] Appearance = new char[4];
        protected byte LifePoints;
        protected byte AttackPoints;
        protected char ViewingDirection;


        public Character(int x, int y) : base(x,y) { }

        public void IsAttacked(byte attackPoints) {

        }

    }
}
