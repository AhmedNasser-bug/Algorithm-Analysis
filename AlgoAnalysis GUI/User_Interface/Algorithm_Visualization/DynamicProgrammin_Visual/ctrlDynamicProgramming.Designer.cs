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
            btnLCS = new Button();
            btnKnapsackInf = new Button();
            btnKnapsack = new Button();
            btnFiboTab = new Button();
            btnMemoFib = new Button();
            ctrlDpVisualization1 = new UIControls.ctrlDpVisualization();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(223, 208, 184);
            btnBack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(888, 21);
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
            lblTitle.Size = new Size(1122, 84);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Select Algorithm";
            // 
            // btnLCS
            // 
            btnLCS.BackColor = Color.FromArgb(223, 208, 184);
            btnLCS.Dock = DockStyle.Bottom;
            btnLCS.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLCS.Location = new Point(0, 879);
            btnLCS.Name = "btnLCS";
            btnLCS.Size = new Size(1122, 115);
            btnLCS.TabIndex = 24;
            btnLCS.Text = "Longest Common Subsequence (LCS)";
            btnLCS.UseVisualStyleBackColor = false;
            // 
            // btnKnapsackInf
            // 
            btnKnapsackInf.BackColor = Color.FromArgb(223, 208, 184);
            btnKnapsackInf.Dock = DockStyle.Bottom;
            btnKnapsackInf.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKnapsackInf.Location = new Point(0, 994);
            btnKnapsackInf.Name = "btnKnapsackInf";
            btnKnapsackInf.Size = new Size(1122, 115);
            btnKnapsackInf.TabIndex = 23;
            btnKnapsackInf.Text = "Infinite Knapsack";
            btnKnapsackInf.UseVisualStyleBackColor = false;
            btnKnapsackInf.Click += btnInsertionSort_Click;
            // 
            // btnKnapsack
            // 
            btnKnapsack.BackColor = Color.FromArgb(223, 208, 184);
            btnKnapsack.Dock = DockStyle.Bottom;
            btnKnapsack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKnapsack.Location = new Point(0, 1109);
            btnKnapsack.Name = "btnKnapsack";
            btnKnapsack.Size = new Size(1122, 115);
            btnKnapsack.TabIndex = 22;
            btnKnapsack.Text = "Knapsack 0/1";
            btnKnapsack.UseVisualStyleBackColor = false;
            // 
            // btnFiboTab
            // 
            btnFiboTab.BackColor = Color.FromArgb(223, 208, 184);
            btnFiboTab.Dock = DockStyle.Bottom;
            btnFiboTab.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiboTab.Location = new Point(0, 1224);
            btnFiboTab.Name = "btnFiboTab";
            btnFiboTab.Size = new Size(1122, 115);
            btnFiboTab.TabIndex = 21;
            btnFiboTab.Text = "Fibonacci Tabulated";
            btnFiboTab.UseVisualStyleBackColor = false;
            // 
            // btnMemoFib
            // 
            btnMemoFib.BackColor = Color.FromArgb(223, 208, 184);
            btnMemoFib.Dock = DockStyle.Bottom;
            btnMemoFib.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMemoFib.Location = new Point(0, 1339);
            btnMemoFib.Name = "btnMemoFib";
            btnMemoFib.Size = new Size(1122, 115);
            btnMemoFib.TabIndex = 20;
            btnMemoFib.Text = "Fibonacci Memoized";
            btnMemoFib.UseVisualStyleBackColor = false;
            btnMemoFib.Click += btnMemoFib_Click;
            // 
            // ctrlDpVisualization1
            // 
            ctrlDpVisualization1.Location = new Point(123, 87);
            ctrlDpVisualization1.Name = "ctrlDpVisualization1";
            ctrlDpVisualization1.Size = new Size(809, 646);
            ctrlDpVisualization1.TabIndex = 27;
            // 
            // ctrlDynamicProgramming
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(ctrlDpVisualization1);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Controls.Add(btnLCS);
            Controls.Add(btnKnapsackInf);
            Controls.Add(btnKnapsack);
            Controls.Add(btnFiboTab);
            Controls.Add(btnMemoFib);
            Name = "ctrlDynamicProgramming";
            Size = new Size(1122, 1454);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Label lblTitle;
        private Button btnLCS;
        private Button btnKnapsackInf;
        private Button btnKnapsack;
        private Button btnFiboTab;
        private Button btnMemoFib;
        private UIControls.ctrlDpVisualization ctrlDpVisualization1;
    }
}
