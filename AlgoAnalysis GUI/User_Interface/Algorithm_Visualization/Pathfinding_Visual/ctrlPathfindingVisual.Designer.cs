namespace MainGUIcsproj.Algorithm_Visualization.Pathfinding_Visual
{
    partial class ctrlPathfindingVisual
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
            btnBack = new Button();
            lblTitle = new Label();
            btnFloydWarshall = new Button();
            btnQuickSort = new Button();
            btnMergeSort = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(223, 208, 184);
            btnBack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(865, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(231, 46);
            btnBack.TabIndex = 26;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(34, 40, 49);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("SimSun-ExtB", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Transparent;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1099, 84);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Select Algorithm";
            // 
            // btnFloydWarshall
            // 
            btnFloydWarshall.Anchor = AnchorStyles.None;
            btnFloydWarshall.BackColor = Color.FromArgb(223, 208, 184);
            btnFloydWarshall.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFloydWarshall.Location = new Point(735, 190);
            btnFloydWarshall.Name = "btnFloydWarshall";
            btnFloydWarshall.Size = new Size(252, 189);
            btnFloydWarshall.TabIndex = 22;
            btnFloydWarshall.Text = "Floyd-Warshall";
            btnFloydWarshall.UseVisualStyleBackColor = false;
            // 
            // btnQuickSort
            // 
            btnQuickSort.Anchor = AnchorStyles.None;
            btnQuickSort.BackColor = Color.FromArgb(223, 208, 184);
            btnQuickSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuickSort.Location = new Point(101, 190);
            btnQuickSort.Name = "btnQuickSort";
            btnQuickSort.Size = new Size(252, 189);
            btnQuickSort.TabIndex = 21;
            btnQuickSort.Text = "Dijkstra's Algorithm";
            btnQuickSort.UseVisualStyleBackColor = false;
            // 
            // btnMergeSort
            // 
            btnMergeSort.Anchor = AnchorStyles.None;
            btnMergeSort.BackColor = Color.FromArgb(223, 208, 184);
            btnMergeSort.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMergeSort.Location = new Point(418, 190);
            btnMergeSort.Name = "btnMergeSort";
            btnMergeSort.Size = new Size(252, 189);
            btnMergeSort.TabIndex = 20;
            btnMergeSort.Text = "Bellman Ford";
            btnMergeSort.UseVisualStyleBackColor = false;
            // 
            // ctrlPathfindingVisual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Controls.Add(btnFloydWarshall);
            Controls.Add(btnQuickSort);
            Controls.Add(btnMergeSort);
            Name = "ctrlPathfindingVisual";
            Size = new Size(1099, 502);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Label lblTitle;
        private Button btnFloydWarshall;
        private Button btnQuickSort;
        private Button btnMergeSort;
    }
}
