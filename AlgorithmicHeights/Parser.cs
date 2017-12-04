using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicHeights
{
    class Parser
    {
        public static void Run(string input, string prog)
        {
            switch (prog)
            {
                case "FIBO":
                    FIBO fibo = new FIBO(input);
                    fibo.Run();
                    return;
                case "BINS":
                    BINS bins = new BINS(input);
                    bins.Run();
                    return;
                case "DEG":
                    DEG deg = new DEG(input);
                    deg.Run();
                    return;
                case "INS":
                    INS ins = new INS(input);
                    ins.Run();
                    return;
                default:
                    Console.WriteLine("Invalid program name specified.");
                    return;
            }
        }
    }
}
