using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    
    public class Greedy
    {
        public delegate void GreedyStateChangeHandler(object sender, GreedyStateDictionary e);
        public static event GreedyStateChangeHandler? OnGreedyStateChange;

        /// <summary>
        /// Call on each iteration of each algorithm with the exact state of all tracked variables
        /// </summary>
        public static void OnStateChange(int processedIdx, Dictionary<string, object>? ProblemSpecificArgs)
        {
            OnGreedyStateChange?.Invoke(null, new GreedyStateDictionary(processedIdx, ProblemSpecificArgs));
        }
        /*
         TODO:
            • Coin Change Problem (Minimum coins required) 
            • Activity Selection Problem (Scheduling) 
            • Huffman Coding (Data compression) 
            • Kruskal’s Algorithm (Minimum Spanning Tree)

        Input is problem specific
        Output: Metrics object

        Notes:
            -All methods must have a clone that does not fire the event 
            -Each function should call OnGreedyStateChange() with the processed index as an argument
         
         */
        //public static Metrics CoinChange(List<int> coins, int amount);
        //public static Metrics ActivitySelection(List<Activity> activities);
        //public static Metrics HuffmanCoding(List<Char> characters, List<int> frequencies);
        //public static Metrics Kruskal(List<Edge> edges, int numberOfVertices);

    }
}
