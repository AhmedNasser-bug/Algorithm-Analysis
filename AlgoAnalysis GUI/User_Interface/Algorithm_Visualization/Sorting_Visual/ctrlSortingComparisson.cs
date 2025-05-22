using Algorithms_Unit;
using Algorithms_Unit.Utils;
using MainGUIcsproj.Utils;
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

            ctrlSortingVisualizer1.ChangeValues(CurrentArr.ToList());
            ctrlSortingVisualizer2.ChangeValues(CurrentArr.ToList());

            // Subscribe to swapping event
            Sorting.OnSwap += Sorting_OnSwap1;
            Sorting.OnSwap += Sorting_OnSwap2;
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu.globalForm.ChangeControl(new ctrlSortingMain());
        }

        private void cbChartTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrlSortingVisualizer1.ChangeChartType((System.Windows.Forms.DataVisualization.Charting.SeriesChartType)cbChartTypes.SelectedIndex);
            ctrlSortingVisualizer2.ChangeChartType((System.Windows.Forms.DataVisualization.Charting.SeriesChartType)cbChartTypes.SelectedIndex);
        }


        private void Sorting_OnSwap1(object sender, SortingStateDictionary sortingState)
        {
            if ((string)sender == firstSort)
            {
                ctrlSortingVisualizer1.UpdateHistogram(sortingState.SwappedIndices.Value, sortingState.SwappedIndices.Key);
            }
        }
        private void Sorting_OnSwap2(object sender, SortingStateDictionary sortingState)
        {
            if ((string)sender == secondSort)
            {
                ctrlSortingVisualizer2.UpdateHistogram(sortingState.SwappedIndices.Value, sortingState.SwappedIndices.Key);
            }
        }



        private void btnStartCompare_Click(object sender, EventArgs e)
        {
            Func<List<Int128>,object, Metrics>? func1 = null;
            Func<List<Int128>,object, Metrics>? func2 = null;
            Metrics res1 = new Metrics();
            Metrics res2 = new();
            
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

            List<Int128> inp1 = CurrentArr.ToList();
            List<Int128> inp2 = CurrentArr.ToList();

            Task.Run(() => {
                res1 = func1?.Invoke(inp1, firstSort);
            });
            Task.Run(() => {
                res2 = func2?.Invoke(inp2, secondSort);
                });


            


        }


        private void btnNewValues_Click(object sender, EventArgs e)
        {
            int range = (int)nupRandomArrayRange.Value;
            CurrentArr = Input.GenerateRandomRange(1, range);

            
            ctrlSortingVisualizer1.ChangeValues(CurrentArr.ToList());
            ctrlSortingVisualizer2.ChangeValues(CurrentArr.ToList());
        }

        private void btnDescending_Click(object sender, EventArgs e)
        {
            int range = (int)nupRandomArrayRange.Value;
            CurrentArr = Input.GenerateReverseSortedArray(1, range);

            ctrlSortingVisualizer1.ChangeValues(CurrentArr.ToList());
            ctrlSortingVisualizer2.ChangeValues(CurrentArr.ToList());
        }
    }
}
