using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRILL_103
{
    class Program
    {
        static void Main(string[] args)
        {

            ////ONE DIMENSIONAL STRING ARRAY
            //string[] words = { "One", "Two" };
            //Console.WriteLine("Enter a number greater than two.");
            //string userInput = Console.ReadLine();
            //for (int i = 0; i < words.Length; i++)
            //{

            //    Console.WriteLine(words[i] + " " + userInput);
            //}

            //Console.ReadLine();

            //CREATE INFINITE LOOP
            //int infinateNum = 1;
            //for (int i = 0; i != infinateNum; i += 2)
            //{
            //    Console.WriteLine($"Infinate count: {i}");

            //}

            //FIX INFINITE LOOP
            //int loopCount = 1000;
            //for (int i = 0; i <= loopCount; i++)
            //{
            //    Console.WriteLine($"Numbers Counted: {i}");
            //    Console.WriteLine($"Numbers Left: {loopCount - i}");
            //}

            //Console.ReadLine();

            //LOOP USING THE < OPERATOR
            //int[] divbyTwo = { 2, 4, 6, 8, 10, 12, 14 };
            //for (int i = 0; i < divbyTwo.Length; i++)
            //{
            //    Console.WriteLine(divbyTwo[i]);
            //}

            //Console.ReadLine();

            //LOOP WITH "<=" OPERATOR
            //int[] divbyFour = { 4, 8, 12, 16, 20, 24 };
            //for (int k = 0; k <= divbyFour.Length - 1; k++)
            //{
            //    Console.WriteLine(divbyFour[k]);
            //}

            //Console.ReadLine();


            //LIST OF STRINGS. DISPLAY INDEX VALUE.
            //List<string> fruits = new List<string>() { "apple", "banana", "strawberry", "blueberry", "guava" };
            //Console.WriteLine("Enter fruit name.");
            //string _fruitInput = Console.ReadLine();

            //if (!fruits.Contains(_fruitInput))
            //{
            //    Console.WriteLine("Error. This name does not exist.");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    foreach (string fruitInput in fruits )
            //    {
            //        if (_fruitInput == fruitInput)
            //        {
            //            Console.WriteLine(fruits.IndexOf(fruitInput));
            //        }
            //    }
            //}

            //Console.ReadLine();


            //LIST OF STRINGS WITH AT LEAST 2 IDENTICAL STRINGS
            //DISPLAY IF STRING IS ALREADY IN THE LIST OR NOT
            List<string> elecMusic = new List<string>() { "Trance", "Dubstep", "House", "EDM", "Trap", "Trance" };
            Console.WriteLine("Enter a style of electronic music.");
            string _musicInput = Console.ReadLine();

            if (!elecMusic.Contains(_musicInput))
            {
                elecMusic.Add(_musicInput);
                Console.WriteLine("This music style does not exist in the list"); 
            }
            else
            {
                foreach (string musicInput in elecMusic) 
                {
                    if (_musicInput == musicInput)
                    {
                        Console.WriteLine("This music style already exists in the list.");
                    }
                }
            }

            Console.ReadLine();



        }
    }
}



