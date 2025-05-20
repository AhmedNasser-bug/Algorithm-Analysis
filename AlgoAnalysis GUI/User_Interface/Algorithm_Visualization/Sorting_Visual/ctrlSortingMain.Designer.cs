namespace MainGUIcsproj.Algorithm_Visualization.Sorting_Visual
{
    partial class ctrlSortingMain
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
            btnShuffleArray = new Button();
            btnNewValues = new Button();
            button1 = new Button();
            flpSortingAlgorithms = new FlowLayoutPanel();
            btnMergeSort = new Button();
            btnQuickSort = new Button();
            btnBubbleSort = new Button();
            btnInsertionSort = new Button();
            btnHeapSort = new Button();
            button2 = new Button();
            lbl = new Label();
            lblTotalSwaps = new Label();
            lblTotalNumberOfComprs = new Label();
            label2 = new Label();
            lblArrayAccesses = new Label();
            label3 = new Label();
            lblTotalRuntime = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnAnalyzePerformance = new Button();
            btnBack = new Button();
            label1 = new Label();
            nupRandomArrayRange = new NumericUpDown();
            sortingVisualizer = new Controls.ctrlSortingVisualizer();
            flpSortingAlgorithms.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupRandomArrayRange).BeginInit();
            SuspendLayout();
            // 
            // btnShuffleArray
            // 
            btnShuffleArray.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnShuffleArray.BackColor = Color.FromArgb(223, 208, 184);
            btnShuffleArray.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShuffleArray.ForeColor = SystemColors.ControlText;
            btnShuffleArray.Location = new Point(3, 885);
            btnShuffleArray.Name = "btnShuffleArray";
            btnShuffleArray.Size = new Size(250, 70);
            btnShuffleArray.TabIndex = 17;
            btnShuffleArray.Text = "Shuffle the array";
            btnShuffleArray.UseVisualStyleBackColor = false;
            btnShuffleArray.Click += btnShuffleArray_Click;
            // 
            // btnNewValues
            // 
            btnNewValues.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewValues.BackColor = Color.FromArgb(223, 208, 184);
            btnNewValues.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewValues.ForeColor = SystemColors.ControlText;
            btnNewValues.Location = new Point(259, 885);
            btnNewValues.Name = "btnNewValues";
            btnNewValues.Size = new Size(250, 70);
            btnNewValues.TabIndex = 18;
            btnNewValues.Text = "New Values";
            btnNewValues.UseVisualStyleBackColor = false;
            btnNewValues.Click += btnNewValues_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(223, 208, 184);
            button1.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(515, 885);
            button1.Name = "button1";
            button1.Size = new Size(250, 70);
            button1.TabIndex = 19;
            button1.Text = "Decsending Values";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDecsValues_Click;
            // 
            // flpSortingAlgorithms
            // 
            flpSortingAlgorithms.Controls.Add(btnMergeSort);
            flpSortingAlgorithms.Controls.Add(btnQuickSort);
            flpSortingAlgorithms.Controls.Add(btnBubbleSort);
            flpSortingAlgorithms.Controls.Add(btnInsertionSort);
            flpSortingAlgorithms.Controls.Add(btnHeapSort);
            flpSortingAlgorithms.Controls.Add(button2);
            flpSortingAlgorithms.Dock = DockStyle.Right;
            flpSortingAlgorithms.Location = new Point(1333, 0);
            flpSortingAlgorithms.Name = "flpSortingAlgorithms";
            flpSortingAlgorithms.Size = new Size(322, 968);
            flpSortingAlgorithms.TabIndex = 20;
            // 
            // btnMergeSort
            // 
            btnMergeSort.Anchor = AnchorStyles.None;
            btnMergeSort.BackColor = Color.FromArgb(223, 208, 184);
            btnMergeSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMergeSort.Location = new Point(3, 3);
            btnMergeSort.Name = "btnMergeSort";
            btnMergeSort.Size = new Size(319, 87);
            btnMergeSort.TabIndex = 21;
            btnMergeSort.Tag = "1";
            btnMergeSort.Text = "Merge Sort";
            btnMergeSort.UseVisualStyleBackColor = false;
            // 
            // btnQuickSort
            // 
            btnQuickSort.Anchor = AnchorStyles.None;
            btnQuickSort.BackColor = Color.FromArgb(223, 208, 184);
            btnQuickSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuickSort.Location = new Point(3, 96);
            btnQuickSort.Name = "btnQuickSort";
            btnQuickSort.Size = new Size(319, 87);
            btnQuickSort.TabIndex = 22;
            btnQuickSort.Tag = "2";
            btnQuickSort.Text = "Quick Sort";
            btnQuickSort.UseVisualStyleBackColor = false;
            btnQuickSort.Click += btnQuickSort_Click;
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.Anchor = AnchorStyles.None;
            btnBubbleSort.BackColor = Color.FromArgb(223, 208, 184);
            btnBubbleSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBubbleSort.Location = new Point(3, 189);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(319, 87);
            btnBubbleSort.TabIndex = 23;
            btnBubbleSort.Tag = "3";
            btnBubbleSort.Text = "Bubble Sort";
            btnBubbleSort.UseVisualStyleBackColor = false;
            btnBubbleSort.Click += btnBubbleSort_Click;
            // 
            // btnInsertionSort
            // 
            btnInsertionSort.Anchor = AnchorStyles.None;
            btnInsertionSort.BackColor = Color.FromArgb(223, 208, 184);
            btnInsertionSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertionSort.Location = new Point(3, 282);
            btnInsertionSort.Name = "btnInsertionSort";
            btnInsertionSort.Size = new Size(319, 87);
            btnInsertionSort.TabIndex = 24;
            btnInsertionSort.Tag = "4";
            btnInsertionSort.Text = "Insertion Sort";
            btnInsertionSort.UseVisualStyleBackColor = false;
            // 
            // btnHeapSort
            // 
            btnHeapSort.Anchor = AnchorStyles.None;
            btnHeapSort.BackColor = Color.FromArgb(223, 208, 184);
            btnHeapSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHeapSort.Location = new Point(3, 375);
            btnHeapSort.Name = "btnHeapSort";
            btnHeapSort.Size = new Size(319, 87);
            btnHeapSort.TabIndex = 25;
            btnHeapSort.Tag = "5";
            btnHeapSort.Text = "Heap Sort";
            btnHeapSort.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(223, 208, 184);
            button2.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 468);
            button2.Name = "button2";
            button2.Size = new Size(319, 87);
            button2.TabIndex = 26;
            button2.Tag = "5";
            button2.Text = "Heap Sort";
            button2.UseVisualStyleBackColor = false;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(6, 19);
            lbl.Name = "lbl";
            lbl.Size = new Size(285, 29);
            lbl.TabIndex = 23;
            lbl.Text = "Total # of Swaps:";
            // 
            // lblTotalSwaps
            // 
            lblTotalSwaps.AutoSize = true;
            lblTotalSwaps.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lblTotalSwaps.ForeColor = Color.White;
            lblTotalSwaps.Location = new Point(297, 19);
            lblTotalSwaps.Name = "lblTotalSwaps";
            lblTotalSwaps.Size = new Size(61, 29);
            lblTotalSwaps.TabIndex = 24;
            lblTotalSwaps.Text = "###";
            // 
            // lblTotalNumberOfComprs
            // 
            lblTotalNumberOfComprs.AutoSize = true;
            lblTotalNumberOfComprs.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lblTotalNumberOfComprs.ForeColor = Color.White;
            lblTotalNumberOfComprs.Location = new Point(409, 48);
            lblTotalNumberOfComprs.Name = "lblTotalNumberOfComprs";
            lblTotalNumberOfComprs.Size = new Size(61, 29);
            lblTotalNumberOfComprs.TabIndex = 26;
            lblTotalNumberOfComprs.Text = "###";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(397, 29);
            label2.TabIndex = 25;
            label2.Text = "Total # of Comparissons:";
            // 
            // lblArrayAccesses
            // 
            lblArrayAccesses.AutoSize = true;
            lblArrayAccesses.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lblArrayAccesses.ForeColor = Color.White;
            lblArrayAccesses.Location = new Point(424, 78);
            lblArrayAccesses.Name = "lblArrayAccesses";
            lblArrayAccesses.Size = new Size(61, 29);
            lblArrayAccesses.TabIndex = 28;
            lblArrayAccesses.Text = "###";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(429, 29);
            label3.TabIndex = 27;
            label3.Text = "Total # of Array Accesses:";
            // 
            // lblTotalRuntime
            // 
            lblTotalRuntime.AutoSize = true;
            lblTotalRuntime.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lblTotalRuntime.ForeColor = Color.White;
            lblTotalRuntime.Location = new Point(249, 106);
            lblTotalRuntime.Name = "lblTotalRuntime";
            lblTotalRuntime.Size = new Size(61, 29);
            lblTotalRuntime.TabIndex = 30;
            lblTotalRuntime.Text = "###";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 106);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 29;
            label5.Text = "Total Runtime:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left;
            groupBox1.Controls.Add(btnAnalyzePerformance);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblTotalRuntime);
            groupBox1.Controls.Add(lbl);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblTotalSwaps);
            groupBox1.Controls.Add(lblArrayAccesses);
            groupBox1.Controls.Add(lblTotalNumberOfComprs);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 543);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 243);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metrics";
            // 
            // btnAnalyzePerformance
            // 
            btnAnalyzePerformance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAnalyzePerformance.BackColor = Color.FromArgb(223, 208, 184);
            btnAnalyzePerformance.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalyzePerformance.ForeColor = SystemColors.ControlText;
            btnAnalyzePerformance.Location = new Point(6, 145);
            btnAnalyzePerformance.Name = "btnAnalyzePerformance";
            btnAnalyzePerformance.Size = new Size(237, 92);
            btnAnalyzePerformance.TabIndex = 38;
            btnAnalyzePerformance.Tag = "Back";
            btnAnalyzePerformance.Text = "Analyze Performance";
            btnAnalyzePerformance.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = Color.FromArgb(223, 208, 184);
            btnBack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.Location = new Point(771, 913);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(197, 42);
            btnBack.TabIndex = 32;
            btnBack.Tag = "Back";
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(204, 853);
            label1.Name = "label1";
            label1.Size = new Size(109, 29);
            label1.TabIndex = 31;
            label1.Text = "Range:";
            // 
            // nupRandomArrayRange
            // 
            nupRandomArrayRange.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nupRandomArrayRange.Location = new Point(308, 859);
            nupRandomArrayRange.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nupRandomArrayRange.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupRandomArrayRange.Name = "nupRandomArrayRange";
            nupRandomArrayRange.Size = new Size(212, 23);
            nupRandomArrayRange.TabIndex = 1;
            nupRandomArrayRange.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // sortingVisualizer
            // 
            sortingVisualizer.BackColor = Color.FromArgb(34, 40, 49);
            sortingVisualizer.Location = new Point(3, 0);
            sortingVisualizer.Name = "sortingVisualizer";
            sortingVisualizer.Size = new Size(1327, 537);
            sortingVisualizer.TabIndex = 38;
            // 
            // ctrlSortingMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(sortingVisualizer);
            Controls.Add(nupRandomArrayRange);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(flpSortingAlgorithms);
            Controls.Add(button1);
            Controls.Add(btnNewValues);
            Controls.Add(btnShuffleArray);
            Name = "ctrlSortingMain";
            Size = new Size(1655, 968);
            flpSortingAlgorithms.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupRandomArrayRange).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnShuffleArray;
        private Button btnNewValues;
        private Button button1;
        private FlowLayoutPanel flpSortingAlgorithms;
        private Button btnMergeSort;
        private Button btnQuickSort;
        private Button btnBubbleSort;
        private Button btnInsertionSort;
        private Button btnHeapSort;
        private Label lbl;
        private Label lblTotalSwaps;
        private Label lblTotalNumberOfComprs;
        private Label label2;
        private Label lblArrayAccesses;
        private Label label3;
        private Label lblTotalRuntime;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnBack;
        private Label label1;
        private NumericUpDown nupRandomArrayRange;
        private Button button2;
        private Button btnAnalyzePerformance;
        private Controls.ctrlSortingVisualizer sortingVisualizer;
    }
}
