using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGUIcsproj.Algorithm_Visualization.DynamicProgrammin_Visual
{
    public partial class KnapSackInput : Form
    {
        public int InputSize = -1;
        public int Capacity = -1;
        public KnapSackInput()
        {
            InitializeComponent();

        }

        private void brnConfirm_Click(object sender, EventArgs e)
        {

            if (mtpCapacity.Text.Length == 0 || mtbInpsize.Text.Length == 0)
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            InputSize = int.Parse(mtbInpsize.Text);
  
            Capacity = int.Parse(mtpCapacity.Text);

            Close();
        }
    }
}
