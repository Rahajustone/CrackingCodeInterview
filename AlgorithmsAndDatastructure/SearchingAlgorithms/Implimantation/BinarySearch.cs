using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDatastructure.SearchingAlgorithms.Implimantation
{
    class BinarySearch
    {
        public static bool Search(int []arr, int target)
        {
            int lowest = 0;
            int highest = arr.Length - 1;

            while(lowest <= highest)
            {
                int mid = (lowest + highest) / 2;

                if (arr[mid] == target)
                    return true;
                
                if(arr[mid] < target)
                    lowest = mid + 1;
                else
                    highest = mid - 1;
            }

            return false;
        }

        // Recursive
        public static bool Search(int []arr, int target, int lowerBound, int higherBound)
        {
            int mid = (lowerBound + higherBound) / 2;

            if (lowerBound > higherBound) return false;

            if (arr[mid] == target) return true;

            if (arr[mid] < target) return Search(arr, target, mid+1, higherBound);
            if (arr[mid] > target) return Search(arr, target,lowerBound, mid-1);

            return false;
        }

        public static int findMin(int[] arr, int low, int height)
        {
            if (height < low)
                return arr[0];

            // if there is only 1 element
            if (height == low)

                return arr[low];

            int mid = low + (height - low) / 2;

            if (mid < height && arr[mid+1] < arr[mid])
                return arr[mid + 1];

            if (mid > low && arr[mid - 1] > arr[mid])
                return arr[mid];

            if (arr[height] > arr[mid])
                return findMin(arr, low, mid - 1);

            return findMin(arr, mid + 1, height);
        }
    }
}
