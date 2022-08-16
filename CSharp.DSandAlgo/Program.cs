using CSharp.DSandAlgo.Algorithms.Sort;

List<int> list = new List<int> { 4, 3, 5, 7, 9, 44, 5, 2, 4, 6, 2, 3 };
var t = CustomSelectionSort.SortIntList(list);
Console.WriteLine(t);


int[] tt = new int[] { 3,5,8,9,6,2 };
SelectionSort.selectionsort(tt, 6);
Console.WriteLine(tt);
