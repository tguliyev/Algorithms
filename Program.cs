namespace Algorithms;
public static class Program {
    public static void Main(string[]? args) {
        int[] arr = new int[]{-34, 0, 1, 4, 6, 24, 33, 55, 2334};
        Console.WriteLine(BinarySearch.binarySearch(arr, 24));
    }
}