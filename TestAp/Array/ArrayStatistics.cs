namespace TestAp.Array
{
    using System;

    internal class ArrayStatistics
    {
        static string[] dayList = new string[]
        {
          "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday"
        };

        static string[,] famousCouples = new string[,]
        {
           {"George", "Marta" }, {"Napoleon", "Josephine" }, {"Westley", "Buttercup" }
        };

        static Weeble[] weebleList = new Weeble[]
        {
           new Weeble("Pilot"), new Weeble ("FireFighter")
        };

        //public static void Main() 
        //{
        //    Weeble[] newList = new Weeble[weebleList.Length];
        //    Array.Copy(weebleList, newList, weebleList.Length);
        //    newList[0] = new Weeble("Nurse");

        //    bool newReference = newList[0] != weebleList[0];
        //    Console.WriteLine("New rferences == " + newReference);

        //    string[,] newSquareArray = new string[
        //        famousCouples.GetLength(0), famousCouples.GetLength(1)];

        //    Array.Copy(famousCouples, newSquareArray, famousCouples.Length);


        //    string[] sortedDays = new string[dayList.Length];
        //    Array.Copy(dayList, sortedDays, dayList.Length);

        //    Array.Sort(sortedDays);

        //    for (int i = 0; i < sortedDays.Length; i++)
        //    {
        //        Console.WriteLine("sortedDays[{0}] = {1} ", i, sortedDays[i]);
        //    }


        //    int tuesdayindex = Array.BinarySearch(famousCouples, "George");

        //    Array.Reverse(sortedDays);

        //    for (int i = 0; i < sortedDays.Length; i++)
        //    {
        //        Console.WriteLine("Reveres sortedDays[{0}] = {1}",  i, sortedDays[i]);
        //    }

        //    Array.Clear(famousCouples, 2, 3);

        //    for (int x = 0; x < famousCouples.GetLength(0); x++)
        //    {
        //        for (int y = 0; y < famousCouples.GetLength(1); y++)
        //        {
        //            Console.WriteLine("FasmousCouples[{0}, {1}] = {2}", x, y, famousCouples[x, y]);
        //        }
        //    }
        //}
    }
}
