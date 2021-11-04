using System;

namespace binarySearch1
{
    class Program
    {
        public static bool binarySearch(int[] arr,int start, int end, int target)
        {
            if (start > end)
            {
                Console.WriteLine("The target is not in the assigned array.");
                return false; 
            }
            int midIndex = Convert.ToInt32(Math.Floor(Convert.ToDouble((start+end)/2)));
            if (arr[midIndex] == target)
            {
                Console.WriteLine($"The target was found at position {midIndex}.");
                return true;
                
            }
            if (arr[midIndex]>target)
            {
                return binarySearch(arr,start,midIndex-1,target);
            }
            else
            {
                return binarySearch(arr,midIndex+1,end,target);
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int start = 0;
            int end = array.Length-1;
            int targer = 1;
            bool s = binarySearch(array, start, end, targer);
        }
    }
}
