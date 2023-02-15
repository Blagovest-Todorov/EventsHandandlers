namespace TestAp.Animals
{
    internal abstract class Animal
    {
        public virtual void Move() 
        {
            Console.WriteLine(GetType() + " runs");
        }
    }
}
