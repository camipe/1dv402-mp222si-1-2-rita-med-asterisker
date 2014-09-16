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
            for (int row = 1; row < 5; row++)
            {

                //switch (row)
                //{
                //    case 1:
                //        ConsoleColor.Yellow;

                //    case 2:
                //        ConsoleColor.Magenta;

                //    case 3:
                //        ConsoleColor.Green;
                //}
                    
                    if ((row % 2) == 0)
                    {
                        Console.Write(" ");
                    }
                
                    for (int col = 1; col < 39; col++)
                    {
                    
                        Console.Write("* ");
              
                    }
                    Console.WriteLine();
                
            }  
            
            

        }
    }
}
