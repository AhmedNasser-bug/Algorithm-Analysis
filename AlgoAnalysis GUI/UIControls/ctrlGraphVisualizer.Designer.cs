using Algorithms_Unit.Datastructures;
using System.Windows.Forms.DataVisualization.Charting;

namespace UIControls
{
    partial class ctrlGraphVisualizer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            chart1 = new Chart();
            cbChartTypes = new ComboBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            nupAnimationSpeed = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            nupMax = new NumericUpDown();
            nupMin = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            cbType = new ComboBox();
            nupEdges = new NumericUpDown();
            nupVerts = new NumericUpDown();
            btnGenerateInput = new Button();
            btnSettings = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupAnimationSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupEdges).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupVerts).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1056, 622);
            chart1.TabIndex = 0;
            // 
            // cbChartTypes
            // 
            cbChartTypes.FormattingEnabled = true;
            cbChartTypes.Location = new Point(52, 435);
            cbChartTypes.Name = "cbChartTypes";
            cbChartTypes.Size = new Size(197, 37);
            cbChartTypes.TabIndex = 38;
            cbChartTypes.Text = "Chart Type";
            cbChartTypes.SelectedIndexChanged += cbChartTypes_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nupAnimationSpeed);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbChartTypes);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nupMax);
            groupBox1.Controls.Add(nupMin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbType);
            groupBox1.Controls.Add(nupEdges);
            groupBox1.Controls.Add(nupVerts);
            groupBox1.Controls.Add(btnGenerateInput);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(752, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 622);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generation Settings";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 284);
            label5.Name = "label5";
            label5.Size = new Size(205, 24);
            label5.TabIndex = 40;
            label5.Text = "Animation Speed";
            // 
            // nupAnimationSpeed
            // 
            nupAnimationSpeed.Location = new Point(6, 311);
            nupAnimationSpeed.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nupAnimationSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupAnimationSpeed.Name = "nupAnimationSpeed";
            nupAnimationSpeed.Size = new Size(120, 36);
            nupAnimationSpeed.TabIndex = 39;
            nupAnimationSpeed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nupAnimationSpeed.ValueChanged += nupAnimationSpeed_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(210, 183);
            label3.Name = "label3";
            label3.Size = new Size(75, 24);
            label3.TabIndex = 37;
            label3.Text = "MaxXY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 178);
            label4.Name = "label4";
            label4.Size = new Size(75, 24);
            label4.TabIndex = 36;
            label4.Text = "MinXY";
            // 
            // nupMax
            // 
            nupMax.Location = new Point(178, 210);
            nupMax.Maximum = new decimal(new int[] { 55, 0, 0, 0 });
            nupMax.Name = "nupMax";
            nupMax.Size = new Size(120, 36);
            nupMax.TabIndex = 35;
            // 
            // nupMin
            // 
            nupMin.Location = new Point(6, 210);
            nupMin.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nupMin.Name = "nupMin";
            nupMin.Size = new Size(120, 36);
            nupMin.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 79);
            label2.Name = "label2";
            label2.Size = new Size(88, 24);
            label2.TabIndex = 33;
            label2.Text = "#Edges";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 74);
            label1.Name = "label1";
            label1.Size = new Size(127, 24);
            label1.TabIndex = 32;
            label1.Text = "#Vertices";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Cyclic", "Acyclic", "Axis" });
            cbType.Location = new Point(177, 31);
            cbType.Name = "cbType";
            cbType.Size = new Size(121, 37);
            cbType.TabIndex = 31;
            cbType.Text = "Type";
            // 
            // nupEdges
            // 
            nupEdges.Location = new Point(178, 106);
            nupEdges.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            nupEdges.Name = "nupEdges";
            nupEdges.Size = new Size(120, 36);
            nupEdges.TabIndex = 30;
            // 
            // nupVerts
            // 
            nupVerts.Location = new Point(6, 106);
            nupVerts.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nupVerts.Name = "nupVerts";
            nupVerts.Size = new Size(120, 36);
            nupVerts.TabIndex = 29;
            // 
            // btnGenerateInput
            // 
            btnGenerateInput.BackColor = Color.FromArgb(223, 208, 184);
            btnGenerateInput.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateInput.ForeColor = SystemColors.WindowText;
            btnGenerateInput.Location = new Point(6, 363);
            btnGenerateInput.Name = "btnGenerateInput";
            btnGenerateInput.Size = new Size(292, 66);
            btnGenerateInput.TabIndex = 28;
            btnGenerateInput.Text = "Generate Graph";
            btnGenerateInput.UseVisualStyleBackColor = false;
            btnGenerateInput.Click += btnGenerateInput_Click;
            // 
            // btnSettings
            // 
            btnSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSettings.BackColor = Color.FromArgb(223, 208, 184);
            btnSettings.Dock = DockStyle.Right;
            btnSettings.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = SystemColors.WindowText;
            btnSettings.Location = new Point(728, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(24, 622);
            btnSettings.TabIndex = 39;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // ctrlGraphVisualizer
            // 
            Controls.Add(btnSettings);
            Controls.Add(groupBox1);
            Controls.Add(chart1);
            Name = "ctrlGraphVisualizer";
            Size = new Size(1056, 622);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupAnimationSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupEdges).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupVerts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Graph currentGraph;
        private Series graphSeries = new Series();
        private Dictionary<string, DataPoint> vertexPoints = new();
        private Chart chart1;
        private ComboBox cbChartTypes;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private NumericUpDown nupMax;
        private NumericUpDown nupMin;
        private Label label2;
        private Label label1;
        private ComboBox cbType;
        private NumericUpDown nupEdges;
        private NumericUpDown nupVerts;
        private Button btnGenerateInput;
        private Button btnSettings;
        private Label label5;
        private NumericUpDown nupAnimationSpeed;
    }
}
