﻿/////////////////////////////////////////////////////////////////////////////
// TODO:    BEFORE YOU WRITE ANY CODE: 
//          1) Read the Instructions.pdf file.
//          2) Run the example.exe to see how this program will behave.
//          3) Read through all of the TODOs. This will give you an overview
//          of how the program will be put together.
//
//          Unless where specified, the program does not have to look exactly
//          like the example (e.g. text doesn't have to be centered on screen)
/////////////////////////////////////////////////////////////////////////////
using System;
using FSPG;


namespace HighScoreTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Ask the user how many high scores they want.
            //       Then read in their input.
            //
            // ====> Support error checking (input validation).
            //
            //       **************************************************************
            //       ***********                                        ***********
            //       ***********     Int32.Parse and Convert.ToInt32    ***********
            //       ***********     DO NOT VALIDATE INPUT              ***********
            //       ***********                                        ***********
            //       **************************************************************
            //
            // ====> The user should only be able to input a POSITIVE
            //       integer value (greater than 0).
            //       You may use Utility.ReadInt() which returns an int
            //       and Utility.IsReadGood() which returns a bool to
            //       indicate if the last read (ReadInt) was successful
            Console.Write("How many high scores do you want? ");
            int answer = Utility.ReadInt();
            bool answerT = Utility.IsReadGood();


            // TODO: Define an array of ints, which will hold the high scores.
            //       Make the array the exact size indicated by the user above.
            int[] nums = { };
            nums = new int[answer];


            // TODO: Ask the user for each high score, and read in their inputs.
            //       Make sure to read in as many high scores are in the array.
            //       If the high score array is size 5, then read in 5 inputs.
            //       You DO NOT NEED to support error checking for each score;
            //       assume each input will be an integer.
            int numbers = 0;
            for(int cntr = 0; cntr < nums.Length; cntr++)
            {
                Console.Write("\n\n\tEnter highscore. ");
                numbers = Utility.ReadInt();
            }


            // TODO: Uncomment the following lines
            Console.WriteLine();
            Console.WriteLine("High Scores - Unsorted");

            // TODO: Call **your** PrintArray method (which you must write
            //       below - it's a separate TODO after the Main method)
            //       passing the array of high scores.
            PrintArray(nums);


            // TODO: Call the SortArrayHighToLow method (already written below so
            //       don't attempt to change/re-write it). Pass the array of high 
            //       scores, to sort them.
            SortArrayHighToLow(nums);

            // TODO: Uncomment the following lines
            Console.WriteLine();
            Console.WriteLine("High Scores - Sorted");


            // TODO: Call **your** PrintArray method (which you must write below)
            //       passing the array of high scores.
            PrintArray(nums);

            //Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write("\n\nPress any key to exit . . .");
            Console.ReadKey();
        }

        // TODO: Write a static method called PrintArray that accepts 
        //       a single int array parameter, and does not return
        //       anything.
        //       The function will loop through the array and print out
        //       each int on its own line.
        static void PrintArray(int[] numbers)
        {
            int highscores;
            for (int cntr = 1; cntr < numbers.Length; cntr++)
            {
                for (int cntr2 = cntr; cntr2 > 0 && numbers[cntr2] > numbers[cntr2 - 1]; cntr2--)
                {
                    highscores = numbers[cntr2];
                    numbers[cntr2] = numbers[cntr2 - 1];
                    numbers[cntr2 - 1] = highscores;
                }
            }
        }

        /// <summary>
        /// This procedure takes an array of ints and sorts them in place.
        /// After a call to this procedure the array of ints passed in will be
        /// sorted from highest to lowest.
        /// </summary>
        /// <param name="numbers">an array of ints to sort</param>
        static void SortArrayHighToLow(int[] numbers)
        {
            int tmp;
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = i; j > 0 && numbers[j] > numbers[j-1]; j--)
                {
                    tmp = numbers[j];
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = tmp;
                }
            }
        }
    }
}
