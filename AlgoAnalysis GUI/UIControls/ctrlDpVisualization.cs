using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIControls
{
    public partial class ctrlDpVisualization : UserControl
    {
        public ctrlDpVisualization()
        {
            InitializeComponent();
        }
        Control control1;
        public void setEvent1(Control control)
        {
            flowLayoutPanel1.Controls.Add(control);
            control1 = control;
        }
        Control control2;
        public void setEvent2()
        {

        }
        Control control3;
        public void setEvent3()
        {

        }
        Control control4;
        public void setEvent4()
        {

        }
        

       
    }
}
