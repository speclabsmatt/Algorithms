using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicHeights
{
    class BINS : Algorithm
    {
        public BINS(string input) : base(input) { }

        public void Run()
        {
            string[] lines = System.IO.File.ReadAllLines(@inputPath);
            int[] sortedArray = lines[2].Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] keys = lines[3].Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            string results = "";

            foreach (int key in keys)
                results += Search(sortedArray, key) + " ";

            Save(results);
        }

        //Binary Search Algorithm -- O(log n)
        private int Search(int[] array, int key)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (key < array[mid])
                    high = mid - 1;
                else if (key > array[mid])
                    low = mid + 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
