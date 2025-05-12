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
        static void SendIndices(int idx1, int idx2)
        {
            OnSwap?.Invoke(null, new SortingStateDictionary(new KeyValuePair<int, int>(idx1, idx2)));
        }
        static private void Swap(ref List<Int128> arr, int i, int j)
        {
            Int128 temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public static void Shuffle(ref List<Int128> values)
        {
            Random random = new Random();
            for (int i = 0; i < values.Count; i++)
            {
                int j = random.Next(i, values.Count);
                Swap(ref values, i, j);
            }

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
        static public Metrics BubbleSort(ref List<Int128> arr)
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
                }
            }
            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks; // Calculate the total runtime
            metrics.TotalNumbersOfSteps += 3;

            return metrics;
        }
        static public Metrics BubbleSort_non_animation(ref List<Int128> arr)
        {
            Metrics metrics = new Metrics(); // To track the performance metrics
            DateTime begin = DateTime.Now; // To track the runtime of the algorithm



            for (int i = 0; i < arr.Count-i; i++)
            {
                for (int j = 0; j < arr.Count - i - 1; j++)
                {
                    metrics.TotalNumbersOfIterations++;
                    metrics.TotalNumbersOfSteps++;


                    metrics.TotalNumbersOfComparisons++;
                    if (arr[i] > arr[i + 1])
                    {
                        // To send by the array to the function by refence
                        Swap(ref arr, i, i + 1);
                        // SendIndices(i, j); // Removed for analysis purposes
                        metrics.TotalNumbersOfSwaps++;
                    }
                }
            }
            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks; // Calculate the total runtime
            metrics.TotalNumbersOfSteps += 3;

            return metrics;
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
