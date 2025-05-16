using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis_Unit.Utils
{
    public class MathUtils
    {
        public static double LogPlatuea(double y1, double y2)
        {
            if (y1 == 0) return 0;
            return y2 / y1;
        }

        // Func is to calcualate F(m^x) from the Main Formula 
        internal double Func_m_to_x(double m, double x)
        {
            return Math.Pow(m, x);
        }

        // Func to calculate log_m(F(m^x))
        internal double Func_logm_f_of_m_to_x(double m, double x)
        {
            return Math.Log(m, Func_m_to_x(m, x));
        }

        internal double Func_dereivativeOf_logm_f_of_m_to_x(double m, double x1, double x2)
        {
            return Func_logm_f_of_m_to_x(m, x2) - Func_logm_f_of_m_to_x(m, x1);
        }
    }
}
