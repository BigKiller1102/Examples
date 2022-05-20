/////////////////////////////////////////////////////////////////////////////
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
            
            Console.Write("How many high scores do you want? ");
            int answer = Utility.ReadInt();
            for (int x = answer; x < 1; x++)
            {
                if (answer >= 1)
                {
                    bool answerT = Utility.IsReadGood();
                }
                else if (answer < 1)
                {
                    Console.Write("sorry that is not a valid amount of highscores. Try again. ");
                    answer = Utility.ReadInt();
                }
            }


            
            
            int[] numbers = { };
            numbers = new int[answer];


            
            
            for(int cntr = 0; cntr < numbers.Length; cntr++)
            {
                Console.Write("\n\n\tEnter highscore. ");
                numbers[cntr] = int.Parse(Console.ReadLine());
            }


            
            Console.WriteLine();
            Console.WriteLine("High Scores - Unsorted");

           
            PrintArray(numbers);


            
            SortArrayHighToLow(numbers);

            
            Console.WriteLine();
            Console.WriteLine("High Scores - Sorted");


            
            PrintArray(numbers);

            Console.Write("\n\nPress any key to exit . . .");
            Console.ReadKey();
        }

        
        static void PrintArray(int[] nums)
        {
            int x = 0;
            for(int cntr = 0; cntr < nums.Length; cntr++)
            {
                x = nums[cntr];
                Console.WriteLine(nums[cntr]);
            }
        }

        
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
