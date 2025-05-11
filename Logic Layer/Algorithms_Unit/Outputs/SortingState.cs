using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    public class SortingStateDictionary : EventArgs
    {
        public KeyValuePair<int, int> SwappedIndices;
        public Dictionary<String, object>? ProblemSpecificArgs;

        public SortingStateDictionary(KeyValuePair<int, int> swappedIndices)
        {
            SwappedIndices = swappedIndices;
        }

    }
}
