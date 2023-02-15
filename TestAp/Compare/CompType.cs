namespace TestAp.Compare
{
    using System;
    internal class CompType : IComparable<CompType>
    {
        int i;
        int j;

        public CompType(int n1, int n2) 
        {
            i = n1;
            j = n2;
        }

        public int CompareTo(CompType? other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "[i = " + i + ",j  = "  + j + "]";
        }

        public int CompareTo(Object rv) 
        {
            int rvi = ((CompType)rv).i;

            if (i > rvi)           
                return i;            
            else if(i == rvi)            
                return 0;            
            else 
                return -1;
            

            // (i < rvi ? - 1 : (i == rvi ? 0 : 1))            
        }

        private static Random r = new Random();

        private static void ArrayPrint(String s, int[] a) 
        {
            Console.WriteLine(s);

            foreach (Object o in a)
            {
                Console.WriteLine(o + ", " );
            }
            Console.WriteLine();
        }


       // public static void Main() 
        //{
        //    CompType[] a = new CompType[10];

        //    for (int i = 0; i < 10; i++)
        //    {
        //        a[i] = new CompType(r.Next(100, r.Next(100)));
        //    }

        //    ArrayPrint("Before sorting, a = ", a);
        //    Array.Sort(a);
        //    ArrayPrint("After sorting,  a =", a );
        //}
    }
}
