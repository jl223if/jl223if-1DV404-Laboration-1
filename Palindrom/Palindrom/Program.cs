using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabler
            string read = "";
            string readReversed = "";

            //intro
            Console.Title = "Palindrom";
            Console.WriteLine("Skriv en textrad som testar ifall ordet är en palindrom");

            // kollar ifall ordet är av små bokstäver
            do
            {
                read = Console.ReadLine();
                if (read.Any(char.IsNumber))
                {
                    Console.WriteLine("ordet måste bestå endast av bokstäver!");
                }
                else if (read.Any(char.IsUpper))
                {
                    Console.WriteLine("bara ord med små bokstäver är tillåtna");
                }
                else break;
            } while (true);

            // omvänder ordet
            for (int i = read.Length - 1; i >= 0; i--)
            {
                readReversed = readReversed + read[i];
            }

            // talar om för användare ifall ordet är ett palindrom eller inte
            if (read == readReversed)
            {
                Console.WriteLine("ordet: {0} är en palindrom. ", readReversed);
            }
            else
            {
                Console.WriteLine("ordet: {0} är inte! en palindrom.", read);
            }
        }
    }
}




//ÖVRIG TEST KOD

//string reversed = Reverse(read);

//public static string Reverse(string s)
//{
//    char[] charArray = s.ToCharArray();
//    Array.Reverse(charArray);
//    return new string(charArray);
//}