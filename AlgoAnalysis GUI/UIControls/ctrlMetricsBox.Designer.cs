namespace UIControls
{
    partial class ctrlMetricsBox
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
            groupBox1 = new GroupBox();
            lblTotalNumberOfSteps = new Label();
            label4 = new Label();
            btnCompare = new Button();
            btnAnalyzePerformance = new Button();
            label2 = new Label();
            lblTotalRuntime = new Label();
            lbl = new Label();
            label5 = new Label();
            lblTotalSwaps = new Label();
            lblArrayAccesses = new Label();
            lblTotalNumberOfComprs = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(34, 40, 49);
            groupBox1.Controls.Add(lblTotalNumberOfSteps);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCompare);
            groupBox1.Controls.Add(btnAnalyzePerformance);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblTotalRuntime);
            groupBox1.Controls.Add(lbl);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblTotalSwaps);
            groupBox1.Controls.Add(lblArrayAccesses);
            groupBox1.Controls.Add(lblTotalNumberOfComprs);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 215);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metrics";
            // 
            // lblTotalNumberOfSteps
            // 
            lblTotalNumberOfSteps.AutoSize = true;
            lblTotalNumberOfSteps.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lblTotalNumberOfSteps.ForeColor = Color.White;
            lblTotalNumberOfSteps.Location = new Point(297, 107);
            lblTotalNumberOfSteps.Name = "lblTotalNumberOfSteps";
            lblTotalNumberOfSteps.Size = new Size(61, 29);
            lblTotalNumberOfSteps.TabIndex = 41;
            lblTotalNumberOfSteps.Text = "###";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(285, 29);
            label4.TabIndex = 40;
            label4.Text = "Total # of Steps:";
            // 
            // btnCompare
            // 
            btnCompare.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCompare.BackColor = Color.FromArgb(223, 208, 184);
            btnCompare.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompare.ForeColor = SystemColors.ControlText;
            btnCompare.Location = new Point(256, 260);
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
            btnAnalyzePerformance.Location = new Point(6, 260);
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
            label2.Size = new Size(397, 29);
            label2.TabIndex = 25;
            label2.Text = "Total # of Comparissons:";
            // 
            // lblTotalRuntime
            // 
            lblTotalRuntime.AutoSize = true;
            lblTotalRuntime.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lblTotalRuntime.ForeColor = Color.White;
            lblTotalRuntime.Location = new Point(249, 136);
            lblTotalRuntime.Name = "lblTotalRuntime";
            lblTotalRuntime.Size = new Size(61, 29);
            lblTotalRuntime.TabIndex = 30;
            lblTotalRuntime.Text = "###";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 136);
            label5.Name = "label5";
            label5.Size = new Size(237, 29);
            label5.TabIndex = 29;
            label5.Text = "Total Runtime:";
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
            // ctrlMetricsBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctrlMetricsBox";
            Size = new Size(585, 215);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCompare;
        private Button btnAnalyzePerformance;
        private Label label2;
        private Label lblTotalRuntime;
        private Label lbl;
        private Label label5;
        private Label lblTotalSwaps;
        private Label lblArrayAccesses;
        private Label lblTotalNumberOfComprs;
        private Label label3;
        private Label lblTotalNumberOfSteps;
        private Label label4;
    }
}
