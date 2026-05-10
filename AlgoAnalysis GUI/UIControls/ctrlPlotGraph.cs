using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp1.Controls
{
    public partial class ctrlPlotGraph : UserControl
    {
        public ctrlPlotGraph()
        {
            InitializeComponent();
            InitChart(ref chrtTime);
            InitChart(ref chart2);
            InitChart(ref chart3);
            InitChart(ref chart4);

           
        }

        void InitChart(ref Chart chart)
        {
            //Configure chart appearance
            chart.BackColor = Color.FromArgb(34, 40, 49);
            chart.ChartAreas[0].BackColor = Color.FromArgb(34, 40, 49);

            // Configure axes
            chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chart.ChartAreas[0].AxisX.LineColor = Color.White;
            chart.ChartAreas[0].AxisY.LineColor = Color.White;
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(70, 80, 90);
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(70, 80, 90);
        }


    }
}
