using System;
using PG2Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {


            string SP = Input.GetSpeech();
            char[] S = new char[] { ' ', '.', ',', '-', ':', '!', '?', '_', '\n', '\t', '\r' };
            string[] WL = SP.Split(S, StringSplitOptions.RemoveEmptyEntries);
            List<string> LW = WL.ToList();


            Dictionary<string, int> NW = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            for (int cntr = 0; cntr < LW.Count; cntr++)
            {
                if (NW.ContainsKey(LW[cntr]))
                {
                    NW[LW[cntr]] += 1;
                }
                else
                {
                    NW.Add(LW[cntr], 1);
                }
            }



            bool Menu = true;
            int MC;
            string[] MM = new string[] { "1. The Speech", "2. List of Words", "3. Show Histogram", "4. Search for Word", "5. Remove Word", "6. Exit" };


            while (Menu)
            {
                Console.Clear();
                Input.ReadChoice("Choice? ", MM, out MC);
                Console.Clear();

                switch (MC)
                {
                    case 1:
                        Console.WriteLine(SP);
                        Console.ReadLine();
                        break;
                    case 2:
                        ;
                        foreach (var A in LW)
                        {
                            Console.WriteLine(A);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        foreach (var words in NW)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(words);
                            Console.CursorLeft = 10;
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.Green;
                            for (int cntr = 0; cntr < words.Value; cntr++)
                            {
                                Console.Write(" ");
                            }
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine(words.Value);
                            Console.ResetColor();
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        string P = string.Empty;
                        int L;
                        Input.ReadString("What word are you looking for? ", ref P);
                        if (NW.ContainsKey(P))
                        {
                            if (NW.TryGetValue(P, out L))
                            {

                                Console.Write(P);
                                Console.CursorLeft = 10;
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                for (int cntr = 0; cntr < L; cntr++)
                                {
                                    Console.Write(" ");
                                }
                                Console.ResetColor();
                                Console.WriteLine($"\t{L} ");
                            }
                        }
                        else
                        {
                            Console.Write($"{P} is not valid in this speech");
                        }
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Have a nice day!");
                        Menu = false;
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
