using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    // TODO: Implement the metrics class
    /// <summary>
    /// This class is the return value of all algorithms written in this project
    /// Main props
    /// - Total number of swaps
    /// - Total number of comparisons
    /// - Total number of iterations
    /// - Total number of steps;
    /// - Total runtime taken 
    /// </summary>
    public class Metrics
    {
        public Int128 TotalNumbersOfSwaps { get; set; }
        public Int128 TotalNumbersOfComparisons { get; set; }
        public Int128 TotalNumbersOfIterations { get; set; }
        public Int128 TotalNumbersOfSteps { get; set; }
        public Int128 TotalRuntimeTicks { get; set; }
        public Metrics()
        {
            TotalNumbersOfSwaps = 0;
            TotalNumbersOfComparisons = 0;
            TotalNumbersOfIterations = 0;
            TotalNumbersOfSteps = 0;
            TotalRuntimeTicks = 0;
        }
    }
}
