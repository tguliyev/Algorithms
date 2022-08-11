namespace Algorithms;
public static partial class Program {
    public static void Main(string[]? args) {
        int[] arr = new int[]{345, 20, 1, -44, 64, -24, 33, 55, -2334};
        List<int> sortedArr = selectionSort(arr.ToList());
        for (int i = 0; i < sortedArr.Count; i++) {
            Console.WriteLine(sortedArr[i]);
        }
    }
}