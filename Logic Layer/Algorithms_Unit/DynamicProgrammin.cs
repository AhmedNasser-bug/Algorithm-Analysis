using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    public class DynamicProgramming
    {
        public delegate void ChoiceChangeEventHandler(object sender, DynamicProgrammingStateDictionary e);
        public delegate void CacheHitEventHandler(object sender, string HitState);
        public static event ChoiceChangeEventHandler? OnChoiceChange;
        public static event CacheHitEventHandler? OnCacheHit; 
        public static event SendIndicesEventHandler? OnCalculation;

        /// <summary>
        /// Call on each iteration of each algorithm with the exact state of all tracked variables
        /// </summary>
        public static void ChoiceChange((object SubProblem, object Answer) memoPair, int? ProcessedIdx, Dictionary<String, object> problemSpecificArgs, object sender = null)
        {
            // Call the event handler with the current state
            DynamicProgrammingStateDictionary state = new DynamicProgrammingStateDictionary(memoPair, ProcessedIdx ?? -1, problemSpecificArgs);
            OnChoiceChange?.Invoke(sender, state);
        }
        /// <summary>
        /// Happens on accessing the memo of a memoized solution of a dynamic programming problem
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Hit"></param>
        /// <param name="sender"></param>
        public static void CacheHit<T>(T Hit, object sender = null)
        {
            OnCacheHit?.Invoke(sender, $"{Hit?.ToString()}");
        }

        /// <summary>
        /// Sends indices to event subscribers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="indices"></param>
        public static void SendIndices(object sender = null, params List<int> indices)
        {
            OnCalculation?.Invoke(sender, indices);
        }

        /*
         TODO:
            - Fibo memoize
            - Fibo tabulate
            - Knapsack memoize(0/1 and infinite)
            - Knapsack tabulate(0/1 and infinite)

        Input is problem specific
        Output: metrics object

        Note:
            -All methods must fire the OnChoiceChange event with the current state of the algorithm each iteration
            -All methods must have a clone that does not fire the event 
         
         */

        public static Metrics FiboMemoized(int n, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime now = DateTime.Now;

            metrics.TotalNumbersOfSteps++;
            Dictionary<int, Int128> memo = new Dictionary<int, Int128>();

            Int128 result = FiboMemoizedHelper(n, memo, ref metrics, sender);

            metrics.TotalRuntimeTicks = (DateTime.Now - now).Ticks;
            return metrics;
        }

        private static Int128 FiboMemoizedHelper(int n, Dictionary<int, Int128> memo, ref Metrics metrics, object sender = null)
        {
            metrics.TotalNumbersOfSteps++;
            metrics.TotalNumbersOfIterations++;
            metrics.TotalNumbersOfComparisons++;
            if (n <= 1)
            {
                return n;
            }
            metrics.TotalNumbersOfArrayAccesses += 2;
            if (memo.ContainsKey(n)) // Cache Hit
            {
                metrics.TotalNumbersOfArrayAccesses++;
                metrics.TotalNumbersOfSteps++;
                CacheHit(n, sender);
                return memo[n];
            }

            Int128 result = FiboMemoizedHelper(n - 1, memo, ref metrics, sender) + FiboMemoizedHelper(n - 2, memo, ref metrics, sender);
            memo[n] = result; metrics.TotalNumbersOfSteps++;
            ChoiceChange((n, result), n, null, sender);
            return result;
        }

        public static Metrics FiboTabulated(int n, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;

            List<Int128> fibs = new() { 0, 1 };

            metrics.TotalNumbersOfComparisons++;
            for (int i = 2; i < n; i++)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps++;
                metrics.TotalNumbersOfArrayAccesses += 3;
                metrics.TotalNumbersOfComparisons++;

                Int128 f_1 = fibs[fibs.Count - 2], f_2 = fibs[fibs.Count - 1];
                fibs.Add(f_1 + f_2);
                ChoiceChange((i, fibs[fibs.Count - 1]), i, null, sender);
            }

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
        }

        static Int128 Max(Int128 x, Int128 y)
        {
            if (x >= y) return x;
            return y;
        }

        public static Int128 Knapsack_01MemoizedHelper(Int128 CurValue, int CurIdx, List<Int128> weights, List<Int128> values, Int128 capacity, ref Dictionary<Int128, Int128> memo, ref Metrics metrics, object sender = null)
        {
            metrics.TotalNumbersOfSteps++;
            metrics.TotalNumbersOfComparisons++;
            metrics.TotalNumbersOfIterations++;
            if (capacity <= 0)
            {
                return 0;
            }

            metrics.TotalNumbersOfArrayAccesses++;
            if (memo.ContainsKey(capacity))
            {
                CacheHit(capacity, sender);
                return memo[capacity];
            }

            metrics.TotalNumbersOfSteps++;
            metrics.TotalNumbersOfComparisons++;
            Int128 max = 0;
            for (int itemIdx = CurIdx; itemIdx < weights.Count; itemIdx++)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps += 2;
                metrics.TotalNumbersOfArrayAccesses += 2;
                metrics.TotalNumbersOfComparisons += 2;

                // Sending the indices of the current element and the compared one
                SendIndices(sender, CurIdx, itemIdx);

                // Choice between taking the element and not taking it
                max = Max(max, values[itemIdx] + Knapsack_01MemoizedHelper(CurValue, CurIdx + 1, weights, values, capacity - weights[itemIdx], ref memo, ref metrics, sender));
                max = Max(max, Knapsack_01MemoizedHelper(CurValue, CurIdx + 1, weights, values, capacity, ref memo, ref metrics, sender));
            }

            metrics.TotalNumbersOfArrayAccesses++;
            memo[capacity] = max;
            return max;
        }

        public static Metrics Knapsack_01Memoized(List<Int128> weights, List<Int128> values, Int128 capacity, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;

            metrics.TotalNumbersOfSteps++;
            Dictionary<Int128, Int128> memo = [];

            Knapsack_01MemoizedHelper(0, 0, weights, values, capacity, ref memo, ref metrics, sender);

            return metrics;
        }

        //public static Metrics Knapsack_01Tabulated(List<Int128> weights, List<Int128> values, List<Int128> capacity);
        //public static Metrics Knapsack_InfTabulated(List<Int128> weights, List<Int128> values, List<Int128> capacity);

        public static Int128 Knapsack_InfMemoizedHelper(Int128 CurValue, List<Int128> weights, List<Int128> values, Int128 capacity, ref Dictionary<Int128, Int128> memo, ref Metrics metrics, object sender = null)
        {
            metrics.TotalNumbersOfSteps++;
            metrics.TotalNumbersOfComparisons++;
            metrics.TotalNumbersOfIterations++;
            if (capacity <= 0)
            {
                return 0;
            }

            metrics.TotalNumbersOfArrayAccesses++;
            if (memo.ContainsKey(capacity))
            {
                return memo[capacity];
            }

            metrics.TotalNumbersOfSteps++;
            metrics.TotalNumbersOfComparisons++;
            Int128 max = 0;
            for (int itemIdx = 0; itemIdx < weights.Count; itemIdx++)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps += 2;
                metrics.TotalNumbersOfArrayAccesses += 2;
                metrics.TotalNumbersOfComparisons += 2;

                SendIndices(sender, itemIdx);

                // Choice between taking the element and not taking it
                max = Max(max, values[itemIdx] + Knapsack_InfMemoizedHelper(CurValue, weights, values, capacity - weights[itemIdx], ref memo, ref metrics, sender));
                max = Max(max, Knapsack_InfMemoizedHelper(CurValue, weights, values, capacity, ref memo, ref metrics, sender));
            }

            metrics.TotalNumbersOfArrayAccesses++;
            memo[capacity] = max;
            ChoiceChange((capacity, max), (int)capacity, null, sender);
            return max;
        }

        public static Metrics Knapsack_InfMemoized(List<Int128> weights, List<Int128> values, Int128 capacity, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;

            metrics.TotalNumbersOfSteps++;
            Dictionary<Int128, Int128> memo = [];

            Knapsack_InfMemoizedHelper(0, weights, values, capacity, ref memo, ref metrics, sender);

            return metrics;
        }
    }
}