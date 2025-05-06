using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Algorithms
{
    class GreedyEventArgs<KeyT, ValueT>() : EventArgs
    {
        public int ProcessedIdx { get; set; }
        public Dictionary<String, object>? ProblemSpecificArgs { get; set; }
    }
    public class Greedy
    {
    }
}
