namespace TestAp.ExampleClasses
{
    internal class Viewer
    {
        static Random rand = new Random();
        int prefferedChannel = rand.Next(13);
        int prefferedVolume = rand.Next(10);

        static int counter = 0;
        int viewerId = counter++;

        void ChangeChannel(Television tv)
        {
            //Console.WriteLine("Viewer {0} doesnt like {1}, switch to {2}", viewerId, tv.Channel, prefferedChannel);
            //tv.Channel = prefferedChannel;
        }

        void ChangeVolume(ref Mp3Player p)
        {
            Console.WriteLine("Viewer {0} doesnt like {1}, switch to {2}",
                viewerId, p.Volume, prefferedVolume);
            p.Volume = prefferedVolume;
        }

        //public static void Main()
        //{
        //    Viewer v0 = new Viewer();
        //    Viewer v1 = new Viewer();
        //    Viewer v2 = new Viewer();

        //    // Television tv = new Television();
        //    Mp3Player player = new();
        //    v0.ChangeVolume(ref player);
        //    v1.ChangeVolume(ref player);
        //    v2.ChangeVolume(ref player);

        //    Console.WriteLine(v0.viewerId);
        //    Console.WriteLine(v1.viewerId);
        //    Console.WriteLine(v2.viewerId);
        //}
    }
}
