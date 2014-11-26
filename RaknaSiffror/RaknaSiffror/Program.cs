using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {

            int zeros = 0;
            int even = 0;
            int odd = 0;
            Console.WriteLine("Skriv in ett godtryckligt, positivt tal.");
            string read = Console.ReadLine();


            //ascii är ascii numret för just det tecknet.
            foreach (int ascii in read)
            {
                if (ascii == 48)
                {
                    zeros++;
                }
                if (ascii == 50 || ascii == 52 || ascii == 54 || ascii == 56)
                {
                    even++;
                }
                if (ascii == 49 || ascii == 51 || ascii == 53 || ascii == 55 || ascii == 57)
                {
                    odd++;
                }
            }

            Console.WriteLine("antal nollor: {0} antal udda tal {1}. Antal jämna tal {2}.", zeros, odd, even);
            
        }
    }
}
