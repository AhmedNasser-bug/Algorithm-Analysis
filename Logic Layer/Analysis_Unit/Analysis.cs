using Algorithms_Unit;
using Analysis_Unit.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Analysis_Unit
{

    public delegate void SendDataPoints(Delegate @delegate);
    public class GraphsOverN
    {
        public List<Int128> TimeOverN { get; set; } = new();
        public List<Int128> StepsOverN { get; set; } = new();
        public List<Int128> SwapsOverN { get; set; } = new();
        public List<double> GrowthRateFunction { get; set; } = new();
        public List<int> inputs { get; set; } = new();

        public void UpdateGraphs(Metrics metrics, int N, double CurrentGrowth)
        {
            inputs.Add(N);
            TimeOverN.Add(metrics.TotalRuntimeTicks);
            StepsOverN.Add(metrics.TotalNumbersOfSteps);
            SwapsOverN.Add(metrics.TotalNumbersOfSwaps);
            GrowthRateFunction.Add(CurrentGrowth);
        }

    }
    public class ComplexityPredictions
    {
        
       
        public int TimeUpperBound;
        public int TimeTightBound;
        public int TimeLowerBound;
        public int SpaceTightBound;
        

        
        public ComplexityPredictions(int TimeUpperBound,
                                  int TimeTightBound,
                                  int TimeLowerBound,
                                  int SpaceTightBound)
        { 
            this.TimeUpperBound = TimeUpperBound;      
            this.TimeTightBound = TimeTightBound;
            this.TimeLowerBound = TimeLowerBound;
            this.SpaceTightBound = SpaceTightBound;
 
        }

    }


    // Holds all the results from the complexity analysis
    public class StressTestResult
    {
        public GraphsOverN GraphsOverN { get; set; }
        public ComplexityPredictions ComplexityPredictions { get; set; }

        public StressTestResult(GraphsOverN graphsOverN, ComplexityPredictions complexity)
        {
            GraphsOverN = graphsOverN;
            ComplexityPredictions = complexity;
        }
    }


    // Core logic for running the stress test and complexity analysis
    public static class StressTester
    {


        public static StressTestResult AnalyzeAlgorithm(Func<int, Metrics> algorithm, int maxInput, double multiplier)
        {
            int inp = (int)Math.Ceiling(multiplier);
            GraphsOverN resultingGraphs = new();

            // Setting the first input            
            Metrics PrevMetrics = algorithm(1);
            resultingGraphs.UpdateGraphs(PrevMetrics, 1, 0);
            double stepsDiffLog = 0;
            double prevStepsLogValue = 0;

            while (inp < maxInput)
            {
                Metrics curMetrics = algorithm(inp);

                
      
                // Analyze growth behavior
                double stepsPlateau = MathUtils.LogPlateau(curMetrics.TotalNumbersOfSteps, PrevMetrics.TotalNumbersOfSwaps);
                double stepsSlope = MathUtils.LogValue(inp, curMetrics.TotalNumbersOfSteps);

                double timePlateau = MathUtils.LogPlateau(curMetrics.TotalRuntimeTicks, PrevMetrics.TotalRuntimeTicks);
                double timeSlope = MathUtils.LogValue(inp, curMetrics.TotalRuntimeTicks);


                // Convert values to logarithmic scale
                double curTimeLog = MathUtils.LogValue(multiplier, curMetrics.TotalRuntimeTicks);
                double curStepsLog = MathUtils.LogValue(multiplier, curMetrics.TotalNumbersOfSteps);

                // Estimate the derivative of the log scale values
                double deltaStepsLog = curStepsLog - prevStepsLogValue;
                double deltaInp =  Math.Log(inp, multiplier) - ((Math.Log(inp, multiplier) - 1) / multiplier);


                stepsDiffLog = deltaStepsLog / deltaInp; // the derivative of the logarithmic scale conversion of the main function


                resultingGraphs.UpdateGraphs(curMetrics, inp, stepsDiffLog);

                PrevMetrics = curMetrics;
                prevStepsLogValue = curStepsLog;

                inp = (int)Math.Ceiling(inp * multiplier);
            }



            // Predict overall complexity power (e.g. 2 means roughly O(n^2))
            int Upperbound = (int)Math.Ceiling(stepsDiffLog);
            int Lowerbound = (int)Math.Floor(stepsDiffLog);
            int Tightbound = (int)Math.Round(stepsDiffLog);
            ComplexityPredictions cmpPredictions = new ComplexityPredictions(Upperbound, Tightbound, Lowerbound, 0);



            return new StressTestResult(resultingGraphs, cmpPredictions);
            
        }
    }

 
}