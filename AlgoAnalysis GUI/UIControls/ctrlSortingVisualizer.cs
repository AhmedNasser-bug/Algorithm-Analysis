
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
    using System.Security.AccessControl;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;

    public partial class ctrlSortingVisualizer : UserControl
    {
        public const Double BASE_ANIMATION_SPEED = 10000;
        public TimeSpan AnimationSpeed = new TimeSpan(10000);// milliseconds

        public ctrlSortingVisualizer()
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

            // Set title with modern styling
            chart1.Titles.Add(new Title("Sorting Visualization", Docking.Top,
                new Font("Arial", 12, FontStyle.Bold), Color.White));

            var series = new Series();

            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.Color = Color.Beige;
            series.BorderColor = Color.Black;
            series.BorderWidth = 1;

            // Set custom styling for tight spacing
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.Legends.Clear(); // Remove legend for cleaner look
            series.CustomProperties = "PointWidth=1";

            chart1.Series[0] = series;

            ComboBoxInit(); // Initialize the combo box with chart types

        }

        private void ComboBoxInit()
        {
            // Initialize the combo box with the chart types
            Type chartTypes = typeof(System.Windows.Forms.DataVisualization.Charting.SeriesChartType);
            cbChartTypes.Items.Clear(); // Clear existing items

            string[] enumNames = Enum.GetNames(chartTypes);

            // Add each enum name to the combo box
            foreach (var chartType in enumNames)
            {
                cbChartTypes.Items.Add(chartType);
            }


            cbChartTypes.DataSource = enumNames;
            cbChartTypes.SelectedIndex = 0; // Set default selection
        }

        /// <summary>
        /// Updates the chart with new values
        /// </summary>
        /// <param name="newArray"></param>
        public void ChangeValues(List<Int128> newArray)
        {
            chart1.Series[0].Points.Clear();

            // Add data points
            for (int idx = 0; idx < newArray.Count; idx++)
            {
                chart1.Series[0].Points.AddXY(idx, (Double)newArray[idx]);
            }
        }

        /// <summary>
        /// Updates the histogram by swapping two bars corresponding to the swapped array elements
        /// </summary>
        public void UpdateHistogram(int index1, int index2)
        {
            if (index1 < 0 || index2 < 0 || index1 >= chart1.Series[0].Points.Count || index2 >= chart1.Series[0].Points.Count)
                throw new ArgumentOutOfRangeException("Index out of range");


            chart1.Series[0].Points[index1].Color = Color.LightGreen;
            chart1.Series[0].Points[index2].Color = Color.LightGreen;

            // Update the chart - direct O(1) operations
            Double temp = chart1.Series[0].Points[index1].YValues[0];
            chart1.Series[0].Points[index1].YValues[0] = chart1.Series[0].Points[index2].YValues[0];
            chart1.Series[0].Points[index2].YValues[0] = temp;

            var originalColor = chart1.Series[0].Color;


            Application.DoEvents();
            Task.Delay(AnimationSpeed).Wait();

            chart1.Series[0].Points[index1].Color = originalColor;
            chart1.Series[0].Points[index2].Color = originalColor;

        }

        /// <summary>
        /// Changes the speed of the animation by dividing the base speed by the given factor
        /// </summary>
        /// <param name="Factor"></param>
        public void ChangeSpeed(int Factor)
        {
            AnimationSpeed = new TimeSpan((long)BASE_ANIMATION_SPEED / Factor);
        }

        bool isFullScreen = false;
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (isFullScreen)
            {
                // Reverse Fullscreen
                Dock = DockStyle.None;
                Anchor = AnchorStyles.Top;
                Anchor |= AnchorStyles.Left;
                isFullScreen = false;
                btnFullScreen.Text = "FullScreen";
                return;
            }

            // Go to full screen
            Dock = DockStyle.Fill;
            BringToFront();
            isFullScreen = true;
            btnFullScreen.Text = "Back";
        }

        private void nupAnimationSpeed_ValueChanged(object sender, EventArgs e)
        {
            ChangeSpeed((int)nupAnimationSpeed.Value);
        }

        private void cbChartTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = (SeriesChartType)cbChartTypes.SelectedIndex;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
