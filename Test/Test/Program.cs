using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Text: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                string output = MorseCodeTranslator.ToMorse(input);
                Console.WriteLine(output);

             }

            while (true)
            {
                Console.Write("Morse: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                string output = MorseCodeTranslator.ToText(input);
                Console.WriteLine(output);

            }

        }

        public static List<int> GetPowersOf2(int value)
        {
            List<int> solution = new List<int>(value);
            for (int i = 0; i < value; i++)
            {
                solution.Add((int)System.Math.Pow(2,i));
            }
            
            return solution;
        }
    }
}
