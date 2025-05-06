
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Algorithms
{
    class PathfindingEventArgs<KeyT, ValueT>() : EventArgs
    {
        public char ProcessedNode{ get; set; }
        public Dictionary<String, object>? ProblemSpecificArgs { get; set; }
    }
    public class Pathfinding
    {
    }
}
