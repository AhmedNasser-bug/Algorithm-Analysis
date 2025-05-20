using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms_Unit;

namespace UIControls
{
    public partial class ctrlMetricsBox : UserControl
    {
        public ctrlMetricsBox()
        {
            InitializeComponent();
        }

        public void SetMetrics(Metrics metrics)
        {
            lblArrayAccesses.Text = metrics.TotalNumbersOfArrayAccesses.ToString();
            lblTotalNumberOfComprs.Text = metrics.TotalNumbersOfComparisons.ToString();
            lblTotalNumberOfSteps.Text = metrics.TotalNumbersOfSteps.ToString();
            lblTotalRuntime.Text = $"{TimeSpan.FromTicks((long)metrics.TotalRuntimeTicks).Milliseconds} ms";
            lblTotalSwaps.Text = metrics.TotalNumbersOfSwaps.ToString();
        }
        public void Clear()
        {
            lblArrayAccesses.Text = "###";
            lblTotalNumberOfComprs.Text = "###";
            lblTotalNumberOfSteps.Text = "###";
            lblTotalRuntime.Text = "###";
            lblTotalSwaps.Text = "###";
        }
    }
}
