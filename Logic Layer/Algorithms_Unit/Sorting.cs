using Algorithms_Unit.Utils;
using System.Data;
using System.Diagnostics;
using static Algorithms_Unit.Utils.SortingUtils;
namespace Algorithms_Unit
{
    /// <summary>
    /// Contains Sorting algorithms for visualization, performance metrics and analysis
    /// </summary>
    public class Sorting
    {
        public delegate void SortingEventHandler(object sender, SortingStateDictionary sortingState);
        public  static event SortingEventHandler? OnSwap;

        /// <summary>
        /// Call on each iteration of each algorithm with the swapped indices for the sorting algorithm
        /// </summary>
        internal static void SendIndices(int idx1, int idx2, object sender = null)
        {
            OnSwap?.Invoke(
                sender, new SortingStateDictionary(new KeyValuePair<int, int>(idx1, idx2)));
        }

        /// <summary>
        /// BubbleSort algorithm that fires an event with the swapped indices as arguments for that event 
        /// </summary>
        static public Metrics BubbleSort(List<Int128> arr, object sender = null)
        {
            Metrics metrics = new Metrics(); // To track the performance metrics
            DateTime begin = DateTime.Now; // To track the runtime of the algorithm

            for (int i = 0; i < arr.Count - 1; i++)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps++;
                for (int j = 0; j < arr.Count - i - 1; j++)
                {
                    metrics.TotalNumbersOfIterations++;
                    metrics.TotalNumbersOfSteps++;


                    metrics.TotalNumbersOfComparisons++;
                    metrics.TotalNumbersOfArrayAccesses += 2;
                    if (arr[j] >= arr[j + 1])
                    {
                        metrics.TotalNumbersOfSteps += 3;
                        // To send by the array to the function by refence
                        Swap(ref arr, j, j + 1);
                        SendIndices(j, j + 1, sender);

                        metrics.TotalNumbersOfSwaps++;
                        metrics.TotalNumbersOfArrayAccesses += 4;
                    }
                    metrics.TotalNumbersOfArrayAccesses += 4; // 2 for the comparison and 2 for the swap
                }
            }
            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks; // Calculate the total runtime

            return metrics;
        }

        /// <summary>
        /// QuickSort algorithm that fires an event with the swapped indices as arguments for that event
        /// </summary>
        static public Metrics QuickSort(List<Int128> arr, object sender = null)
        {
            Metrics metrics = new Metrics(); // To track the performance metrics
            DateTime begin = DateTime.Now; // To track the runtime of the algorithm

            // Call the recursive QuickSort function
           QuickSortRecursive(arr, 0, arr.Count - 1, metrics, sender);

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks; // Calculate the total runtime
            metrics.TotalNumbersOfSteps += 2; // Computing runtime and returning

            return metrics;
        }

        public static Metrics HeapSort(List<Int128> arr, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            int n = arr.Count;
            metrics.TotalNumbersOfSteps++;
            metrics.TotalNumbersOfComparisons++;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfComparisons++;
                Heapify(arr, n, i, ref metrics, sender);
            }
            metrics.TotalNumbersOfComparisons++;
            for (int i = n - 1; i > 0; i--)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps += 3;
                metrics.TotalNumbersOfComparisons++;
                metrics.TotalNumbersOfArrayAccesses += 4;
                Int128 temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                metrics.TotalNumbersOfSwaps++;
                SendIndices(0, i, sender);
                Heapify(arr, i, 0, ref metrics, sender);
            }
            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
        }


        public static Metrics SelectionSort(List<Int128> arr, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;

            int n = arr.Count;
            metrics.TotalNumbersOfSteps++;
            metrics.TotalNumbersOfComparisons++;
            for (int i = 0; i < n - 1; i++)
            {
                metrics.TotalNumbersOfComparisons += 2;
                metrics.TotalNumbersOfSteps++;
                metrics.TotalNumbersOfIterations++;

                int min_idx = i;

                for (int j = i + 1; j < n; j++)
                {
                    metrics.TotalNumbersOfComparisons += 2;
                    metrics.TotalNumbersOfIterations++;
                    metrics.TotalNumbersOfArrayAccesses += 2;
                    if (arr[j] < arr[min_idx])
                    {
                        metrics.TotalNumbersOfSteps++;
                        min_idx = j;
                        SendIndices(j, j, sender);
                    }
                }

                Int128 temp = arr[i];
                arr[i] = arr[min_idx];
                arr[min_idx] = temp;
                metrics.TotalNumbersOfSwaps++;
                metrics.TotalNumbersOfArrayAccesses += 4;
                SendIndices(i, min_idx, sender);
            }
            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
        }

        public static Metrics InsertionSort(List<Int128> arr, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            int n = arr.Count;
            metrics.TotalNumbersOfSteps++;
            metrics.TotalNumbersOfComparisons++;
            for (int i = 1; i < n; ++i)
            {
                metrics.TotalNumbersOfSteps += 3;
                metrics.TotalNumbersOfIterations++;

                metrics.TotalNumbersOfArrayAccesses += 2;
                metrics.TotalNumbersOfComparisons += 3;

                int j = i - 1;

                while (j >= 0 && arr[j] > arr[j + 1])
                {
                    metrics.TotalNumbersOfIterations++;
                    metrics.TotalNumbersOfSteps += 4;
                    metrics.TotalNumbersOfArrayAccesses += 6;
                    metrics.TotalNumbersOfComparisons += 2;

                    Swap(ref arr, j, j + 1);
                    SendIndices(j, j + 1, sender);
                    j -= 1;
                }
            }
            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
        }

        public static Metrics MergeSort(List<Int128> arr, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            metrics.TotalNumbersOfSteps += 2;

            int s = 0;
            int e = arr.Count - 1;
            mergeSorth(arr, s, e, ref metrics, sender);

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
        }
    }
}