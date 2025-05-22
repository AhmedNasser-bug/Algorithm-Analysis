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
        public ctrlCompareVisual()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ctrlSearchingVisual searchingVisual = new ctrlSearchingVisual();
            frmMainMenu.globalForm?.ChangeControl(searchingVisual);
        }

        private void ctrlVisualArray1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPureArray1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPureArray2_Load(object sender, EventArgs e)
        {

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

            Metrics lnrMetrics = Searching.LinearSearch(ctrlPureArray1.CurrentArray, TargetedIndex);
            Metrics bnrMetrics = Searching.BinarySearch(ctrlPureArray1.CurrentArray, TargetedIndex);


        }
    }
}
