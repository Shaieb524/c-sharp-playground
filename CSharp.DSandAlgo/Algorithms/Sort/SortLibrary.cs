using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DSandAlgo.Algorithms.Sort
{
    public class SortLibrary
    {
        public static void SelectionSort(int[] A, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int position = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] < A[position])
                    {
                        //the new min
                        position = j;
                    }
                }

                // swap current min with left monst member
                int temp = A[i];
                A[i] = A[position];
                A[position] = temp;
            }
        }

        public static List<int> InsertionSort(List<int> arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                // select the hole to be inserted
                var currentValue = arr[i];
                var position = i;

                // locate the position for element to be inserted in
                while (position > 0 && currentValue < arr[position - 1])
                {
                    arr[position] = arr[position - 1];
                    position = position - 1;
                }

                // insert number at hole position
                arr[position] = currentValue;
            }

            return arr;
        }

        public static int[] BubbleSort(int[] A, int n)
        {
            for (int pass = n - 1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }

            return A;
        }
    }
}
