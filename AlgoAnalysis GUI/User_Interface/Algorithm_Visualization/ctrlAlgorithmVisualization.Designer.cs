namespace MainGUIcsproj.Algorithm_Visualization
{
    partial class ctrlAlgorithmVisualization
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
            btnPathfinding = new Button();
            btnDynamicProgramming = new Button();
            btnGreedy = new Button();
            btnSorting = new Button();
            btnSearching = new Button();
            btnBack = new Button();
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
            lblTitle.Size = new Size(1337, 84);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Select Category";
            // 
            // btnPathfinding
            // 
            btnPathfinding.Anchor = AnchorStyles.None;
            btnPathfinding.BackColor = Color.FromArgb(223, 208, 184);
            btnPathfinding.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPathfinding.Location = new Point(121, 120);
            btnPathfinding.Name = "btnPathfinding";
            btnPathfinding.Size = new Size(241, 193);
            btnPathfinding.TabIndex = 12;
            btnPathfinding.Text = "Pathfinding";
            btnPathfinding.UseVisualStyleBackColor = false;
            btnPathfinding.Click += btnPathfinding_Click;
            // 
            // btnDynamicProgramming
            // 
            btnDynamicProgramming.Anchor = AnchorStyles.None;
            btnDynamicProgramming.BackColor = Color.FromArgb(223, 208, 184);
            btnDynamicProgramming.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDynamicProgramming.Location = new Point(544, 120);
            btnDynamicProgramming.Name = "btnDynamicProgramming";
            btnDynamicProgramming.Size = new Size(241, 193);
            btnDynamicProgramming.TabIndex = 11;
            btnDynamicProgramming.Text = "Dynamic programming";
            btnDynamicProgramming.UseVisualStyleBackColor = false;
            btnDynamicProgramming.Click += btnDynamicProgramming_Click;
            // 
            // btnGreedy
            // 
            btnGreedy.Anchor = AnchorStyles.None;
            btnGreedy.BackColor = Color.FromArgb(223, 208, 184);
            btnGreedy.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGreedy.Location = new Point(975, 120);
            btnGreedy.Name = "btnGreedy";
            btnGreedy.Size = new Size(241, 193);
            btnGreedy.TabIndex = 10;
            btnGreedy.Text = "Greedy";
            btnGreedy.UseVisualStyleBackColor = false;
            btnGreedy.Click += btnGreedy_Click;
            // 
            // btnSorting
            // 
            btnSorting.Anchor = AnchorStyles.None;
            btnSorting.BackColor = Color.FromArgb(223, 208, 184);
            btnSorting.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSorting.Location = new Point(326, 379);
            btnSorting.Name = "btnSorting";
            btnSorting.Size = new Size(241, 193);
            btnSorting.TabIndex = 9;
            btnSorting.Text = "Sorting";
            btnSorting.UseVisualStyleBackColor = false;
            btnSorting.Click += btnSorting_Click;
            // 
            // btnSearching
            // 
            btnSearching.Anchor = AnchorStyles.None;
            btnSearching.BackColor = Color.FromArgb(223, 208, 184);
            btnSearching.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearching.Location = new Point(798, 379);
            btnSearching.Name = "btnSearching";
            btnSearching.Size = new Size(241, 193);
            btnSearching.TabIndex = 8;
            btnSearching.Text = "Searching";
            btnSearching.UseVisualStyleBackColor = false;
            btnSearching.Click += btnSearching_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(223, 208, 184);
            btnBack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1096, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(231, 46);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ctrlAlgorithmVisualization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Controls.Add(btnPathfinding);
            Controls.Add(btnDynamicProgramming);
            Controls.Add(btnGreedy);
            Controls.Add(btnSorting);
            Controls.Add(btnSearching);
            Name = "ctrlAlgorithmVisualization";
            Size = new Size(1337, 603);
            Load += ctrlAlgorithmVisualization_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnPathfinding;
        private Button btnDynamicProgramming;
        private Button btnGreedy;
        private Button btnSorting;
        private Button btnSearching;
        private Button btnBack;
    }
}
