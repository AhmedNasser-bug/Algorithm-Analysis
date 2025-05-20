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
            btnDijkstra = new Button();
            ctrlGraphVisualizer1 = new UIControls.ctrlGraphVisualizer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            btnCancel = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(223, 208, 184);
            btnBack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1699, 7);
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
            lblTitle.Font = new Font("SimSun-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Transparent;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1933, 84);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Pathfinding Algorithms";
            // 
            // btnFloydWarshall
            // 
            btnFloydWarshall.Anchor = AnchorStyles.Bottom;
            btnFloydWarshall.BackColor = Color.FromArgb(223, 208, 184);
            btnFloydWarshall.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFloydWarshall.Location = new Point(291, 3);
            btnFloydWarshall.Name = "btnFloydWarshall";
            btnFloydWarshall.Size = new Size(280, 90);
            btnFloydWarshall.TabIndex = 22;
            btnFloydWarshall.Text = "Floyd-Warshall";
            btnFloydWarshall.UseVisualStyleBackColor = false;
            // 
            // btnDijkstra
            // 
            btnDijkstra.Anchor = AnchorStyles.Bottom;
            btnDijkstra.BackColor = Color.FromArgb(223, 208, 184);
            btnDijkstra.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDijkstra.Location = new Point(577, 3);
            btnDijkstra.Name = "btnDijkstra";
            btnDijkstra.Size = new Size(280, 90);
            btnDijkstra.TabIndex = 21;
            btnDijkstra.Text = "Dijkstra's Algorithm";
            btnDijkstra.UseVisualStyleBackColor = false;
            btnDijkstra.Click += btnDijkstra_Click;
            // 
            // ctrlGraphVisualizer1
            // 
            ctrlGraphVisualizer1.Dock = DockStyle.Top;
            ctrlGraphVisualizer1.Location = new Point(0, 84);
            ctrlGraphVisualizer1.Name = "ctrlGraphVisualizer1";
            ctrlGraphVisualizer1.Size = new Size(1933, 480);
            ctrlGraphVisualizer1.TabIndex = 27;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(btnDijkstra);
            flowLayoutPanel1.Controls.Add(btnFloydWarshall);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(1073, 962);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(860, 97);
            flowLayoutPanel1.TabIndex = 29;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(223, 208, 184);
            button1.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(5, 3);
            button1.Name = "button1";
            button1.Size = new Size(280, 90);
            button1.TabIndex = 23;
            button1.Text = "Bellman Ford";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(223, 208, 184);
            btnCancel.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(1462, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(231, 46);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ctrlPathfindingVisual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(btnCancel);
            Controls.Add(btnBack);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ctrlGraphVisualizer1);
            Controls.Add(lblTitle);
            Name = "ctrlPathfindingVisual";
            Size = new Size(1933, 1059);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Label lblTitle;
        private Button btnFloydWarshall;
        private Button btnDijkstra;
        private UIControls.ctrlGraphVisualizer ctrlGraphVisualizer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button btnCancel;
    }
}
