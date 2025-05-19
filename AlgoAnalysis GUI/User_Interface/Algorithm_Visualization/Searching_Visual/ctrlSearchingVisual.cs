using Algorithms_Unit;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace MainGUIcsproj.Algorithm_Visualization.Searching_Visual
{
    public partial class ctrlSearchingVisual : UserControl
    {
        public ctrlSearchingVisual()
        {
            InitializeComponent();
            Searching.OnSearchIndexChange += onSearchIndexChange;

        }

        private void onSearchIndexChange(object sender, SearchingStateDictionary searchingStateDictionary)
        {
            ctrlVisualArray1.HighlightCurrentIndex(searchingStateDictionary.ProcessedIdx, Color.Green);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            ctrlAlgorithmVisualization algorithmVisualization = new ctrlAlgorithmVisualization();
            frmMainMenu.globalForm?.ChangeControl(algorithmVisualization);
        }

        private void btnBinarySEarch_Click(object sender, EventArgs e)
        {
            if (Searching.BinarySearch(ctrlVisualArray1.CurrentArray, Convert.ToInt16(maskedTextBox1.Text)))
            {
                MessageBox.Show("Target Found!");
            }
            else
            {
                MessageBox.Show("Target Not Found:-(");
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            frmMainMenu.globalForm.ChangeControl(new ctrlCompareVisual());
        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            if (Searching.LinearSearch(ctrlVisualArray1.CurrentArray, Convert.ToInt16(maskedTextBox1.Text)))
            {
                MessageBox.Show("Target Found!");
            }
            else
            {
                MessageBox.Show("Target Not Found:-(");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
