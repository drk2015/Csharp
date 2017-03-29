using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {

            char x = 'X';
            char o = 'O';
            int rows = 8, columns = 8;
            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= columns; c++)
                {
                    //if the row is odd and:
                    if (r % 2 == 1)
                    {
                        //the column is odd, print X
                        if (c % 2 == 1)
                        {
                            Console.Write(x);
                        }
                        //the column is even, print O
                        if (c % 2 == 1)
                        {
                            Console.Write(o);
                        }
                    }
                    //if the row is even and
                    if (r % 2 == 0)
                    {
                        //the column is odd, print O
                        if (c % 2 == 1)
                        {
                            Console.Write(o);
                        }
                        //the column is even, print X
                        if (c % 2 == 1)
                        {
                            Console.Write(x);
                        }
                    }

                }
                Console.WriteLine();
            }


        }
    }
}
