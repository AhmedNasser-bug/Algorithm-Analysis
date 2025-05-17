using static Algorithms_Unit.Utils.SortingUtils;
namespace Algorithms_Unit
{
    /// <summary>
    /// Contains Sorting algorithms for visualization, performance metrics and analysis
    /// </summary>
    public class Sorting
    {
        public delegate void SortingEventHandler(object sender, SortingStateDictionary sortingState);
        public static event SortingEventHandler? OnSwap;

        /// <summary>
        /// Call on each iteration of each algorithm with the swapped indices for the sorting algorithm
        /// </summary>
        internal static void SendIndices(int idx1, int idx2)
        {
            OnSwap?.Invoke(
                null, new SortingStateDictionary(new KeyValuePair<int, int>(idx1, idx2)));
        }



        /// <summary>
        /// BubbleSort algorithm that fires an event with the swapped indices as arguments for that event 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>
        /// Metrics object containing the performance metrics of the algorithm:
        /// - TotalNumbersOfIterations
        /// - TotalNumbersOfSteps
        /// - TotalNumbersOfComparisons
        /// - TotalNumbersOfSwaps
        /// - TotalRuntimeTicks
        /// </returns>
        static public Metrics BubbleSort(List<Int128> arr)
        {
            Metrics metrics = new Metrics(); // To track the performance metrics
            DateTime begin = DateTime.Now; // To track the runtime of the algorithm

            for (int i = 0; i < arr.Count-1; i++)
            {
                for (int j = 0; j < arr.Count-i-1; j++)
                {
                    metrics.TotalNumbersOfIterations++;
                    metrics.TotalNumbersOfSteps++;


                    metrics.TotalNumbersOfComparisons++;
                    if (arr[j] >= arr[j+1])
                    {
                        // To send by the array to the function by refence
                        Swap(ref arr, j, j + 1);
                        SendIndices(j, j+1);
                        metrics.TotalNumbersOfSwaps++;
                    }
                    metrics.TotalNumbersOfArrayAccesses += 4; // 2 for the comparison and 2 for the swap
                }
            }
            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks; // Calculate the total runtime
            metrics.TotalNumbersOfSteps += 3;

            return metrics;
        }
        /// <summary>
        /// QuickSort algorithm that fires an event with the swapped indices as arguments for that event
        /// </summary>
        /// <param name="arr">The list to be sorted</param>
        /// <returns>
        /// Metrics object containing the performance metrics of the algorithm:
        /// - TotalNumbersOfIterations
        /// - TotalNumbersOfSteps
        /// - TotalNumbersOfComparisons
        /// - TotalNumbersOfSwaps
        /// - TotalRuntimeTicks
        /// - TotalNumbersOfArrayAccesses
        /// </returns>
        static public Metrics QuickSort(List<Int128> arr)
        {
            Metrics metrics = new Metrics(); // To track the performance metrics
            DateTime begin = DateTime.Now; // To track the runtime of the algorithm

            metrics.TotalNumbersOfSteps++; // Starting the algorithm

            // Call the recursive QuickSort function
            QuickSortRecursive(arr, 0, arr.Count - 1, metrics);

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks; // Calculate the total runtime
            metrics.TotalNumbersOfSteps += 2; // Computing runtime and returning

            return metrics;
        }
        /// <summary>
        /// Recursive helper method for QuickSort
        /// </summary>
        static private void QuickSortRecursive(List<Int128> arr, int low, int high, Metrics metrics)
        {
            metrics.TotalNumbersOfSteps++; // One step for calling the function

            if (low < high)
            {
                metrics.TotalNumbersOfComparisons++; // for the if check

                // Partition the array and get the pivot index
                int pivotIndex = Partition(arr, low, high, metrics);

                // Recursively sort elements before and after the pivot
                QuickSortRecursive(arr, low, pivotIndex - 1, metrics);
                QuickSortRecursive(arr, pivotIndex + 1, high, metrics);
            }
        }



            /*
             TODO:
                - QuickSort
                - HeapSort
                - SelectionSort
                - InsertionSort
                - MergeSort

                Input: List of integers
                Output: Result object (Refer to the result class) 
                Sorting is done in place for each algorithm

                Notes:
                    -For each iteration Call the SendIndices method with the swapped indices of the list 
                    -All methods must have a clone that does not fire the event 


             */
        }
    }
