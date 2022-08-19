using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DSandAlgo.Algorithms.Helper
{
    public class GeneralHelper
    {
        // extract min item from given list
        public static int GetMinIntFromList(List<int> arr)
        {
            int min = 0;

            // make first item min then compare and swap
            for (int i = 0; i < arr.Count; i++)
            {
                if (i == 0) min = arr[i];

                if (arr[i] < min) min = arr[i];
            }

            return min;
        }

        public static void SwapTwoVariables(dynamic firstVariable, dynamic secondVariable)
        {
            var temp = firstVariable;
            firstVariable = secondVariable;
            secondVariable = temp;
        }

    }
}
