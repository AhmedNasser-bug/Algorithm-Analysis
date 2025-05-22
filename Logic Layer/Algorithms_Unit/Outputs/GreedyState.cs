using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    public class GreedyStateDictionary: EventArgs
    {
        public string StateRepr { get; set; }
        public Dictionary<string, object>? ProblemSpecificArgs { get; set; }

        public GreedyStateDictionary(string stateRepr, Dictionary<string, object>? problemSpecificArgs)
        {
            StateRepr = stateRepr;
            ProblemSpecificArgs = problemSpecificArgs;
        }
    }
}
