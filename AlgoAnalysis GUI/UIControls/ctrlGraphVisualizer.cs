using Algorithms_Unit.Datastructures;
using Algorithms_Unit.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UIControls
{
    public partial class ctrlGraphVisualizer : UserControl
    {
        
        public int AnimationSpeed;

        public ctrlGraphVisualizer()
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

            AnimationSpeed = 1;
            SetupChart();
            ComboBoxInit();
            InitGenerate();
        }
        private void InitGenerate()
        {
            nupMax.Value = 50;
            nupMin.Value = 1;
            nupVerts.Value = 10;
            nupEdges.Value = 10;
            cbType.SelectedIndex = 0;
            ChangeGraph(Input.GenerateRandomGraph((int)nupVerts.Value, (int)nupEdges.Value, (ushort)nupMin.Value, (ushort)nupMax.Value));
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
        private void SetupChart()
        {
            graphSeries = chart1.Series[0];
            graphSeries.ChartType = SeriesChartType.Bubble;
            graphSeries.Color = Color.Beige;
            graphSeries.BorderColor = Color.Black;
            graphSeries.BorderWidth = 1;

            chart1.Legends.Clear(); // Remove legend for cleaner look
            graphSeries.CustomProperties = "PointWidth=1";
        }

        /// <summary>
        /// Changes the Graph represented on the chart
        /// </summary>
        /// <param name="graph">The graph to visualize</param>
        public void ChangeGraph(Graph graph)
        {
            if (graph == null)
                return;

            currentGraph = graph;
            graphSeries.Points.Clear();
            vertexPoints.Clear();



            // Set up chart axes
            chart1.ChartAreas[0].AxisX.Minimum = -0.5;
            chart1.ChartAreas[0].AxisX.Maximum = graph.MaxXY;
            chart1.ChartAreas[0].AxisY.Minimum = -0.5;
            chart1.ChartAreas[0].AxisY.Maximum = graph.MaxXY;



            // Add data points for the adjacency matrix
            for (int i = 0; i < graph.nodes.Count; i++)
            {
                Node curNode = graph.nodes[i];

                // Create data point for the edge
                DataPoint point = new DataPoint(graph.nodes[i].Value.x, graph.nodes[i].Value.y);
                point.MarkerSize = 10;
                point.LabelForeColor = Color.White;
                point.ToolTip = $"(x:{graph.nodes[i].Value.x}, y:{graph.nodes[i].Value.y}";



                // Add the point to the series
                graphSeries.Points.Add(point);

                vertexPoints[curNode.ToString()] = point;
            }


        }


        /// <summary>
        /// Highlights the given edge with Light Blue
        /// </summary>
        public void HighlightEdge(Node vertex1, Node vertex2)
        {
            if (!vertexPoints.ContainsKey(vertex1.Value.ToString()) || !vertexPoints.ContainsKey(vertex2.Value.ToString()))
            {
                return;
            }

            // Get the points
            DataPoint point1 = vertexPoints[vertex1.ToString()];
            DataPoint point2 = vertexPoints[vertex2.ToString()];

            HighlightInstant(Color.HotPink, point1, point2);
            Task.Delay(TimeSpan.FromMilliseconds(1000 / AnimationSpeed)).Wait();
            ResetLightInstant(point1, point2);


        }

        /// <summary>
        /// Highlights the given vertex with Green
        /// </summary>
        /// <param name="vertex">The vertex to highlight</param>
        public void HighlightVertex(Node vertex)
        {
            // Find and highlight the vertex
            if (vertexPoints.ContainsKey(vertex.Value.ToString()))
            {
                DataPoint vertexPoint = vertexPoints[vertex.Value.ToString()];

                HighlightInstant(Color.Green, vertexPoint);
                Task.Delay(TimeSpan.FromMilliseconds(1000 / AnimationSpeed)).Wait();
                ResetLightInstant(vertexPoint);

            }
        }





        private void HighlightInstant(Color color, params DataPoint[] points)
        {
            foreach (DataPoint point in points)
            {
                point.MarkerColor = color;
                point.MarkerSize *= 2;
                point.BorderColor = Color.White;
                point.BorderWidth = 2;
            }
        }
        private void ResetLightInstant(params DataPoint[] points)
        {
            foreach (DataPoint point in points)
            {
                point.MarkerColor = Color.Beige;
                point.MarkerSize /= 2;
                point.BorderColor = Color.Black;
                point.BorderWidth = 1;
            }
        }





        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Refers to settings menu
            groupBox1.Enabled = groupBox1.Enabled;
            groupBox1.Visible = !groupBox1.Visible;
        }

        private void btnGenerateInput_Click(object sender, EventArgs e)
        {
            // Validations
            if (cbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose a Graph Type \n1. Cyclic (Cycles or loops Allowed)\n2. Acyclic (Cycles not allowed)\n3. Axis (All nodes are neighbors)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            if (nupMax.Value < nupMin.Value)
            {
                // Swapping them
                decimal temp = nupMin.Value;
                nupMin.Value = nupMax.Value;
                nupMax.Value = temp;
            }

            Graph graph = Input.GenerateRandomGraph((int)nupVerts.Value, (int)nupEdges.Value, (ushort)nupMin.Value, (ushort)nupMax.Value, (GraphTypes)cbType.SelectedIndex);

            ChangeGraph(graph);
        }

        private void cbChartTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = (SeriesChartType)cbChartTypes.SelectedIndex;
        }

        private void nupAnimationSpeed_ValueChanged(object sender, EventArgs e)
        {
            AnimationSpeed = Convert.ToInt32(nupAnimationSpeed.Value);
        }
    }
}