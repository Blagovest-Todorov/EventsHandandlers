namespace EventsHandandlers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat
            {
                Id = 1,
                Name = "My Tested ASP.Net",
                Health = 100
            };

            cat.OnHealthChanged += CatOnHealthChanged;
            cat.OnHealthChanged += CatIsDead;
            cat.Health = 200;

            for (int i = 0; i < 10; i++)
            {
                cat.Health -= 20;
            }
        }

        private static void CatIsDead(object sender, int health)
        {
            var cat = (Cat)sender;

            if (cat.Health <= 0)
            {
                Console.WriteLine($"{cat.Name} is no longer alive ..(");
            }
        }

        private static void Cat_OnHealthChanged(object sender, int health)
        {           
            throw new NotImplementedException();
        }

        private static void CatOnHealthChanged(object sender, int health ) 
        {
            var cat = (Cat)sender;
            Console.WriteLine($"{cat.Name} has new health {health}");
        }
    }
}