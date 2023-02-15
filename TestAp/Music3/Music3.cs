using System.Net;

namespace TestAp.Music3
{
    internal class Music3
    {
        static void Tune(Instrument i) 
        {
            i.Play();
        }

        static void TuneAll(Instrument[] e) 
        {
            foreach (Instrument i in e)
            {
                Tune(i);
            }
        }

        //public static void Main() 
        //{
        //    Instrument[] orchestra = new Instrument[5];
        //    int i = 0;
        //    orchestra[i++] = new Wind();
        //    orchestra[i++] = new Percussion();
        //    orchestra[i++] = new Stringed();
        //    orchestra[i++] = new Brass();
        //    orchestra[i++] = new Woodwind();

        //    TuneAll(orchestra);
        //}
    }
}
