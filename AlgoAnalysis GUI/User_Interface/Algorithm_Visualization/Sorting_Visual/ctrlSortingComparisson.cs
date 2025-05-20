using Algorithms_Unit;
using Algorithms_Unit.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainGUIcsproj.Algorithm_Visualization.Sorting_Visual
{
    public enum PresentSortingAlgorithms {QuickSort, MergeSort, BubbleSort, InsertionSort, SelectionSort, HeapSort}


    public partial class ctrlSortingComparisson : UserControl
    {


        List<Int128> CurrentArr { get;set;}
        public ctrlSortingComparisson()
        {
            InitializeComponent();
            ctrlSortingVisualizer1.HideExtraControls();
            ctrlSortingVisualizer2.HideExtraControls();

            cbFirstAlg.SelectedIndex = 0;
            cbSecondAlg.SelectedIndex = 0;

            cbChartTypes.DataSource = Enum.GetNames(typeof(SeriesChartType));
            cbChartTypes.SelectedIndex = 0;

            // Update Visual Arrays
            CurrentArr = Input.GenerateRandomRange(1, 40);
            ctrlSortingVisualizer1.ChangeValues(CurrentArr);
            ctrlSortingVisualizer2.ChangeValues(CurrentArr);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu.globalForm.ChangeControl(new ctrlSortingMain());
        }

        private void cbChartTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrlSortingVisualizer1.ChangeChartType((System.Windows.Forms.DataVisualization.Charting.SeriesChartType)cbChartTypes.SelectedIndex);
        }

        private void btnStartCompare_Click(object sender, EventArgs e)
        {
            Func<List<Int128>, Metrics>? func1 = null;
            Func<List<Int128>, Metrics>? func2 = null;
            

            switch ((PresentSortingAlgorithms)cbFirstAlg.SelectedIndex)
            {
                case PresentSortingAlgorithms.QuickSort:
                    func1 = Sorting.QuickSort;
                    break;
                case PresentSortingAlgorithms.MergeSort:
                    throw new NotImplementedException();
                    break;
                case PresentSortingAlgorithms.BubbleSort:
                    func1 = Sorting.BubbleSort;
                    break;
                case PresentSortingAlgorithms.InsertionSort:
                    throw new NotImplementedException();
                    break;
                case PresentSortingAlgorithms.SelectionSort:
                    throw new NotImplementedException();
                    break;
                case PresentSortingAlgorithms.HeapSort:
                    throw new NotImplementedException();
                    break;
                default:
                    break;
            }
            Task.Run(() => func1?.Invoke(CurrentArr));

            switch ((PresentSortingAlgorithms)cbSecondAlg.SelectedIndex)
            {
                case PresentSortingAlgorithms.QuickSort:
                    func2 = Sorting.QuickSort;
                    break;
                case PresentSortingAlgorithms.MergeSort:
                    break;
                case PresentSortingAlgorithms.BubbleSort:
                    func2 = Sorting.BubbleSort;
                    break;
                case PresentSortingAlgorithms.InsertionSort:
                    break;
                case PresentSortingAlgorithms.SelectionSort:
                    break;
                case PresentSortingAlgorithms.HeapSort:
                    break;
                default:
                    break;
            }
            Task.Run(() => func2?.Invoke(CurrentArr));

        }

        private void btnNewValues_Click(object sender, EventArgs e)
        {
            int range = (int)nupRandomArrayRange.Value;
            List<Int128> nums = Input.GenerateRandomRange(1, range);

            ctrlSortingVisualizer1.ChangeValues(nums);
            ctrlSortingVisualizer2.ChangeValues(nums);
        }

        private void btnDescending_Click(object sender, EventArgs e)
        {
            int range = (int)nupRandomArrayRange.Value;
            List<Int128> nums = Input.GenerateReverseSortedArray(1, range);

            ctrlSortingVisualizer1.ChangeValues(nums);
            ctrlSortingVisualizer2.ChangeValues(nums);
        }
    }
}
