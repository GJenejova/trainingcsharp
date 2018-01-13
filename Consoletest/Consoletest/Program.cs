using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoletest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            string name = Console.ReadLine();
            bool nameIsAdam = name == "Adam";
            Console.WriteLine("Your name is Adam: " + nameIsAdam);
            Console.WriteLine("Your name is: " + name);

            Console.ReadKey();
        }
    }
}
