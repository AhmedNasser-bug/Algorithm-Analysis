namespace MainGUIcsproj.Algorithm_Visualization.DynamicProgrammin_Visual
{
    partial class ctrlDynamicProgramming
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
            btnKnapsackInf = new Button();
            btnKnapsack = new Button();
            btnFiboTab = new Button();
            btnMemoFib = new Button();
            ctrlDpVisualization1 = new UIControls.ctrlDpVisualization();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ctrlMetricsBox1 = new UIControls.ctrlMetricsBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(223, 208, 184);
            btnBack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1473, 21);
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
            lblTitle.Size = new Size(1707, 84);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Select Algorithm";
            // 
            // btnKnapsackInf
            // 
            btnKnapsackInf.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnKnapsackInf.BackColor = Color.FromArgb(223, 208, 184);
            btnKnapsackInf.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKnapsackInf.Location = new Point(3, 48);
            btnKnapsackInf.Name = "btnKnapsackInf";
            btnKnapsackInf.Size = new Size(328, 39);
            btnKnapsackInf.TabIndex = 23;
            btnKnapsackInf.Text = "Infinite Knapsack";
            btnKnapsackInf.UseVisualStyleBackColor = false;
            btnKnapsackInf.Click += btnKnapsackInf_Click_1;
            // 
            // btnKnapsack
            // 
            btnKnapsack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnKnapsack.BackColor = Color.FromArgb(223, 208, 184);
            btnKnapsack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKnapsack.Location = new Point(3, 3);
            btnKnapsack.Name = "btnKnapsack";
            btnKnapsack.Size = new Size(328, 39);
            btnKnapsack.TabIndex = 22;
            btnKnapsack.Text = "Knapsack 0/1";
            btnKnapsack.UseVisualStyleBackColor = false;
            btnKnapsack.Click += btnKnapsack_Click;
            // 
            // btnFiboTab
            // 
            btnFiboTab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFiboTab.BackColor = Color.FromArgb(223, 208, 184);
            btnFiboTab.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiboTab.Location = new Point(3, 138);
            btnFiboTab.Name = "btnFiboTab";
            btnFiboTab.Size = new Size(328, 39);
            btnFiboTab.TabIndex = 21;
            btnFiboTab.Text = "Fibonacci Tabulated";
            btnFiboTab.UseVisualStyleBackColor = false;
            btnFiboTab.Click += btnFiboTab_Click;
            // 
            // btnMemoFib
            // 
            btnMemoFib.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMemoFib.BackColor = Color.FromArgb(223, 208, 184);
            btnMemoFib.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMemoFib.Location = new Point(3, 93);
            btnMemoFib.Name = "btnMemoFib";
            btnMemoFib.Size = new Size(328, 39);
            btnMemoFib.TabIndex = 20;
            btnMemoFib.Text = "Fibonacci Memoized";
            btnMemoFib.UseVisualStyleBackColor = false;
            btnMemoFib.Click += btnMemoFib_Click;
            // 
            // ctrlDpVisualization1
            // 
            ctrlDpVisualization1.BackColor = Color.FromArgb(34, 40, 49);
            ctrlDpVisualization1.Location = new Point(3, 87);
            ctrlDpVisualization1.Name = "ctrlDpVisualization1";
            ctrlDpVisualization1.Size = new Size(1119, 646);
            ctrlDpVisualization1.TabIndex = 27;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnKnapsack);
            flowLayoutPanel1.Controls.Add(btnKnapsackInf);
            flowLayoutPanel1.Controls.Add(btnMemoFib);
            flowLayoutPanel1.Controls.Add(btnFiboTab);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(1373, 84);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(334, 1177);
            flowLayoutPanel1.TabIndex = 28;
            // 
            // ctrlMetricsBox1
            // 
            ctrlMetricsBox1.Location = new Point(3, 739);
            ctrlMetricsBox1.Name = "ctrlMetricsBox1";
            ctrlMetricsBox1.Size = new Size(585, 215);
            ctrlMetricsBox1.TabIndex = 29;
            // 
            // ctrlDynamicProgramming
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(ctrlMetricsBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ctrlDpVisualization1);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Name = "ctrlDynamicProgramming";
            Size = new Size(1707, 1261);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Button btnBack;
        private Label lblTitle;
        private Button btnKnapsackInf;
        private Button btnKnapsack;
        private Button btnFiboTab;
        private Button btnMemoFib;
        private UIControls.ctrlDpVisualization ctrlDpVisualization1;
        private FlowLayoutPanel flowLayoutPanel1;
        private UIControls.ctrlMetricsBox ctrlMetricsBox1;
    }
}
