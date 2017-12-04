using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicHeights
{
    class Root
    {
        static void Main(string[] args)
        {
            Console.Write("Enter input path: ");
            string input = Console.ReadLine();

            Console.Write("Enter class to use: ");
            string prog = Console.ReadLine();

            Parser.Run(input, prog);
        }
    }
}
