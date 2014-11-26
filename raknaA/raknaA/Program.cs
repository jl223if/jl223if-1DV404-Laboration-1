using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raknaA
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfLowerCases = 0;
            int numberOfUpperCases = 0;

            Console.WriteLine("Mata in en textrad.");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                {
                    numberOfLowerCases++;
                }
                if (input[i] == 'A')
                {
                    numberOfUpperCases++;
                }
            }

            Console.WriteLine("antal Små a: {0} \antal stora A: {1}.", numberOfLowerCases, numberOfUpperCases);
        }
    }
}
