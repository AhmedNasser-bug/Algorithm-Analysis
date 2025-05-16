using Algorithms_Unit;

namespace Analysis_Unit
{
    /// <summary>
    /// This class contains definitions for analyzing a function is performance
    /// It contains two main methods:
    /// - AnalyzeFunction: This method takes a function as input and analyzes its performance
    ///     Returns pairs of vectors representing different plots about the function.
    ///     Predicted time complexity, Space complexity.
    /// - CompareTwoFunctions: This method compares the performance of two functions.
    ///     Compares the avg runtime, array accesses, swaps for a fixed input, firing events on the process to track the state
    ///     Compares the runtime of both functions on same input for different input size
    /// </summary>
    public class Analysis
    {
        /*
         Main formula:
        f(m^x)
        log_m(f(m^x))
        d/dx log_m(f(m^x)) <- the power
        ceil(avg(d/dx log_m(f(m^x)))) <- Upper bound
        floor(avg(d/dx log_m(f(m^x)))) <- lower bound
         */



    }
}
