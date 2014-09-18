using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_Rita_med_asterisker
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 25; row++)
            {

                // Checking which color to use for this row
                switch (row % 3)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                // if the row number is even, a space should be printed at the start of the row
                if ((row % 2) == 0)
                {
                    Console.Write(" ");
                }

                // Printing "* " 39 times 
                for (int col = 1; col <= 39; col++)
                {

                    Console.Write("* ");

                }
                //Creating a new row and reseting the colors before the loop starts over
                Console.WriteLine();
                Console.ResetColor();

            }



        }
    }
}
