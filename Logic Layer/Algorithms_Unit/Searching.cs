using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
   
    public class Searching
    {
        public delegate void SearchingEventHandler(object sender, SearchingStateDictionary processedIndices);
        public static event SearchingEventHandler? OnSearchIndexChange;

        /// <summary>
        /// Call on each iteration of each algorithm with the exact state of all tracked variables
        /// </summary>
        public static void OnSearchChange(int ProcessedIdx, Dictionary<string, object> problemSpecificArgs)
        {
            OnSearchIndexChange?.Invoke(null, new SearchingStateDictionary(ProcessedIdx, problemSpecificArgs));
        }

        /*
         TODO: 
        public satitc LinearSearch(List<int> inputList, int target):
        -> Output: Result object

        public static BinarySearch(-Sorted list-, int target):
        -> Output: Result object

         Notes:
           -All methods must have a clone that does not fire the event 
           -Each function should call OnSearchChange() with the processed index as an argument
        
         
         */
    }
}
