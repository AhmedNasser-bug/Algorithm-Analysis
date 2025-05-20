using Algorithms_Unit;
using Algorithms_Unit.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
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
        public const string firstSort = "f1";
        public const string secondSort = "f2";
        List<(int i, int j)> swappedF1 = new List<(int i, int j)>();
        List<(int i, int j)> swappedF2 = new List<(int i, int j)>();


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
            List<Int128> copy = CurrentArr.ToList();
            ctrlSortingVisualizer1.ChangeValues(CurrentArr.ToList());
            ctrlSortingVisualizer2.ChangeValues(copy);

            // Subscribe to swapping event
            Sorting.OnSwap += Sorting_OnSwapFirst;
            Sorting.OnSwap += Sorting_OnSwapSecond;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu.globalForm.ChangeControl(new ctrlSortingMain());
        }

        private void cbChartTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrlSortingVisualizer1.ChangeChartType((System.Windows.Forms.DataVisualization.Charting.SeriesChartType)cbChartTypes.SelectedIndex);
        }


        private void Sorting_OnSwapFirst(object sender, SortingStateDictionary sortingState)
        {
            if ((string)sender == firstSort)
            {
                ctrlSortingVisualizer1.UpdateHistogram(sortingState.SwappedIndices.Value, sortingState.SwappedIndices.Key);
               //swappedF1.Add((sortingState.SwappedIndices.Key, sortingState.SwappedIndices.Value));
            }
        }
        private void Sorting_OnSwapSecond(object sender, SortingStateDictionary sortingState)
        {
            if ((string)sender == secondSort)
            {
                ctrlSortingVisualizer2.UpdateHistogram(sortingState.SwappedIndices.Value, sortingState.SwappedIndices.Key);
                //swappedF2.Add((sortingState.SwappedIndices.Key, sortingState.SwappedIndices.Value));
            }
        }


        private void btnStartCompare_Click(object sender, EventArgs e)
        {
            Func<List<Int128>,object, Metrics>? func1 = null;
            Func<List<Int128>,object, Metrics>? func2 = null;
            
            // Get the first choice
            switch ((PresentSortingAlgorithms)cbFirstAlg.SelectedIndex)
            {
                case PresentSortingAlgorithms.QuickSort:
                    func1 = Sorting.QuickSort;
                    break;
                case PresentSortingAlgorithms.MergeSort:
                    func1 = Sorting.MergeSort;
                    break;
                case PresentSortingAlgorithms.BubbleSort:
                    func1 = Sorting.BubbleSort;
                    break;
                case PresentSortingAlgorithms.InsertionSort:
                    func1 = Sorting.InsertionSort;
                    break;
                case PresentSortingAlgorithms.SelectionSort:
                    func1 = Sorting.selectionsort;
                    break;
                case PresentSortingAlgorithms.HeapSort:
                    func1 = Sorting.HeapSort;
                    break;
                default:
                    break;
            }
            Task.Run(() => func1?.Invoke(CurrentArr, firstSort));

            // Get the second choice
            switch ((PresentSortingAlgorithms)cbSecondAlg.SelectedIndex)
            {
                case PresentSortingAlgorithms.QuickSort:
                    func2 = Sorting.QuickSort;
                    break;
                case PresentSortingAlgorithms.MergeSort:
                    func2 = Sorting.MergeSort;
                    break;
                case PresentSortingAlgorithms.BubbleSort:
                    func2 = Sorting.BubbleSort;
                    break;
                case PresentSortingAlgorithms.InsertionSort:
                    func2 = Sorting.InsertionSort;
                    break;
                case PresentSortingAlgorithms.SelectionSort:
                    func2 = Sorting.selectionsort;
                    break;
                case PresentSortingAlgorithms.HeapSort:
                    func2 = Sorting.HeapSort;
                    break;
                default:
                    break;
            }
            Task.Run(() => func2?.Invoke(CurrentArr, secondSort));

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
