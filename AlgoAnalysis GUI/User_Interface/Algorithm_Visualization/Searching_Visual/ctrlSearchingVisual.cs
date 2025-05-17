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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ctrlAlgorithmVisualization algorithmVisualization = new ctrlAlgorithmVisualization();
            frmMainMenu.globalForm?.ChangeControl(algorithmVisualization);
        }
        private bool CheckTarget(int index)
        {
            if (maskedTextBox1.Text == ctrlVisualArray1.GetValue(index))
                return true;
            return false;
        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < ctrlVisualArray1.CurrentSize; i++)
            {
                if (!CheckTarget(i))
                {
                    ctrlVisualArray1.HighlightCurrentIndex(i, Color.Red);
                }
                else
                {
                    ctrlVisualArray1.HighlightCurrentIndex(i, Color.Green);
                    MessageBox.Show("Target Found!");
                    return;
                }
            }
            MessageBox.Show("Target Not Found :-(");
            return;
        }

        private void btnBinarySEarch_Click(object sender, EventArgs e)
        {
            int low = 0;
            int high = ctrlVisualArray1.CurrentSize - 1;
            int mid = low + (high - low) / 2;
            ctrlVisualArray1.HighlightThreeIndex(low, high, mid, Color.Beige, Color.Red, Color.Green);
            while (high >= low)
            {
                if (Convert.ToInt16(ctrlVisualArray1.GetValue(mid)) > Convert.ToInt16(maskedTextBox1.Text))
                {
                    Task.Delay(400).Wait();
                    high = mid - 1;
                    mid = low + (high - low) / 2;
                    ctrlVisualArray1.HighlightThreeIndex(low, high, mid, Color.Beige, Color.Red, Color.Green);
                }
                else if (Convert.ToInt16(ctrlVisualArray1.GetValue(mid)) < Convert.ToInt16(maskedTextBox1.Text))
                {
                    Task.Delay(400).Wait();
                    low = mid + 1;
                    mid = low + (high - low) / 2;
                    ctrlVisualArray1.HighlightThreeIndex(low, high, mid, Color.Beige, Color.Red, Color.Green);
                }
                else if (Convert.ToInt16(ctrlVisualArray1.GetValue(mid)) == Convert.ToInt16(maskedTextBox1.Text))
                {
                    MessageBox.Show("Target Found!");
                    return;
                }
            }
            MessageBox.Show("Target Not Found :-(");
            return;
        }
    }
}
