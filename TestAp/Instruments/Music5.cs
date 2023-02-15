namespace TestAp.Instruments
{
    public class Music5
    {
        static void Tune(InterfaceInstrument i) 
        {
            i.Play();
        }

        static void TuneAll(InterfaceInstrument[] e) 
        {
            for (int i = 0; i < e.Length; i++)
            {
                Tune(e[i]);
            }
        }

        //public static void Main() 
        //{
        //    InterfaceInstrument[] orchestra = new InterfaceInstrument[5];
        //    int i = 0;
        //    orchestra[i++] = new Wind();
        //    orchestra[i++] = new Percussion();
        //    orchestra[i++] = new Stringed();
        //    orchestra[i++] = new Brass();
        //    orchestra[i++] = new WoodWind(); // upcastring to an interface type of the objects!!!!

        //    TuneAll(orchestra);
            
        //}
    }
}
