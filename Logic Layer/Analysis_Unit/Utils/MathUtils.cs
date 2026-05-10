using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Analysis_Unit.Utils 
{
    // Utility class for mathematical operations used in complexity analysis
    public static class MathUtils 
    {
        // Returns log_base(arg), or 0 if input is invalid
        public static double LogValue<TBase, Targ>(TBase @base, Targ arg) where TBase: INumber<TBase> where Targ: INumber<Targ>
        {
            return (Convert.ToInt64(arg) > 0 && Convert.ToInt64(@base) != 1) ? Math.Log(Convert.ToDouble(arg)) / Math.Log(Convert.ToDouble(@base)) : 0;
        }

        // Calculates ratio y2/y1, or 0 if y1 is zero
        public static double LogPlateau<TBase, Targ>(TBase y1, Targ y2) where TBase : INumber<TBase> where Targ : INumber<Targ>
        {
            return (Convert.ToInt64(y1) != 0) ? Convert.ToDouble(y2) / Convert.ToDouble(y1) : 0;
        }



    }
}
