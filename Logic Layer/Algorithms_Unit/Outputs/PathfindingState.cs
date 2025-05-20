using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms_Unit.Datastructures;

namespace Algorithms_Unit
{
    public class PathfindingStateDictionary : EventArgs
    {
        public Node ProcessedNode { get; set; }
        public Dictionary<String, object>? ProblemSpecificArgs { get; set; }
        public PathfindingStateDictionary(Node processedNode, Dictionary<string, object>? problemSpecificArgs)
        {
            ProcessedNode = processedNode;
            ProblemSpecificArgs = problemSpecificArgs;
        }
    }
}
