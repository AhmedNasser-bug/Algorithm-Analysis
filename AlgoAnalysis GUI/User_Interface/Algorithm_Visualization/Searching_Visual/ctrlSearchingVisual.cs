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
            if (searchingStateDictionary.ProblemSpecificArgs != null)
            {
                int low = Convert.ToInt16(searchingStateDictionary.ProblemSpecificArgs["Low"]);
                int high = Convert.ToInt16(searchingStateDictionary.ProblemSpecificArgs["High"]);
                ctrlVisualArray1.HighlightThreeIndex(searchingStateDictionary.ProcessedIdx, low, high, Color.Beige, Color.Red, Color.Green);
            }
            else
            {
                ctrlVisualArray1.HighlightCurrentIndex(searchingStateDictionary.ProcessedIdx, Color.Red);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            ctrlAlgorithmVisualization algorithmVisualization = new ctrlAlgorithmVisualization();
            frmMainMenu.globalForm?.ChangeControl(algorithmVisualization);
        }

        private void btnBinarySEarch_Click(object sender, EventArgs e)
        {
            Searching.BinarySearch(ctrlVisualArray1.CurrentArray, Convert.ToInt16(maskedTextBox1.Text));
        }
    }
}
