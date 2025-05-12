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
using Algorithms_Unit.Utils;

namespace MainGUIcsproj.Algorithm_Visualization.Sorting_Visual
{
    public partial class ctrlQsortVisual : UserControl
    {

        ctrlSortingVisualizer sortingVisualizer;
        List<Int128> values;
        public ctrlQsortVisual()
        {
            InitializeComponent();

            Sorting.OnSwap += Sorting_OnSwap;
            values = Input.GenerateRandomRange(1, 20);
            sortingVisualizer = new ctrlSortingVisualizer(values);
            sortingVisualizer.Dock = DockStyle.Left;
            Controls.Add(sortingVisualizer);
        }

        /// <summary>
        /// Updates the animation of the chart with the swapped indices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="sortingState"></param>
        private void Sorting_OnSwap(object sender, SortingStateDictionary sortingState)
        {
            sortingVisualizer.UpdateHistogram(sortingState.SwappedIndices.Key, sortingState.SwappedIndices.Value);
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            Metrics metrics = Sorting.BubbleSort(ref values);
        }

        private void btnShuffleArray_Click(object sender, EventArgs e)
        {
            Sorting.Shuffle(ref values);
            sortingVisualizer.ChangeValues(values);
        }
    }
}
