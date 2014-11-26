using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastStora
{
    class Program
    {
        static void Main(string[] args)
        {

            int save = 0;
            int secondSave = 0;
            Console.WriteLine("mata in 10 heltal. \n");
            
            for (int i = 0; i < 9; i++)
            {
                int input = 0;
                Console.Write("Mata in heltal nummer {0}: ", (i + 1));
                input = int.Parse(Console.ReadLine());

                if (input > save)
                {
                    if (secondSave < save)
                    {
                        secondSave = save;
                    }
                    save = input;
                }
            }
            Console.WriteLine("Näst största tal är {0}", secondSave);
        }
    }
}
