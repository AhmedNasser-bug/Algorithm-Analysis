using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    public class PathfindingStateDictionary : EventArgs
    {
        public char ProcessedNode { get; set; }
        public Dictionary<String, object>? ProblemSpecificArgs { get; set; }
        public PathfindingStateDictionary(char processedNode, Dictionary<string, object>? problemSpecificArgs)
        {
            ProcessedNode = processedNode;
            ProblemSpecificArgs = problemSpecificArgs;
        }
    }
}
