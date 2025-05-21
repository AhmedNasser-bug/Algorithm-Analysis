using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithms_Unit.Sorting;

namespace Algorithms_Unit.Utils
{
    /// <summary>
    /// Utilities helping in sorting algorithms:
    ///     - Swap
    ///     - Partition
    ///     - Split
    ///     - Merge
    /// </summary>
    public class SortingUtils
    {
        public static void Swap<T>(ref T arr, int i, int j, object sender = null) where T : IList<Int128>
        {
            Int128 temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void Shuffle(ref List<Int128> values, object sender = null)
        {
            Random random = new Random();
            for (int i = 0; i < values.Count; i++)
            {
                int j = random.Next(i, values.Count);
                Swap(ref values, i, j, sender);
            }
        }

        /// <summary>
        /// Partition the array and return the pivot index
        /// </summary>
        internal static int Partition(List<Int128> arr, int low, int high, Metrics metrics, object sender = null)
        {
            metrics.TotalNumbersOfSteps++; // One step for function call

            // Choose the rightmost element as pivot
            Int128 pivot = arr[high];
            metrics.TotalNumbersOfArrayAccesses++; // For accessing the pivot

            // Index of smaller element
            int i = low - 1;

            // Traverse through all elements and compare them with pivot
            for (int j = low; j < high; j++)
            {
                metrics.TotalNumbersOfIterations++; // Count each iteration in the for loop
                metrics.TotalNumbersOfSteps++; // Count each step in the loop

                metrics.TotalNumbersOfComparisons++; // For the comparison with pivot
                metrics.TotalNumbersOfArrayAccesses++; // For accessing arr[j]

                // If current element is smaller than or equal to the pivot
                if (arr[j] <= pivot)
                {
                    i++; // Increment index of smaller element

                    // Swap elements
                    Swap(ref arr, i, j, sender);
                    Sorting.SendIndices(i, j, sender); // Fire event with swapped indices
                    metrics.TotalNumbersOfSwaps++;
                    metrics.TotalNumbersOfArrayAccesses += 2; // 2 for the swap
                }
            }

            // Swap the pivot element with the element at (i+1)
            // This puts the pivot in its correct sorted position
            Swap(ref arr, i + 1, high, sender);
            Sorting.SendIndices(i + 1, high, sender); // Fire event for the swap
            metrics.TotalNumbersOfSwaps++;
            metrics.TotalNumbersOfArrayAccesses += 2; // 2 for the swap

            metrics.TotalNumbersOfSteps++; // For returning

            // Return the position of the pivot
            return i + 1;
        }

        internal static void Merge(List<Int128> arr, List<Int128> temp, int left, int mid, int right, Metrics metrics, object sender = null)
        {
            metrics.TotalNumbersOfSteps++; // One step for function call

            // Copy data to temporary arrays
            for (int idx = left; idx <= right; idx++)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps++;

                temp[idx] = arr[idx];
                metrics.TotalNumbersOfArrayAccesses += 2; // 1 read + 1 write
            }

            // Merge the temporary arrays

            // Initial indices of subarrays
            int i = left;      // Initial index of first subarray
            int j = mid + 1;   // Initial index of second subarray
            int k = left;      // Initial index of merged subarray

            // Merge the subarrays back into arr[left..right]
            while (i <= mid && j <= right)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps++;
                metrics.TotalNumbersOfComparisons++;
                metrics.TotalNumbersOfArrayAccesses += 2; // Reading from both arrays for comparison

                if (temp[i] <= temp[j])
                {
                    // No actual swap, but we're placing elements in sorted order
                    arr[k] = temp[i];
                    metrics.TotalNumbersOfArrayAccesses += 2; // 1 read + 1 write

                    // Fire event to visualize the "movement" of element
                    Sorting.SendIndices(i, k, sender);
                    metrics.TotalNumbersOfSwaps++; // Count as a "swap" for metrics

                    i++;
                }
                else
                {
                    arr[k] = temp[j];
                    metrics.TotalNumbersOfArrayAccesses += 2; // 1 read + 1 write

                    // Fire event to visualize the "movement" of element
                    Sorting.SendIndices(j, k, sender);
                    metrics.TotalNumbersOfSwaps++; // Count as a "swap" for metrics

                    j++;
                }
                k++;
            }

            // Copy remaining elements of left subarray, if any
            while (i <= mid)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps++;

                arr[k] = temp[i];
                metrics.TotalNumbersOfArrayAccesses += 2; // 1 read + 1 write

                // Fire event for visualization
                Sorting.SendIndices(i, k, sender);
                metrics.TotalNumbersOfSwaps++;

                i++;
                k++;
            }

            // Copy remaining elements of right subarray, if any
            while (j <= right)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps++;

                arr[k] = temp[j];
                metrics.TotalNumbersOfArrayAccesses += 2; // 1 read + 1 write

                // Fire event for visualization
                Sorting.SendIndices(j, k, sender);
                metrics.TotalNumbersOfSwaps++;

                j++;
                k++;
            }

            metrics.TotalNumbersOfSteps++; // For returning from function
        }
    }
}