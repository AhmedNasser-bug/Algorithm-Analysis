using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    public class SearchingStateDictionary : EventArgs
    {
        public int ProcessedIdx { get; set; }
        public Dictionary<string, object>? ProblemSpecificArgs { get; set; }

        public SearchingStateDictionary(int processedIdx, Dictionary<string, object>? problemSpecificArgs)
        {
            ProblemSpecificArgs = problemSpecificArgs;
            ProcessedIdx = processedIdx;
        }
    }
}
