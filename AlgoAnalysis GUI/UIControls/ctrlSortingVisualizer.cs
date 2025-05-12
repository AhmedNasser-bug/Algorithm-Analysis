
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
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;

    public partial class ctrlSortingVisualizer : UserControl
    {
        private List<Int128> numbers;

        public ctrlSortingVisualizer(List<Int128> startingNumbers)
        {
            InitializeComponent();
            numbers = new List<Int128>(startingNumbers);

            // Configure chart appearance
            chart1.BackColor = Color.FromArgb(52, 62, 70);
            chart1.ChartAreas[0].BackColor = Color.FromArgb(52, 62, 70);

            // Configure axes
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(70, 80, 90);
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(70, 80, 90);

            // Set title with modern styling
            chart1.Titles.Add(new Title("Sorting Visualization", Docking.Top,
                new Font("Arial", 12, FontStyle.Bold), Color.White));
            CreateChart(numbers);
           
        }

        /// <summary>
        /// Updates the chart with new values
        /// </summary>
        /// <param name="numbers"></param>
        public void ChangeValues(List<Int128> numbers)
        {
            this.numbers = numbers;
            chart1.Series[0].Points.Clear();

            // Add data points
            for (int idx = 0; idx < numbers.Count; idx++)
            {
                chart1.Series[0].Points.AddXY(idx, (Double)numbers[idx]);
            }
        }
        /// <summary>
        /// Creates a histogram chart with the given array of numbers
        /// </summary>
        /// <param name="newArray"></param>
        public void CreateChart(List<Int128> newArray)
        {
            this.numbers = newArray;

            // Create histogram series
            chart1.Series.Clear();
            var series = new Series();
            series.ChartType = SeriesChartType.Bar;
            series.Color = Color.Beige;
            series.BorderColor = Color.Black;
            series.BorderWidth = 1;

            // Set custom styling for tight spacing
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // Add data points
            for (int i = 0; i < newArray.Count; i++)
            {
                series.Points.AddXY(i, (Double)newArray[i]);
            }

            // No gaps between columns (maximum width)
            series.CustomProperties = "PointWidth=1";
            chart1.Series.Add(series);

            
        }

        /// <summary>
        /// Updates the histogram by swapping two bars corresponding to the swapped array elements
        /// </summary>
        public void UpdateHistogram(int index1, int index2)
        {
            if (index1 < 0 || index2 < 0 || index1 >= numbers.Count || index2 >= numbers.Count)
                throw new ArgumentOutOfRangeException("Index out of range");

            // Swap values in the tracking list
            Int128 temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;

            chart1.Series[0].Points[index1].Color = Color.LightGreen;
            chart1.Series[0].Points[index2].Color = Color.LightGreen;

            // Update the chart - direct O(1) operations
            chart1.Series[0].Points[index1].YValues[0] = (Double)numbers[index1];
            chart1.Series[0].Points[index2].YValues[0] = (Double)numbers[index2];
            var originalColor = chart1.Series[0].Color;


            Application.DoEvents();
            Task.Delay(100).Wait();

            chart1.Series[0].Points[index1].Color = originalColor;
            chart1.Series[0].Points[index2].Color = originalColor;

        }
    }
}
