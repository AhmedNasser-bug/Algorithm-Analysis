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
using MainGUIcsproj.Utils;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace MainGUIcsproj.Algorithm_Visualization.Sorting_Visual
{
    public partial class ctrlSortingMain : UserControl
    {


        List<Int128> values;
        public ctrlSortingMain()
        {
            InitializeComponent();

            // Subscribe to animation events
            Sorting.OnSwap += Sorting_OnSwap;

            // Initialize Graph
            values = Input.GenerateRandomRange(1, 100);
            sortingVisualizer.ChangeValues(values);

        }

        /// <summary>
        /// Starts the sorting algorithm in a new thread and disables the buttons
        /// </summary>
        /// <param name="algorithm"></param>
        private Metrics StartSorting(Func<List<Int128>, Metrics> algorithm, List<Int128> Input)
        {
            FormsUtils.DisableAllButtons(this, btnBack.Tag, sortingVisualizer.btnFullScreen.Tag);

            Metrics PerformanceMetrics = new Metrics();
            // Start the sorting algorithm in a new thread to avoid blocking the UI

            PerformanceMetrics = algorithm(Input);

            // After the sorting is done, enable the buttons again
            FormsUtils.EnableAllButtons(this, "Stop", "Back");

            lblTotalNumberOfComprs.Text = PerformanceMetrics.TotalNumbersOfComparisons.ToString();
            lblTotalSwaps.Text = PerformanceMetrics.TotalNumbersOfSwaps.ToString();
            lblTotalRuntime.Text = PerformanceMetrics.TotalRuntimeTicks.ToString();
            lblArrayAccesses.Text = PerformanceMetrics.TotalNumbersOfArrayAccesses.ToString();

            return PerformanceMetrics;
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

        private void btnShuffleArray_Click(object sender, EventArgs e)
        {
            SortingUtils.Shuffle(ref this.values);
            sortingVisualizer.ChangeValues(values);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ctrlAlgorithmVisualization algorithmVisualization = new ctrlAlgorithmVisualization();
            frmMainMenu.globalForm?.ChangeControl(algorithmVisualization);
        }

        private void btnNewValues_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nupRandomArrayRange.Text))
            {
                MessageBox.Show("Please enter a valid number of values.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Generate new random values and re draws the chart
            values = Input.GenerateRandomRange(1, int.Parse(nupRandomArrayRange.Text));
            sortingVisualizer.ChangeValues(values);
        }





        // =============================================================== BUTTON EVENTS

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            StartSorting(new Func<List<Int128>, Metrics>((values) => Sorting.BubbleSort(values)), values);
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            StartSorting(new Func<List<Int128>, Metrics>((values) => Sorting.QuickSort(values)), values);
        }

        private void btnDecsValues_Click(object sender, EventArgs e)
        {
            values = Input.GenerateReverseSortedArray(1, int.Parse(nupRandomArrayRange.Text));
            sortingVisualizer.ChangeValues(values);
        }

        private void ctrlSortingMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            frmMainMenu.globalForm.ChangeControl(new ctrlSortingComparisson());
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            StartSorting((values) => { return Sorting.MergeSort(values); }, values);
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            StartSorting((values) => Sorting.InsertionSort(values), values);
        }

        private void btnSelectionsort_Click(object sender, EventArgs e)
        {
            StartSorting((values) => Sorting.selectionsort(values), values);
        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            StartSorting((values) => Sorting.HeapSort(values), values);
        }
    }
}
