using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = 10;
            for (int i = 1; i <= rows; i++) 
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((i % 2 == 0))
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write('0');
                        }
                        else
                        {
                            Console.Write('1');
                        }
                       
                    }
                    else
                    {
                        if ((j % 2 != 0))
                        {
                            Console.Write('1');
                        }
                        else
                        {
                            Console.Write('0');
                        }

                        
                    }
                }
                Console.WriteLine();
            }
    
            
            Console.ReadKey();
        }
    }
}
