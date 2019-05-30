using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex 1*/
            int size = 50;
            int[] nums = new int[size];
            Random rand = new Random();

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1,100);
            }

            Display(nums);
            

            /*Ex 2*/
            Console.WriteLine($"The value is located at index {FindIndex(nums)}");

            Console.ReadLine();

            /*Ex 3*/
            int[] copiedArray = new int[nums.Length];
            Array.Copy(nums, copiedArray, nums.Length);
            Display(copiedArray);

            /*Ex 4*/
            Array.Sort(copiedArray);
            Console.WriteLine("\n...Sorted Order...");
            Display(copiedArray);
            Console.WriteLine("\n...Reversed Order...");
            Array.Reverse(copiedArray);
            Display(copiedArray);
        }

        static int FindIndex(int[] arr)
        {
            Console.WriteLine("What value would you like to find: ");
            int input = int.Parse(Console.ReadLine());
            return Array.IndexOf(arr, input);
        }

        static void Display (int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
                if ((i+1) % 5 == 0)
                    Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
