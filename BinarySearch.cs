namespace Algorithms;
public class BinarySearch {
    public static int binarySearch(int[] list, int item) {
        int low = 0;
        int hight = list.Length - 1;

        while(low <= hight) {
            int mid = (low + hight) / 2;
            int guess = list[mid];
            
            if (guess == item) return mid;
            else if (guess > item) hight = mid - 1;
            else low = mid + 1;
        }
        return -1;
    }
}