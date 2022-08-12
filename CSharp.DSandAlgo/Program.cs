using CSharp.DSandAlgo.Algorithms.Search;

int[] arr = new int[] { 1,3,5,7,9 };

var t = new Search();
var tt = t.BinarySearchRecursive(arr, 7, 0, 4);

Console.WriteLine(tt);