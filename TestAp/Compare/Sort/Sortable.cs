namespace TestAp.Compare.Sort
{
    internal class Sortable : IComparable<Sortable> 
    {
        int i;
        internal Sortable(int i) 
        {
           this.i = i;
        }

        public int CompareTo(Sortable? other)
        {
            try
            {
                Sortable s = (Sortable)other;
                return i = s.i;

            }
            catch (InvalidCastException)
            {

                throw new ArgumentException();
            }
        }
    }
}
