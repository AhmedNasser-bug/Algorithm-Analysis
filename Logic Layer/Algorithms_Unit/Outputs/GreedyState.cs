using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    public class GreedyStateDictionary: EventArgs
    {
        public int ProcessedIdx { get; set; }
        public Dictionary<string, object>? ProblemSpecificArgs { get; set; }

        public GreedyStateDictionary(int processedIdx, Dictionary<string, object>? problemSpecificArgs)
        {
            ProcessedIdx = processedIdx;
            ProblemSpecificArgs = problemSpecificArgs;
        }
    }
}
