using CSharp.DSandAlgo.Algorithms.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DSandAlgo.Algorithms.Sort
{
    public class CustomSelectionSort
    {
        // this custom sorting algorithm if of O(n^2) without swapping
        // because any order (even if sorted) the algo look for min in remaning elements
        public static int[] SortIntList(List<int> arr)
        {
            int[] sortedArr = new int[arr.Count];

            // clone the list for substract while looping
            var clonedArr = new List<int>(arr);

            for (int i=0; i<arr.Count; i++)
            {
                // extract min item from remaining list
                var currMin = GeneralHelper.GetMinIntFromList(clonedArr);

                // remove item from list
                int removeItemIndex = clonedArr.IndexOf(currMin);
                clonedArr.RemoveAt(removeItemIndex);

                // add extracted item to sorted list
                sortedArr[i] = currMin;
            }

            return sortedArr;
        }


    }
}
