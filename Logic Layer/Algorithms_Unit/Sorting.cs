namespace Algorithms_Unit
{
    
    public class Sorting

    {
        public delegate void SortingEventHandler(object sender, SortingStateDictionary sortingState);
        public static event SortingEventHandler? OnSwap;
        /// <summary>
        /// Call on each iteration of each algorithm with the exact state of all tracked variables
        /// </summary>
        static void SendIndices(KeyValuePair<int, int> swappedIndices)
        {
            OnSwap?.Invoke(null, new SortingStateDictionary(swappedIndices));
        }


        /*
         TODO:
            - QuickSort
            - HeapSort
            - BubbleSort
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
