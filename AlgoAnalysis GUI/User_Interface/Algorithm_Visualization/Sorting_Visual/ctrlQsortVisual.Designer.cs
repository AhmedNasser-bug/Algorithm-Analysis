namespace MainGUIcsproj.Algorithm_Visualization.Sorting_Visual
{
    partial class ctrlQsortVisual
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
            btnQuickSort = new Button();
            btnShuffleArray = new Button();
            SuspendLayout();
            // 
            // btnQuickSort
            // 
            btnQuickSort.BackColor = Color.FromArgb(223, 208, 184);
            btnQuickSort.Dock = DockStyle.Right;
            btnQuickSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuickSort.Location = new Point(991, 0);
            btnQuickSort.Name = "btnQuickSort";
            btnQuickSort.Size = new Size(230, 533);
            btnQuickSort.TabIndex = 15;
            btnQuickSort.Text = "Quick Sort";
            btnQuickSort.UseVisualStyleBackColor = false;
            btnQuickSort.Click += btnQuickSort_Click;
            // 
            // btnShuffleArray
            // 
            btnShuffleArray.BackColor = Color.FromArgb(223, 208, 184);
            btnShuffleArray.Dock = DockStyle.Right;
            btnShuffleArray.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShuffleArray.ForeColor = SystemColors.ControlText;
            btnShuffleArray.Location = new Point(845, 0);
            btnShuffleArray.Name = "btnShuffleArray";
            btnShuffleArray.Size = new Size(146, 533);
            btnShuffleArray.TabIndex = 17;
            btnShuffleArray.Text = "Shuffle the array";
            btnShuffleArray.UseVisualStyleBackColor = false;
            btnShuffleArray.Click += btnShuffleArray_Click;
            // 
            // ctrlQsortVisual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(btnShuffleArray);
            Controls.Add(btnQuickSort);
            Name = "ctrlQsortVisual";
            Size = new Size(1221, 533);
            ResumeLayout(false);
        }

        #endregion

        private Button btnQuickSort;
        private Button btnShuffleArray;
    }
}
