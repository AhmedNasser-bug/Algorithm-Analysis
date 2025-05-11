using MainGUIcsproj.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms_Unit;

namespace MainGUIcsproj.Algorithm_Visualization.Sorting_Visual
{
    public partial class ctrlQsortVisual : UserControl
    {
        public ctrlQsortVisual()
        {
            InitializeComponent();

            Sorting.OnSwap += Sorting_OnSwap;
            ctrlSortingHistogram sortingHistogram = new ctrlSortingHistogram(new List<double> {1, 2, 3, 4, 5, 6, 7});
            Controls.Add(sortingHistogram);
        }

        private void Sorting_OnSwap(object sender, SortingStateDictionary sortingState)
        {
            // UpdateHistogram();
            MessageBox.Show("Data updated", sortingState.SwappedIndices.ToString());
        }

       
    }
}
