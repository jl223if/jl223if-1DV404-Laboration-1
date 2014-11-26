using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fraction> Fractions = new List<Fraction>();

            Console.WriteLine("Divisions program");
            for (int i = 0; i < 2; i++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("tal {0}.", i + 1);
                Console.ResetColor();
                Console.Write("mata in täljaren: ");
                int numerator = int.Parse(Console.ReadLine());
                Console.Write("Mata i nämnaren: ");
                int deNumerator = int.Parse(Console.ReadLine());

                Fractions.Add(new Fraction(numerator, deNumerator));
            }

            Console.WriteLine("\n---------------------------------------\n");
            Console.WriteLine("Resultatet blir: {0}", Fractions[0]);
            Console.WriteLine("Resultatet blir: {0}", Fractions[1]);
            Console.WriteLine("\n---------------------------------------\n");
            for (int i = 0; i < Fractions.Count; i++)
            {
                if (Fractions[i].IsNegative())
                {
                    Console.WriteLine("tal {0} är negativt!", i + 1);
                }
            }
            if (Fractions[0].IsEqualTo(Fractions[0], Fractions[1]))
            {
                Console.WriteLine("tal 1 är detsamma som tal 2.");
            }
            Console.WriteLine("\n---------------------------------------\n");
            Fractions.Add(new Fraction(0, 0));
            Fractions[2].Add(Fractions[0], Fractions[1]);
            Console.WriteLine("additions av dom 2 talen blir: {0}", Fractions[2]);
            Fractions.Add(new Fraction(0, 0));
            Fractions[3].Multiply(Fractions[0], Fractions[1]);
            Console.WriteLine("Multiplikation av dom 2 talen blir: {0}", Fractions[3]);

        }
    }
}
