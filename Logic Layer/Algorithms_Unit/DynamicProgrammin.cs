using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    public class DynamicProgramming
    { 

        public delegate void ChoiceChangeEventHandler(object sender, DynamicProgrammingStateDictionary<object, object> e);
        public static event ChoiceChangeEventHandler OnChoiceChange;

        /// <summary>
        /// Call on each iteration of each algorithm with the exact state of all tracked variables
        /// </summary>
        public static void ChoiceChange(KeyValuePair<object, object> memoPair, int? ProcessedIdx, Dictionary<String, object> problemSpecificArgs)
        {
            // Call the event handler with the current state
            DynamicProgrammingStateDictionary<object, object> state = new DynamicProgrammingStateDictionary<object, object>(memoPair, ProcessedIdx ?? -1, problemSpecificArgs);
            OnChoiceChange?.Invoke(null, state);
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
    }
}
