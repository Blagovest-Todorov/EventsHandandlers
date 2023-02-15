using System.Text;

namespace TestAp.Array.FurnitureCl
{
    internal class Couch : Furniture, ICloneable
    {
        public object Clone()
        {
            Couch c = (Couch)MemberwiseClone();
            c.id = idCounter++;
            Console.WriteLine("Couch {0} cloned into Chouch {1}", id, c.id);
            return c;
        }

        protected Couch(Upholstery h, Color c) 
        {
            Console.WriteLine("Couch Created");
            Ottoman ottoman = new Ottoman();
            covering = h;
            aColor = c;
        }

        //public override string ToString()
        //{
        //    StringBuilder sb =  new StringBuilder();
        //    sb.AppendFormat("Couch {0} is {1} {2} with {3}", id, aColor, covering, ottoman);
        //    return sb.ToString();
        //}
    }



}
