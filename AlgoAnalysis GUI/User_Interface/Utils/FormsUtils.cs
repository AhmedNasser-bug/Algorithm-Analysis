using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGUIcsproj.Utils
{
    internal class FormsUtils
    {

        /// <summary>
        /// Disables all buttons in the control
        /// </summary>
        public static void DisableAllButtons(Control ctrl, params object[] ExceptionTags)
        {
            foreach (Control control in ctrl.Controls)
            {
                if (control is Button button && !ExceptionTags.Contains(button.Tag))
                {
                    control.Enabled = false;
                    control.Visible = false;


                }
                // if the control have children, look for buttons in them
                else if (control.HasChildren)
                {
                    DisableAllButtons(control, ExceptionTags);
                }
            }

        }
        /// <summary>
        /// Enables all buttons in the control
        /// </summary>
        public static void EnableAllButtons(Control ctrl, params string[] ExceptionTags)
        {
            foreach (Control control in ctrl.Controls)
            {
                if (control is Button button)
                {
                    control.Enabled = true;
                    control.Visible = true;
                }

                // if the control have children, look for buttons in them
                else if (control.HasChildren)
                {
                    EnableAllButtons(control, ExceptionTags);
                }
            }
        }
    }
}
