using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicHeights
{
    class FIBO : Algorithm
    {
        public FIBO(string input) : base(input) { }

        public void Run()
        {
            int num = int.Parse(System.IO.File.ReadLines(@inputPath).First());
            Save(Fib(num).ToString());
        }

        //Recursive Fibonacci Algorithm
        private int Fib(int num)
        {
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            else
                return Fib(num - 1) + Fib(num - 2);
        }
    }
}
