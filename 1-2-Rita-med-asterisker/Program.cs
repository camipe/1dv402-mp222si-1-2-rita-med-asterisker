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
            for (int row = 0; row < 5; row++)
            {
                if ((row % 2) == 0)
                {
                    Console.Write();
                }
                
                for (int col = 0; col < 38; col++)
                {
                    Console.Write("* ");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }  
            
            

        }
    }
}
