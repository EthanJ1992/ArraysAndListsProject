using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TODO comments
            //TODO:
            // Create an int Array and populate numbers 1-10 Done

            /* Create two Lists of type int.
             * 
             * Name one List "evens"
             * Name the other List "odds"
             */
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */


            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            #endregion
            var numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evens = new List<int>();
            var odds = new List<int>();
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            Console.WriteLine("this is my even list");
            for (int i = 0; i < evens.Count; i++)
            {
                Console.WriteLine(evens[i]);
            }

            Console.WriteLine("this is my odds list");
            foreach (var num in odds) 
            {
                Console.WriteLine($"{num} is an odd number");
            }
            

        }
    } 
}



