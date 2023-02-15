namespace TestAp.Music3
{
    internal class Percussion : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Percussion.Play()");
        }

        public override string What()
        {
            return "Percussion";
        }

        public override void Adjust() { }       
        
    }
}
