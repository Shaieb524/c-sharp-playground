namespace CSharp.DSandAlgo.Algorithms.Search
{
    public class Search
    {
        public int LinearSearch(List<int> arr, int arrLength, int item) 
        {
            for (int i = 0; i < arrLength; i++)
            {
                if (arr[i] == item) 
                    return arr[i];

            }
            return -1;
        }

        public int BinarySearchIterative(List<int> arr, int item)
        {
            int index = 0;
            var loopLength = arr.Count();

            while (index < loopLength) {
                var middle = loopLength/2;

                if (item == arr[middle])
                    return item;

                else if (item < arr[middle])
                    loopLength = middle - 1;

                else if (item > arr[middle])
                    index = middle + 1;

                index++;
            }

            return -1;
        }
        public int BinarySearchRecursive(int[] arr, int key, int leftIndex, int rightIndex)
        {

            if (leftIndex > rightIndex)
            {
                return -1;
            }
            else
            {
                int middle = (leftIndex + rightIndex) / 2;
                
                if (key == arr[middle])
                    return middle;
                
                else if (key < arr[middle])
                    return BinarySearchRecursive(arr, key, leftIndex, middle - 1);
                
                else if (key > arr[middle])
                    return BinarySearchRecursive(arr, key, middle + 1, rightIndex);
            }

            return -1;
        }
    }
}
