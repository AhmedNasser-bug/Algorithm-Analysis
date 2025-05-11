namespace MainGUIcsproj.Algorithm_Visualization.Sorting_Visual
{
    partial class ctrlSortingVisual
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
            lblTitle = new Label();
            btnHeapSort = new Button();
            btnInsertionSort = new Button();
            btnBubbleSort = new Button();
            btnMergeSort = new Button();
            btnBack = new Button();
            btnQuickSort = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(52, 62, 70);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("SimSun-ExtB", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Transparent;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1083, 84);
            lblTitle.TabIndex = 18;
            lblTitle.Text = "Select Algorithm";
            // 
            // btnHeapSort
            // 
            btnHeapSort.Anchor = AnchorStyles.None;
            btnHeapSort.BackColor = Color.FromArgb(223, 208, 184);
            btnHeapSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHeapSort.Location = new Point(528, 296);
            btnHeapSort.Name = "btnHeapSort";
            btnHeapSort.Size = new Size(230, 82);
            btnHeapSort.TabIndex = 17;
            btnHeapSort.Text = "Heap Sort";
            btnHeapSort.UseVisualStyleBackColor = false;
            // 
            // btnInsertionSort
            // 
            btnInsertionSort.Anchor = AnchorStyles.None;
            btnInsertionSort.BackColor = Color.FromArgb(223, 208, 184);
            btnInsertionSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertionSort.Location = new Point(282, 296);
            btnInsertionSort.Name = "btnInsertionSort";
            btnInsertionSort.Size = new Size(230, 82);
            btnInsertionSort.TabIndex = 16;
            btnInsertionSort.Text = "Insertion Sort";
            btnInsertionSort.UseVisualStyleBackColor = false;
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.Anchor = AnchorStyles.None;
            btnBubbleSort.BackColor = Color.FromArgb(223, 208, 184);
            btnBubbleSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBubbleSort.Location = new Point(657, 176);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(230, 82);
            btnBubbleSort.TabIndex = 15;
            btnBubbleSort.Text = "Bubble Sort";
            btnBubbleSort.UseVisualStyleBackColor = false;
            // 
            // btnMergeSort
            // 
            btnMergeSort.Anchor = AnchorStyles.None;
            btnMergeSort.BackColor = Color.FromArgb(223, 208, 184);
            btnMergeSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMergeSort.Location = new Point(406, 176);
            btnMergeSort.Name = "btnMergeSort";
            btnMergeSort.Size = new Size(230, 82);
            btnMergeSort.TabIndex = 13;
            btnMergeSort.Text = "Merge Sort";
            btnMergeSort.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(223, 208, 184);
            btnBack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(849, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(231, 46);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnQuickSort
            // 
            btnQuickSort.Anchor = AnchorStyles.None;
            btnQuickSort.BackColor = Color.FromArgb(223, 208, 184);
            btnQuickSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuickSort.Location = new Point(156, 176);
            btnQuickSort.Name = "btnQuickSort";
            btnQuickSort.Size = new Size(230, 82);
            btnQuickSort.TabIndex = 14;
            btnQuickSort.Text = "Quick Sort";
            btnQuickSort.UseVisualStyleBackColor = false;
            btnQuickSort.Click += btnQuickSort_Click;
            // 
            // ctrlSortingVisual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 62, 70);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Controls.Add(btnHeapSort);
            Controls.Add(btnInsertionSort);
            Controls.Add(btnBubbleSort);
            Controls.Add(btnQuickSort);
            Controls.Add(btnMergeSort);
            Name = "ctrlSortingVisual";
            Size = new Size(1083, 475);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnHeapSort;
        private Button btnInsertionSort;
        private Button btnBubbleSort;
        private Button btnMergeSort;
        private Button btnBack;
        private Button btnQuickSort;
    }
}
