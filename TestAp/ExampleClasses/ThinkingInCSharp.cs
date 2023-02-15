using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAp.ExampleClasses
{
    internal class ThinkingInCSharp
    {
        //  static void Main(string[] args)
        // {
        //// Task 3 and 4  // Chapter 4 /
        // for (int i = 1; i <= 100; i++)
        // {
        //     if (i == 47)
        //     {
        //         return;
        //     }

        //     Console.WriteLine($"{i}");
        // }

        //Task 5

        //string one = Console.ReadLine();
        //string two = Console.ReadLine();        

        //bool AreEqualStrings = CompareTwoStrings(one, two);

        //Console.WriteLine(AreEqualStrings); 


        // Task 6  firstWay          
        //List<int> nums = Generate25RandomNums(25);
        //var secNumber = nums[1];
        //PrintResultComparing25Nums(nums, secNumber);

        // Task 6 SecWay -> Endless Printing of numbers 

        //List<int> nums = new();
        //int secNumber;
        //Random rObject = new Random();
        //int rn; 

        //while (true)
        //{
        //    for (int i = 0; i <= 24; i++)
        //    {
        //        rn = rObject.Next();
        //        nums.Add(rn);
        //    }

        //    secNumber = nums[1];

        //    for (int i = 0; i <= 24; i++)
        //    {
        //        if (nums[i] > secNumber)
        //        {
        //            Console.WriteLine($" SecNumber {secNumber} is Lower than  curr number {nums[i]}");
        //        }
        //        else if (nums[i] == secNumber)
        //        {
        //            Console.WriteLine($" SecNumber {secNumber} is equal to curr number {nums[i]}");
        //        }
        //        else if (nums[i] < secNumber)
        //        {
        //            Console.WriteLine($" SecNumber {secNumber} is greater than curr number {nums[i]}");
        //        }
        //    }
        //}


        //Task 10 / Chapter 4;

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("Please enter a number");

        //    string inputString = Console.ReadLine();
        //    bool isNumber = int.TryParse(inputString, out var resultNumber);
        //    int inputNumber = 0;

        //    if (isNumber)
        //    {
        //        inputNumber = resultNumber;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"input {inputString} cannot be converted to a number");
        //        return;
        //    }

        //    switch (inputNumber)
        //    {
        //        case 1:
        //            Console.WriteLine("this is one");
        //            break;
        //        case 2:
        //            Console.WriteLine("This is two");
        //            break;
        //        default:
        //            Console.WriteLine("the number is neither 1 nor 2");
        //            break;
        //    }
        //}

        ///Chapter 5
        ///

        //unchecked 
        //{
        //    int number = Sum((int)10000000000);

        //}

        //  }

        private static int Sum(int num1)
        {
            int secByte = 1;
            int sum = num1 + secByte;
            return sum;
        }

        private static void PrintResultComparing25Nums(List<int> nums, int secNumber)
        {
            for (int i = 0; i <= 24; i++)
            {
                if (nums[i] < secNumber)
                {
                    Console.WriteLine($" SecNumber: {secNumber} is greater than curr number {nums[i]}");
                }
                else if (nums[i] == secNumber)
                {
                    Console.WriteLine($"SecNumber: {secNumber} is equal to curr number {nums[i]}");
                }
                else if (nums[i] > secNumber)
                {
                    Console.WriteLine($"SecNumber: {secNumber} is greater than curr number {nums[i]}");
                }
            }
        }

        private static List<int> Generate25RandomNums(int v)
        {
            List<int> nums = new List<int>();
            Random randomObj = new Random();
            int randomNumber;

            for (int i = 0; i <= 24; i++)
            {
                randomNumber = randomObj.Next();
                nums.Add(randomNumber);
            }

            return nums;
        }

        private static bool CompareTwoStrings(string v1, string v)
        {
            return v.Equals(v1);
        }
    }
}
