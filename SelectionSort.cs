namespace Algorithms;
public partial class Program {
    public static int findSmallest(List<int> arr) {
        int smallest = arr[0];
        int smallestIndex = 0;
        for (int i = 1; i < arr.Count; i++) {
            if (arr[i] < smallest) {
                smallest = arr[i];
                smallestIndex = i;
            }
        }
        return smallestIndex;
    }

    public static List<int> selectionSort(List<int> arr) {
        List<int> newArr = new List<int>();
        for (int i = arr.Count; i > 0; i--) {
            int smallestIndex = findSmallest(arr);
            newArr.Add(arr[smallestIndex]);
            arr.RemoveAt(smallestIndex);
        }
        return newArr;
    }
}