using System;
using System.Collections.Generic;
using MainGUIcsproj.Algorithm_Visualization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGUIcsproj
{
    public partial class ctrlMainMenu : UserControl
    {

        public ctrlMainMenu()
        {
            InitializeComponent();
        }

        private void btnVisualize_Click(object sender, EventArgs e)
        {
            ctrlAlgorithmVisualization ctrlAlgorithmVisualization = new ctrlAlgorithmVisualization();
            frmMainMenu.globalForm?.ChangeControl(ctrlAlgorithmVisualization);
        }
    }
}
