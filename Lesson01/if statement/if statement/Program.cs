using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            if (number1 > 5)
            { Console.WriteLine("number1 is greater than 5");
                if (number1 < 20)
                {
                    Console.WriteLine("number1 is less than   20");
                
                }
            }
        }
    }
}
