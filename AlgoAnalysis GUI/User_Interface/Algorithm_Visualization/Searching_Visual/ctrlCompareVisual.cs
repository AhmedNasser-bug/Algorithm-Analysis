using Algorithms_Unit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGUIcsproj.Algorithm_Visualization.Searching_Visual
{
    public partial class ctrlCompareVisual : UserControl
    {
        public List<Int128> linearIndices = new List<Int128>();
        public List<Int128> binaryIndices = new List<Int128>();
        public ctrlCompareVisual()
        {
            InitializeComponent();
            ctrlPureArray1 = new UIControls.ctrlVisualArray.ctrlPureArray();
            ctrlPureArray2 = new UIControls.ctrlVisualArray.ctrlPureArray();
            Searching.OnSearchIndexChange += Searching_OnSearchIndexChange;


        }

        private void Searching_OnSearchIndexChange(object sender, SearchingStateDictionary processedIndices)
        {
            if(sender == "l")
            {
                ctrlPureArray1.Highlightidx(processedIndices.ProcessedIdx);
            }
            else
            {
                ctrlPureArray2.Highlightidx(processedIndices.ProcessedIdx);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ctrlSearchingVisual searchingVisual = new ctrlSearchingVisual();
            frmMainMenu.globalForm?.ChangeControl(searchingVisual);
        }


        private Random random = new Random();
        private short GenerateRandomNumber()
        {
            return (short)random.Next(0, 20);
        }
        private void btnInCompare_Click(object sender, EventArgs e)
        {
            short TargetedIndex = GenerateRandomNumber();
            lblTargetIndex.Text = TargetedIndex.ToString();

            lblTargetFirst.Text = ctrlPureArray1.GetValue(TargetedIndex);
            lblTargetSecond.Text = ctrlPureArray2.GetValue(TargetedIndex);
            Metrics lnrMetrics;
            Metrics bnrMetrics;

            Task.Run(() => { lnrMetrics = Searching.LinearSearch(ctrlPureArray1.CurrentArray, TargetedIndex, "l"); });
            Task.Run(() => { bnrMetrics = Searching.BinarySearch(ctrlPureArray2.CurrentArray, TargetedIndex, "bn"); });


        }
    }
}
