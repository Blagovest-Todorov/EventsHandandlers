using System.Diagnostics.Contracts;

namespace TestAp.Compare
{
    internal class Couch : ICloneable
    {
        static int idCounter = 0;
        int id = idCounter++;

        Upholstery covering;
        Color aColor;

        //Couch Clone()
        //{
        //    Couch clone = new Couch();
        //    clone.covering = this.covering;
        //    clone.aColor = this.aColor;
        //    return clone;
        //}

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString() 
        {
            return String.Format("Couch is {0} {1}", aColor, covering);
        }

        //public static void Main() 
        //{
        //    Couch firstCouch = new Couch();
        //    firstCouch.covering = Upholstery.leather;
        //    firstCouch.aColor = Color.mauve;

        //    Couch secondCouch = (Couch)firstCouch.Clone(); 
        //    // Couch secondCouch = firstCouch;
        //    bool areTheSame = firstCouch == secondCouch;
        //    Console.WriteLine("{0} == {1} : {2}", 
        //        firstCouch, secondCouch, areTheSame);

        //    Console.WriteLine(firstCouch.id +  "  " + secondCouch.id);
        //}

        


        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }
    }
}
