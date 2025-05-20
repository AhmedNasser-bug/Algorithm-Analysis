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
        public delegate void CacheHitEventHandler(string HitState);
        public static event ChoiceChangeEventHandler? OnChoiceChange;
        public static event CacheHitEventHandler? OnCacheHit;
        public static event SendIndicesEventHandler? OnCalculation;

        

        /// <summary>
        /// Call on each iteration of each algorithm with the exact state of all tracked variables
        /// </summary>
        public static void ChoiceChange((object SubProblem, object Answer) memoPair, int? ProcessedIdx, Dictionary<String, object> problemSpecificArgs)
        {
            // Call the event handler with the current state
            DynamicProgrammingStateDictionary state = new DynamicProgrammingStateDictionary(memoPair, ProcessedIdx ?? -1, problemSpecificArgs);

            OnChoiceChange?.Invoke(null, state);
        }
        public static void CacheHit<T>(T Hit)
        {
            OnCacheHit?.Invoke($"{Hit?.ToString()}");
        }
        public static void SendIndices(params List<int> indices)
        {
            OnCalculation?.Invoke(indices);
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

        public static Metrics FiboMemoized(int n)
        {
            Metrics metrics = new Metrics();
            DateTime now = DateTime.Now;

            metrics.TotalNumbersOfSteps++;
            Dictionary<int, Int128> memo = new Dictionary<int, Int128>();

            Int128 result = FiboMemoizedHelper(n, memo,ref metrics);

            metrics.TotalRuntimeTicks = (DateTime.Now - now).Ticks;
            return metrics;

        }
        private static Int128 FiboMemoizedHelper(int n, Dictionary<int, Int128> memo,ref Metrics metrics)
        {
            metrics.TotalNumbersOfSteps++;
            metrics.TotalNumbersOfIterations++;
            metrics.TotalNumbersOfComparisons++;
            if (n <= 1)
            {
                return n;
            }
            metrics.TotalNumbersOfArrayAccesses += 2;
            if (memo.ContainsKey(n))
            {
                metrics.TotalNumbersOfArrayAccesses++;
                metrics.TotalNumbersOfSteps++;
                CacheHit(n);
                return memo[n];
            }

            Int128 result = FiboMemoizedHelper(n - 1, memo,ref metrics) + FiboMemoizedHelper(n - 2, memo,ref metrics);
            memo[n] = result; metrics.TotalNumbersOfSteps++;
            ChoiceChange((n, result), n, null);
            return result;
        }


        public static Metrics FiboTabulated(int n)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;

            List<Int128> fibs = new() {0, 1};

            metrics.TotalNumbersOfComparisons++;
            for(int i = 2; i < n; i++)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps++;
                metrics.TotalNumbersOfArrayAccesses += 3;
                metrics.TotalNumbersOfComparisons++;
    
                Int128 f_1 = fibs[fibs.Count - 2], f_2 = fibs[fibs.Count-1];
                fibs.Add(f_1 + f_2);
                ChoiceChange((i, fibs[fibs.Count-1]), i, null);
            }

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
        }

        static Int128 Max(Int128 x, Int128 y)
        {
            if (x >= y) return x;
            return y;
        }
        public static Int128 Knapsack_01MemoizedHelper(Int128 CurValue, int CurIdx, List<Int128> weights, List<Int128> values, Int128 capacity,ref Dictionary<Int128, Int128> memo, ref Metrics metrics)
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
            for(int itemIdx = CurIdx; itemIdx <  weights.Count; itemIdx++)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps += 2;
                metrics.TotalNumbersOfArrayAccesses += 2;
                metrics.TotalNumbersOfComparisons += 2;

                // Sending the indices of the current element and the compared one
                SendIndices(CurIdx, itemIdx);
                
                // Choice between taking the element and not taking it
                max = Max(max, values[itemIdx] + Knapsack_01MemoizedHelper(CurValue, CurIdx + 1, weights, values, capacity - weights[itemIdx],ref memo, ref metrics));
                max = Max(max, Knapsack_01MemoizedHelper(CurValue, CurIdx + 1, weights, values, capacity ,ref memo, ref metrics));
            }

            metrics.TotalNumbersOfArrayAccesses++;
            memo[capacity] = max;
            return max;
        }
        public static Metrics Knapsack_01Memoized(List<Int128> weights, List<Int128> values, Int128 capacity)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;

            metrics.TotalNumbersOfSteps++;
            Dictionary<Int128, Int128> memo = [];

            Knapsack_01MemoizedHelper(0, 0, weights, values, capacity,ref memo, ref metrics);

            return metrics;
        }
        //public static Metrics Knapsack_01Tabulated(List<Int128> weights, List<Int128> values, List<Int128> capacity);
        //public static Metrics Knapsack_InfTabulated(List<Int128> weights, List<Int128> values, List<Int128> capacity);
        public static Int128 Knapsack_InfMemoizedHelper(Int128 CurValue, List<Int128> weights, List<Int128> values, Int128 capacity, ref Dictionary<Int128, Int128> memo, ref Metrics metrics)
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

                SendIndices(itemIdx);

                // Choice between taking the element and not taking it
                max = Max(max, values[itemIdx] + Knapsack_InfMemoizedHelper(CurValue, weights, values, capacity - weights[itemIdx], ref memo, ref metrics));
                max = Max(max, Knapsack_InfMemoizedHelper(CurValue, weights, values, capacity, ref memo, ref metrics));
            }

            metrics.TotalNumbersOfArrayAccesses++;
            memo[capacity] = max;
            ChoiceChange((capacity, max),(int) capacity, null);
            return max;
        }
        public static Metrics Knapsack_InfMemoized(List<Int128> weights, List<Int128> values, Int128 capacity)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;

            metrics.TotalNumbersOfSteps++;
            Dictionary<Int128, Int128> memo = [];

            Knapsack_InfMemoizedHelper(0, weights, values, capacity, ref memo, ref metrics);

            return metrics;
        }
    }
}
