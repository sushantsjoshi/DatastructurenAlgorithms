using System;

namespace ConsoleApp2.Data
{
    public class ArrayRotation
    {
        public void FindRotationIndex()
        {
            //int[] arr = { 10, 12, 15, 17, 18, 20, 25 };
            //int[] arr = { 17, 18, 20, 25, 10, 12, 15 };
            int[] arr = { 17, 15, 12, 10, 25, 20, 18 };

            int min = 0;
            int max = arr.Length - 1;
            Console.WriteLine("Rotation: " + countRotations(arr, min, max));
        }

        public int countRotations(int[] arr, int low, int high)
        {
            if (high < low) return 0;
            if (high == low) return low;

            int mid = low + (high - low) / 2;

            if (mid < high && arr[mid] > arr[mid + 1])
                return mid + 1;
            if (mid > low && arr[mid] < arr[mid - 1])
                return mid;
            if (arr[high] > arr[mid])
                return countRotations(arr, low, mid - 1);
            return countRotations(arr, mid + 1, high);
        }
    }
}
