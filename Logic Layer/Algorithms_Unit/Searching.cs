using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
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
        public static void OnSearchChange(int ProcessedIdx, Dictionary<string, object>? problemSpecificArgs, object sender = null)
        {
            OnSearchIndexChange?.Invoke(sender, new SearchingStateDictionary(ProcessedIdx, problemSpecificArgs));
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


        public static Metrics LinearSearch(List<Int16> values, Int128 target, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            metrics.TotalNumbersOfSteps++;
            metrics.TotalNumbersOfComparisons++;


            for (int i = 0; i < values.Count; i++)
            {
                metrics.TotalNumbersOfComparisons += 2;
                // Highlight the current index
                OnSearchChange(i, null, sender);
                if (values[i] == target)
                {
                    OnSearchChange(i, new Dictionary<string, object> { { "found", true } });
                }
            }
            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
        }

        public static Metrics BinarySearch(List<Int128> values, Int128 target, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            metrics.TotalNumbersOfSteps++;
            metrics.TotalNumbersOfComparisons++;
            int low = 0;
            int high = values.Count - 1;
            int mid = low + (high - low) / 2;
            while (high >= low)
            {
                metrics.TotalNumbersOfComparisons += 4;
                metrics.TotalNumbersOfIterations++;
                // Highlight the current index
                Dictionary<string, object> bounds = new Dictionary<string, object>
                {
                    { "Low", low },
                    { "High", high }
                };
                OnSearchChange(mid, bounds, sender);

                if (values[mid] > target)
                {
                    metrics.TotalNumbersOfSteps += 2;
                    high = mid - 1;
                    mid = low + (high - low) / 2;
                }
                else if (values[mid] < target)
                {
                    metrics.TotalNumbersOfSteps += 2;
                    low = mid + 1;
                    mid = low + (high - low) / 2;
                }
                else if (values[mid] == target)
                {

                    OnSearchChange(mid, new Dictionary<string, object> { { "found", true } });
                }
            }

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
        }

        public static Metrics BinarySearch(List<Int16> values, Int16 target, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            metrics.TotalNumbersOfSteps++;
            metrics.TotalNumbersOfComparisons++;
            int low = 0;
            int high = values.Count - 1;
            int mid = low + (high - low) / 2;
            while (high >= low)
            {
                metrics.TotalNumbersOfComparisons += 4;
                metrics.TotalNumbersOfIterations++;
                // Highlight the current index
                Dictionary<string, object> bounds = new Dictionary<string, object>
                {
                    { "Low", low },
                    { "High", high }
                };
                OnSearchChange(mid, bounds, sender);

                if (values[mid] > target)
                {
                    metrics.TotalNumbersOfSteps += 2;
                    high = mid - 1;
                    mid = low + (high - low) / 2;
                }
                else if (values[mid] < target)
                {
                    metrics.TotalNumbersOfSteps += 2;
                    low = mid + 1;
                    mid = low + (high - low) / 2;
                }
                else if (values[mid] == target)
                {

                    OnSearchChange(mid, new Dictionary<string, object> { { "found", true } });
                }
            }

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
        }
    }
}