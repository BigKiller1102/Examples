using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programers_choice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello What is your name? ");
            string name = Console.ReadLine();

            
            Console.WriteLine("Welcome " + name + " Lets play the High or Low.");
            Console.WriteLine("Press Enter to continue. ");
            Console.ReadKey();
            Console.Clear();

            Random X = new Random();
            int answer = X.Next(0, 101);

            Console.WriteLine(name);

            bool Win = false;
            do
            {
                Console.Write("Geuss a number between 1-100\n");
                int A = int.Parse(Console.ReadLine());

                if (A < answer)
                {
                    Console.WriteLine("Higher.");
                }
                else if (A > answer)
                {
                    Console.WriteLine("Lower.");
                }
                else if( A == answer)
                {
                    Console.WriteLine("YOU WIN!!!");
                    Win = true;
                }
            } while (Win == false);

            Console.ReadKey();
        }
    }
}
