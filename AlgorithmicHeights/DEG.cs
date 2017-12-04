using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicHeights
{
    class DEG : Algorithm
    {
        public DEG(string input) : base(input) { }

        public void Run()
        {
            string[] lines = System.IO.File.ReadAllLines(@inputPath);
            int length = lines[0].Split(' ').Select(n => Convert.ToInt32(n)).First();
            int[] valueCount = new int[length];
            int[] raw;

            for (int i = 1; i < lines.Length; i++)
            {
                raw = lines[i].Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                valueCount[raw[0] - 1] += 1;
                valueCount[raw[1] - 1] += 1;
            }

            string results = "";
            for (int i = 0; i < valueCount.Length; i++)
                results += valueCount[i] + " ";

            Save(results);
        }
    }
}
