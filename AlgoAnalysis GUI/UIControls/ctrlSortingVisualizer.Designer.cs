namespace MainGUIcsproj.Controls
{
    partial class ctrlSortingVisualizer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnFullScreen = new Button();
            nupAnimationSpeed = new NumericUpDown();
            cbChartTypes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupAnimationSpeed).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = Color.FromArgb(34, 40, 49);
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1261, 605);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // btnFullScreen
            // 
            btnFullScreen.Anchor = AnchorStyles.Right;
            btnFullScreen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFullScreen.BackColor = Color.FromArgb(223, 208, 184);
            btnFullScreen.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFullScreen.ForeColor = SystemColors.ControlText;
            btnFullScreen.Location = new Point(1061, 93);
            btnFullScreen.Name = "btnFullScreen";
            btnFullScreen.Size = new Size(197, 42);
            btnFullScreen.TabIndex = 34;
            btnFullScreen.Tag = "Stop";
            btnFullScreen.Text = "FullScreen";
            btnFullScreen.UseVisualStyleBackColor = false;
            btnFullScreen.Click += btnFullScreen_Click;
            // 
            // nupAnimationSpeed
            // 
            nupAnimationSpeed.Anchor = AnchorStyles.Right;
            nupAnimationSpeed.Location = new Point(1110, 64);
            nupAnimationSpeed.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nupAnimationSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupAnimationSpeed.Name = "nupAnimationSpeed";
            nupAnimationSpeed.Size = new Size(148, 23);
            nupAnimationSpeed.TabIndex = 0;
            nupAnimationSpeed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nupAnimationSpeed.ValueChanged += nupAnimationSpeed_ValueChanged;
            // 
            // cbChartTypes
            // 
            cbChartTypes.Anchor = AnchorStyles.Right;
            cbChartTypes.FormattingEnabled = true;
            cbChartTypes.Location = new Point(1064, 35);
            cbChartTypes.Name = "cbChartTypes";
            cbChartTypes.Size = new Size(197, 23);
            cbChartTypes.TabIndex = 37;
            cbChartTypes.Text = "Chart Type";
            cbChartTypes.SelectedIndexChanged += cbChartTypes_SelectedIndexChanged;
            // 
            // ctrlSortingVisualizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(nupAnimationSpeed);
            Controls.Add(btnFullScreen);
            Controls.Add(cbChartTypes);
            Controls.Add(chart1);
            Name = "ctrlSortingVisualizer";
            Size = new Size(1261, 605);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupAnimationSpeed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public Button btnFullScreen;
        private ComboBox cbChartTypes;
        private NumericUpDown nupAnimationSpeed;
    }
}
