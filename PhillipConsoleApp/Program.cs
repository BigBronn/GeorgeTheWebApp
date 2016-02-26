using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhillipConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool truefalse = true;
            int o = 1;
            double d = 22.5;
            string p = "words";

            Console.WriteLine("Pat");
            Console.WriteLine(p);
            Console.WriteLine(o + d);
            if (truefalse)
            {
                Console.WriteLine("was true");
            }
            string line = Console.ReadLine();
            Console.WriteLine(line);
            Console.ReadLine();
        }
    }
}
