using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    public class DynamicProgrammingStateDictionary : EventArgs
    {
        public (object SubProblem, object Answer)  MemoPair { get; set; }
        public int ProcessedIdx { get; set; }
        public Dictionary<String, object>? ProblemSpecificArgs { get; set; }

        public DynamicProgrammingStateDictionary((object SubProblem, object Answer) memoPair, int processedIdx, Dictionary<String, object>? problemSpecificArgs)
        {
            MemoPair = memoPair;
            ProcessedIdx = processedIdx;
            ProblemSpecificArgs = problemSpecificArgs;
        }
    }
}
