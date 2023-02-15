namespace TestAp.Fly
{
    internal class Hero : ActionCharacter, ICanFight, ICanSwim, ICanFly
    {
        public void Swim()
        {
            Console.WriteLine("Swimming");
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }

    }
}
