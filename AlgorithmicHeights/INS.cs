using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicHeights
{
    class INS : Algorithm
    {
        public INS(string input) : base(input) { }

        public void Run()
        {
            string[] lines = System.IO.File.ReadAllLines(@inputPath);
            int[] unsortedArray = lines[1].Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            Save(Sort(unsortedArray).ToString());
        }

        //Insertion Sort Algorithm -- O(n^2)
        private int Sort(int[] arr)
        {
            int swap = 0;
            int i, j;
            for (i = 1; i < arr.Length; i++)
            {
                int pick_item = arr[i];
                int inserted = 0;
                for (j = i - 1; j >= 0 && inserted != 1;)
                {
                    if (pick_item < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        swap++;
                        arr[j + 1] = pick_item;
                    }
                    else inserted = 1;
                }
            }

            return swap;
        }
    }
}
