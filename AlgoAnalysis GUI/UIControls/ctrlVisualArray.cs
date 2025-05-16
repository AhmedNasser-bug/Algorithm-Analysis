using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGUIcsproj.Controls
{
    public partial class ctrlVisualArray : UserControl
    {
        public ctrlVisualArray()
        {
            InitializeComponent();


            // Configure chart appearance
            chart1.BackColor = Color.FromArgb(34, 40, 49);
            chart1.ChartAreas[0].BackColor = Color.FromArgb(34, 40, 49);

            // Configure axes
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(70, 80, 90);
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(70, 80, 90);

            chart1.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Initializes the chart with the given values
        /// </summary>
        /// <param name="values"></param>
        public void InitializeValues(List<int> values)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Histogram");
            chart1.Series["Histogram"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Histogram"].Color = Color.FromArgb(0, 123, 255);
            chart1.Series["Histogram"].IsValueShownAsLabel = true;
            chart1.Series["Histogram"].CustomProperties = "PointWidth=1"; 
            // Set custom styling for tight spacing
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            // Add data points to the histogram
            for (int i = 0; i < values.Count; i++)
            {
                chart1.Series["Histogram"].Points.AddXY(i, values[i]);
            }
        }

        /// <summary>
        /// Updates the chart with new values
        /// </summary>
        /// <param name="values"></param>
        public void UpdateValues(List<int> values)
        {
            chart1.Series["Histogram"].Points.Clear();
            // Add data points to the histogram
            for (int i = 0; i < values.Count; i++)
            {
                chart1.Series["Histogram"].Points.AddXY(i, values[i]);
            }
        }

        public void SearchIndex(int i)
        {
            // Color the correspontding histogram bar
            chart1.Series["Histogram"].Points[i].Color = Color.LightGreen;
        }
    }
}
