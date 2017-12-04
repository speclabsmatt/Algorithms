using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicHeights
{
    abstract class Algorithm
    {
        protected string inputPath;

        public Algorithm(string input)
        {
            inputPath = input;
        }

        protected void Save(string output)
        {
            System.IO.File.WriteAllText(@"..\output.txt", output);
            Console.WriteLine("Output saved to output.txt");
        }
    }
}
