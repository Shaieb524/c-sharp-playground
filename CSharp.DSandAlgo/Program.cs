using CSharp.DSandAlgo.Algorithms.Helper;
using CSharp.DSandAlgo.Algorithms.Sort;

List<int> list = new List<int> { 5,3,4,7,2,8,6,9,1 };
int[] arr = { 5, 3, 4, 7, 2, 8, 6, 9, 1 };
var t = SortLibrary.BubbleSort(arr, 9);
Console.WriteLine(t);