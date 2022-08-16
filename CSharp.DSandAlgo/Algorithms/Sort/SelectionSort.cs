using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DSandAlgo.Algorithms.Sort
{
    public class SelectionSort
    {
        public static void selectionsort(int[] A, int n)
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
    }
}
