using Algorithms_Unit;
using Algorithms_Unit.Utils;
using MainGUIcsproj.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIControls.ctrlVisualArray;
using WinFormsApp1;

namespace MainGUIcsproj.Algorithm_Visualization.DynamicProgrammin_Visual
{
    public partial class ctrlDynamicProgramming : UserControl
    {
        public ctrlDynamicProgramming()
        {
            InitializeComponent();

            DynamicProgramming.OnChoiceChange += DynamicProgramming_OnChoiceChange;
            DynamicProgramming.OnCacheHit += DynamicProgramming_OnCacheHit;
            DynamicProgramming.OnSendNote += DynamicProgramming_OnSendNote;
        }

        private void DynamicProgramming_OnSendNote(object sender, string note)
        {
            ctrlDpVisualization1.AddNote(note);
        }
        private void DynamicProgramming_OnCacheHit(object sender, string HitState)
        {
            ctrlDpVisualization1.AddMemoryStateNote(HitState);
        }
        private void DynamicProgramming_OnChoiceChange(object sender, DynamicProgrammingStateDictionary e)
        {
            ctrlDpVisualization1.AddRuntimeNote(e.MemoPair);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            ctrlAlgorithmVisualization algorithmVisualization = new ctrlAlgorithmVisualization();
            frmMainMenu.globalForm?.ChangeControl(algorithmVisualization);
        }

        private void btnMemoFib_Click(object sender, EventArgs e)
        {
            FormsUtils.DisableAllButtons(flowLayoutPanel1);
            FibonacciInput fibonacciInput = new FibonacciInput();
            fibonacciInput.ShowDialog();

            if (fibonacciInput.InputSize == -1)
            {
                MessageBox.Show("No input found...");
                return;
            }

            DynamicProgramming.FiboMemoized(fibonacciInput.InputSize);
            FormsUtils.EnableAllButtons(flowLayoutPanel1);

        }

        private void BtnKnapsackInf_Click(object sender, EventArgs e)
        {
            FormsUtils.DisableAllButtons(flowLayoutPanel1);
            KnapSackInput knapSackInput = new KnapSackInput();
            knapSackInput.ShowDialog();

            if (knapSackInput.InputSize == -1 || knapSackInput.Capacity == -1)
            {
                MessageBox.Show("No input found...");
                FormsUtils.EnableAllButtons(flowLayoutPanel1);
                return;
            }


            List<Int128> weights = Input.GenerateRandomArray(knapSackInput.InputSize, 1, 100);
            List<Int128> values = Input.GenerateRandomArray(knapSackInput.InputSize, 1, 100);

            // Generate GUI
            if (knapSackInput.InputSize <= 10)
            {

            }

            Metrics metrics = DynamicProgramming.Knapsack_01Memoized(weights, values, knapSackInput.Capacity);
            ctrlMetricsBox1.SetMetrics(metrics);
            FormsUtils.EnableAllButtons(flowLayoutPanel1);

        }

        private void btnKnapsack_Click(object sender, EventArgs e)
        {
            FormsUtils.DisableAllButtons(flowLayoutPanel1);
            KnapSackInput knapSackInput = new KnapSackInput();
            knapSackInput.ShowDialog();

            if (knapSackInput.InputSize == -1 || knapSackInput.Capacity == -1)
            {
                MessageBox.Show("No input found...");
                FormsUtils.EnableAllButtons(flowLayoutPanel1);
                return;
            }


            List<Int128> weights = Input.GenerateRandomArray(knapSackInput.InputSize, 1, 100);
            List<Int128> values = Input.GenerateRandomArray(knapSackInput.InputSize, 1, 100);

            // Generate GUI
            if (knapSackInput.InputSize <= 10)
            {

            }

            Metrics metrics = DynamicProgramming.Knapsack_01Memoized(weights, values, knapSackInput.Capacity);
            ctrlMetricsBox1.SetMetrics(metrics);
            FormsUtils.EnableAllButtons(flowLayoutPanel1);

        }

        private void btnFiboTab_Click(object sender, EventArgs e)
        {
            FormsUtils.DisableAllButtons(flowLayoutPanel1);
            FibonacciInput fibonacciInput = new FibonacciInput();
            fibonacciInput.ShowDialog();

            if (fibonacciInput.InputSize == -1)
            {
                MessageBox.Show("No input found...");
                FormsUtils.EnableAllButtons(flowLayoutPanel1);
                return;
            }

            Metrics metrics = DynamicProgramming.FiboTabulated(fibonacciInput.InputSize);
            ctrlMetricsBox1.SetMetrics(metrics);
            FormsUtils.EnableAllButtons(flowLayoutPanel1);
        }

        private void btnKnapsackInf_Click_1(object sender, EventArgs e)
        {
            FormsUtils.DisableAllButtons(flowLayoutPanel1);
            KnapSackInput knapSackInput = new KnapSackInput();
            knapSackInput.ShowDialog();

            if (knapSackInput.InputSize == -1 || knapSackInput.Capacity == -1)
            {
                MessageBox.Show("No input found..."); 
                FormsUtils.EnableAllButtons(flowLayoutPanel1);
                return;

            }


            List<Int128> weights = Input.GenerateRandomArray(knapSackInput.InputSize, 1, 100);
            List<Int128> values = Input.GenerateRandomArray(knapSackInput.InputSize, 1, 100);

            // Generate GUI
            if (knapSackInput.InputSize <= 10)
            {

            }

            Metrics metrics = DynamicProgramming.Knapsack_01Memoized(weights, values, knapSackInput.Capacity);
            ctrlMetricsBox1.SetMetrics(metrics);
            FormsUtils.EnableAllButtons(flowLayoutPanel1);
        }
    }
}
