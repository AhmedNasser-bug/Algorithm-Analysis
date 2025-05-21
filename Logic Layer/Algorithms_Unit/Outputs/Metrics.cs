namespace Algorithms_Unit
{
    public delegate void SendIndexEventHandler(object sender, int idx);
    public delegate void SendIndicesEventHandler(object sender, params List<int> indices);
    public delegate void SendNoteEventHandler(object sender, int idx);
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
        public Int128 TotalNumbersOfArrayAccesses { get; set; }
        public Int128 TotalRuntimeTicks { get; set; }
        public Metrics()
        {
            TotalNumbersOfArrayAccesses = 0;
            TotalRuntimeTicks = 0;
            TotalNumbersOfArrayAccesses = 0;
            TotalNumbersOfComparisons = 0;
            TotalNumbersOfIterations = 0;
            TotalNumbersOfSwaps = 0;
        }
    }
}
