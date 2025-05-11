using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    public class DynamicProgrammingStateDictionary<KeyT, ValueT> : EventArgs
    {
        public KeyValuePair<KeyT, ValueT> MemoPair { get; set; }
        public int ProcessedIdx { get; set; }
        public Dictionary<String, object>? ProblemSpecificArgs { get; set; }

        public DynamicProgrammingStateDictionary(KeyValuePair<KeyT, ValueT> memoPair, int processedIdx, Dictionary<String, object>? problemSpecificArgs)
        {
            MemoPair = memoPair;
            ProcessedIdx = processedIdx;
            ProblemSpecificArgs = problemSpecificArgs;
        }
    }
}
