using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Algorithms
{
    class DynamicProgrammingEventArgs<KeyT, ValueT>() : EventArgs
    {
        public KeyValuePair<KeyT, ValueT> MemoPair { get; set; }
        public int ProcessedIdx { get; set; }
        public Dictionary<String, object>? ProblemSpecificArgs { get; set; }
    }
    public class DynamicProgramming
    {
    }
}
