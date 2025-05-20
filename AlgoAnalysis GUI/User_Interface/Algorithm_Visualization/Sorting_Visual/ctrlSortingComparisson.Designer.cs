namespace MainGUIcsproj.Algorithm_Visualization.Sorting_Visual
{
    partial class ctrlSortingComparisson
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
            splitContainer1 = new SplitContainer();
            ctrlSortingVisualizer1 = new Controls.ctrlSortingVisualizer();
            ctrlSortingVisualizer2 = new Controls.ctrlSortingVisualizer();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label1 = new Label();
            nupAnimationSpeed = new NumericUpDown();
            cbChartTypes = new ComboBox();
            btnStartCompare = new Button();
            cbSecondAlg = new ComboBox();
            cbFirstAlg = new ComboBox();
            ctrlMetricsBox2 = new UIControls.ctrlMetricsBox();
            ctrlMetricsBox1 = new UIControls.ctrlMetricsBox();
            btnCompare = new Button();
            btnAnalyzePerformance = new Button();
            label2 = new Label();
            lbl = new Label();
            lblTotalSwaps = new Label();
            nupRandomArrayRange = new NumericUpDown();
            label4 = new Label();
            btnNewValues = new Button();
            btnDescending = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupAnimationSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupRandomArrayRange).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ctrlSortingVisualizer1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(ctrlSortingVisualizer2);
            splitContainer1.Size = new Size(1818, 660);
            splitContainer1.SplitterDistance = 409;
            splitContainer1.TabIndex = 0;
            // 
            // ctrlSortingVisualizer1
            // 
            ctrlSortingVisualizer1.BackColor = Color.FromArgb(34, 40, 49);
            ctrlSortingVisualizer1.Dock = DockStyle.Fill;
            ctrlSortingVisualizer1.Location = new Point(0, 0);
            ctrlSortingVisualizer1.Name = "ctrlSortingVisualizer1";
            ctrlSortingVisualizer1.Size = new Size(409, 660);
            ctrlSortingVisualizer1.TabIndex = 0;
            // 
            // ctrlSortingVisualizer2
            // 
            ctrlSortingVisualizer2.BackColor = Color.FromArgb(34, 40, 49);
            ctrlSortingVisualizer2.Dock = DockStyle.Fill;
            ctrlSortingVisualizer2.Location = new Point(0, 0);
            ctrlSortingVisualizer2.Name = "ctrlSortingVisualizer2";
            ctrlSortingVisualizer2.Size = new Size(1405, 660);
            ctrlSortingVisualizer2.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = Color.FromArgb(223, 208, 184);
            btnBack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.Location = new Point(1618, 349);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(197, 42);
            btnBack.TabIndex = 33;
            btnBack.Tag = "Back";
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDescending);
            groupBox1.Controls.Add(nupRandomArrayRange);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnNewValues);
            groupBox1.Controls.Add(nupAnimationSpeed);
            groupBox1.Controls.Add(cbChartTypes);
            groupBox1.Controls.Add(btnStartCompare);
            groupBox1.Controls.Add(cbSecondAlg);
            groupBox1.Controls.Add(cbFirstAlg);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(ctrlMetricsBox2);
            groupBox1.Controls.Add(ctrlMetricsBox1);
            groupBox1.Controls.Add(btnCompare);
            groupBox1.Controls.Add(btnAnalyzePerformance);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lbl);
            groupBox1.Controls.Add(lblTotalSwaps);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 681);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1818, 397);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Compare Sorting Algorithms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 83);
            label3.Name = "label3";
            label3.Size = new Size(189, 29);
            label3.TabIndex = 48;
            label3.Text = "Chart Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 118);
            label1.Name = "label1";
            label1.Size = new Size(269, 29);
            label1.TabIndex = 47;
            label1.Text = "Animation Speed:";
            // 
            // nupAnimationSpeed
            // 
            nupAnimationSpeed.Anchor = AnchorStyles.Right;
            nupAnimationSpeed.Location = new Point(281, 124);
            nupAnimationSpeed.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nupAnimationSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupAnimationSpeed.Name = "nupAnimationSpeed";
            nupAnimationSpeed.Size = new Size(148, 23);
            nupAnimationSpeed.TabIndex = 45;
            nupAnimationSpeed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbChartTypes
            // 
            cbChartTypes.Anchor = AnchorStyles.Right;
            cbChartTypes.FormattingEnabled = true;
            cbChartTypes.Location = new Point(191, 88);
            cbChartTypes.Name = "cbChartTypes";
            cbChartTypes.Size = new Size(197, 24);
            cbChartTypes.TabIndex = 46;
            cbChartTypes.Text = "Chart Type";
            cbChartTypes.SelectedIndexChanged += cbChartTypes_SelectedIndexChanged;
            // 
            // btnStartCompare
            // 
            btnStartCompare.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnStartCompare.BackColor = Color.FromArgb(223, 208, 184);
            btnStartCompare.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartCompare.ForeColor = SystemColors.ControlText;
            btnStartCompare.Location = new Point(1129, 282);
            btnStartCompare.Name = "btnStartCompare";
            btnStartCompare.Size = new Size(270, 109);
            btnStartCompare.TabIndex = 44;
            btnStartCompare.Tag = "Back";
            btnStartCompare.Text = "Compare!";
            btnStartCompare.UseVisualStyleBackColor = false;
            btnStartCompare.Click += btnStartCompare_Click;
            // 
            // cbSecondAlg
            // 
            cbSecondAlg.FormattingEnabled = true;
            cbSecondAlg.Items.AddRange(new object[] { "QuickSort", "MergeSort", "BubbleSort", "InsertionSort", "SelectionSort", "HeapSort" });
            cbSecondAlg.Location = new Point(467, 53);
            cbSecondAlg.Name = "cbSecondAlg";
            cbSecondAlg.Size = new Size(121, 24);
            cbSecondAlg.TabIndex = 43;
            // 
            // cbFirstAlg
            // 
            cbFirstAlg.FormattingEnabled = true;
            cbFirstAlg.Items.AddRange(new object[] { "QuickSort", "MergeSort", "BubbleSort", "InsertionSort", "SelectionSort", "HeapSort" });
            cbFirstAlg.Location = new Point(431, 24);
            cbFirstAlg.Name = "cbFirstAlg";
            cbFirstAlg.Size = new Size(121, 24);
            cbFirstAlg.TabIndex = 42;
            // 
            // ctrlMetricsBox2
            // 
            ctrlMetricsBox2.Location = new Point(567, 188);
            ctrlMetricsBox2.Margin = new Padding(5, 3, 5, 3);
            ctrlMetricsBox2.Name = "ctrlMetricsBox2";
            ctrlMetricsBox2.Size = new Size(554, 203);
            ctrlMetricsBox2.TabIndex = 41;
            // 
            // ctrlMetricsBox1
            // 
            ctrlMetricsBox1.Location = new Point(3, 188);
            ctrlMetricsBox1.Margin = new Padding(5, 3, 5, 3);
            ctrlMetricsBox1.Name = "ctrlMetricsBox1";
            ctrlMetricsBox1.Size = new Size(554, 203);
            ctrlMetricsBox1.TabIndex = 40;
            // 
            // btnCompare
            // 
            btnCompare.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCompare.BackColor = Color.FromArgb(223, 208, 184);
            btnCompare.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompare.ForeColor = SystemColors.ControlText;
            btnCompare.Location = new Point(256, 442);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(237, 92);
            btnCompare.TabIndex = 39;
            btnCompare.Tag = "Back";
            btnCompare.Text = "Compare Algorithm";
            btnCompare.UseVisualStyleBackColor = false;
            // 
            // btnAnalyzePerformance
            // 
            btnAnalyzePerformance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAnalyzePerformance.BackColor = Color.FromArgb(223, 208, 184);
            btnAnalyzePerformance.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalyzePerformance.ForeColor = SystemColors.ControlText;
            btnAnalyzePerformance.Location = new Point(6, 442);
            btnAnalyzePerformance.Name = "btnAnalyzePerformance";
            btnAnalyzePerformance.Size = new Size(237, 92);
            btnAnalyzePerformance.TabIndex = 38;
            btnAnalyzePerformance.Tag = "Back";
            btnAnalyzePerformance.Text = "Analyze Performance";
            btnAnalyzePerformance.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(477, 29);
            label2.TabIndex = 25;
            label2.Text = "Second Algorithm (On Right): ";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(6, 19);
            lbl.Name = "lbl";
            lbl.Size = new Size(445, 29);
            lbl.TabIndex = 23;
            lbl.Text = "First Algorithm (On Left): ";
            // 
            // lblTotalSwaps
            // 
            lblTotalSwaps.AutoSize = true;
            lblTotalSwaps.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lblTotalSwaps.ForeColor = Color.White;
            lblTotalSwaps.Location = new Point(297, 19);
            lblTotalSwaps.Name = "lblTotalSwaps";
            lblTotalSwaps.Size = new Size(0, 29);
            lblTotalSwaps.TabIndex = 24;
            // 
            // nupRandomArrayRange
            // 
            nupRandomArrayRange.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nupRandomArrayRange.Location = new Point(121, 165);
            nupRandomArrayRange.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nupRandomArrayRange.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupRandomArrayRange.Name = "nupRandomArrayRange";
            nupRandomArrayRange.Size = new Size(122, 23);
            nupRandomArrayRange.TabIndex = 32;
            nupRandomArrayRange.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 156);
            label4.Name = "label4";
            label4.Size = new Size(109, 29);
            label4.TabIndex = 36;
            label4.Text = "Range:";
            // 
            // btnNewValues
            // 
            btnNewValues.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewValues.BackColor = Color.FromArgb(223, 208, 184);
            btnNewValues.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Bold);
            btnNewValues.ForeColor = SystemColors.ControlText;
            btnNewValues.Location = new Point(256, 156);
            btnNewValues.Name = "btnNewValues";
            btnNewValues.Size = new Size(132, 35);
            btnNewValues.TabIndex = 34;
            btnNewValues.Text = "New Values";
            btnNewValues.UseVisualStyleBackColor = false;
            btnNewValues.Click += btnNewValues_Click;
            // 
            // btnDescending
            // 
            btnDescending.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDescending.BackColor = Color.FromArgb(223, 208, 184);
            btnDescending.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Bold);
            btnDescending.ForeColor = SystemColors.ControlText;
            btnDescending.Location = new Point(394, 156);
            btnDescending.Name = "btnDescending";
            btnDescending.Size = new Size(132, 35);
            btnDescending.TabIndex = 49;
            btnDescending.Text = "Descending";
            btnDescending.UseVisualStyleBackColor = false;
            btnDescending.Click += btnDescending_Click;
            // 
            // ctrlSortingComparisson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(splitContainer1);
            Controls.Add(groupBox1);
            Name = "ctrlSortingComparisson";
            Size = new Size(1818, 1078);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupAnimationSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupRandomArrayRange).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Controls.ctrlSortingVisualizer ctrlSortingVisualizer1;
        private Controls.ctrlSortingVisualizer ctrlSortingVisualizer2;
        private Button btnBack;
        private GroupBox groupBox1;
        private Button btnCompare;
        private Button btnAnalyzePerformance;
        private Label label2;
        private Label lbl;
        private Label lblTotalSwaps;
        private UIControls.ctrlMetricsBox ctrlMetricsBox2;
        private UIControls.ctrlMetricsBox ctrlMetricsBox1;
        private ComboBox cbFirstAlg;
        private ComboBox cbSecondAlg;
        private Button btnStartCompare;
        private Label label3;
        private Label label1;
        private NumericUpDown nupAnimationSpeed;
        private ComboBox cbChartTypes;
        private Button btnDescending;
        private NumericUpDown nupRandomArrayRange;
        private Label label4;
        private Button btnNewValues;
    }
}
