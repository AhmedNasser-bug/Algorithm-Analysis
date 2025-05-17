using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis_Unit.Test_Result
{
    public class GraphsReult
    {
        public List<(double Steps, double InputSize)> Steps_Over_N { get; set; }
        public List<(double Time, double InputSize)> Time_Over_N { get; set; }
    }
}
