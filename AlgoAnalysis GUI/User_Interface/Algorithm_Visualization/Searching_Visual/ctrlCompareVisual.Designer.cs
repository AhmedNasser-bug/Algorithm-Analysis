namespace MainGUIcsproj.Algorithm_Visualization.Searching_Visual
{
    partial class ctrlCompareVisual
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
            btnInCompare = new Button();
            btnBack = new Button();
            label1 = new Label();
            ctrlPureArray1 = new UIControls.ctrlVisualArray.ctrlPureArray();
            label2 = new Label();
            ctrlPureArray2 = new UIControls.ctrlVisualArray.ctrlPureArray();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblTargetIndex = new Label();
            lblTargetFirst = new Label();
            lblTargetSecond = new Label();
            SuspendLayout();
            // 
            // btnInCompare
            // 
            btnInCompare.Anchor = AnchorStyles.None;
            btnInCompare.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInCompare.BackColor = Color.FromArgb(223, 208, 184);
            btnInCompare.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInCompare.Location = new Point(868, 583);
            btnInCompare.Name = "btnInCompare";
            btnInCompare.Size = new Size(254, 132);
            btnInCompare.TabIndex = 29;
            btnInCompare.Text = "Compare";
            btnInCompare.UseVisualStyleBackColor = false;
            btnInCompare.Click += btnInCompare_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(223, 208, 184);
            btnBack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1644, 957);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(231, 46);
            btnBack.TabIndex = 30;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 29);
            label1.TabIndex = 33;
            label1.Text = "Linear Search: ";
            // 
            // ctrlPureArray1
            // 
            ctrlPureArray1.Dock = DockStyle.Top;
            ctrlPureArray1.Location = new Point(0, 29);
            ctrlPureArray1.Name = "ctrlPureArray1";
            ctrlPureArray1.Size = new Size(1924, 173);
            ctrlPureArray1.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(0, 202);
            label2.Name = "label2";
            label2.Size = new Size(237, 29);
            label2.TabIndex = 36;
            label2.Text = "Binary Search:";
            // 
            // ctrlPureArray2
            // 
            ctrlPureArray2.Dock = DockStyle.Top;
            ctrlPureArray2.Location = new Point(0, 231);
            ctrlPureArray2.Name = "ctrlPureArray2";
            ctrlPureArray2.Size = new Size(1924, 173);
            ctrlPureArray2.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(3, 583);
            label3.Name = "label3";
            label3.Size = new Size(253, 29);
            label3.TabIndex = 38;
            label3.Text = "Targeted Index:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(3, 634);
            label4.Name = "label4";
            label4.Size = new Size(365, 29);
            label4.TabIndex = 39;
            label4.Text = "Target In First Array:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(3, 685);
            label5.Name = "label5";
            label5.Size = new Size(381, 29);
            label5.TabIndex = 40;
            label5.Text = "Target In Second Array:";
            // 
            // lblTargetIndex
            // 
            lblTargetIndex.AutoSize = true;
            lblTargetIndex.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lblTargetIndex.ForeColor = SystemColors.ControlLightLight;
            lblTargetIndex.Location = new Point(413, 583);
            lblTargetIndex.Name = "lblTargetIndex";
            lblTargetIndex.Size = new Size(29, 29);
            lblTargetIndex.TabIndex = 41;
            lblTargetIndex.Text = "5";
            // 
            // lblTargetFirst
            // 
            lblTargetFirst.AutoSize = true;
            lblTargetFirst.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lblTargetFirst.ForeColor = SystemColors.ControlLightLight;
            lblTargetFirst.Location = new Point(413, 635);
            lblTargetFirst.Name = "lblTargetFirst";
            lblTargetFirst.Size = new Size(29, 29);
            lblTargetFirst.TabIndex = 42;
            lblTargetFirst.Text = "_";
            // 
            // lblTargetSecond
            // 
            lblTargetSecond.AutoSize = true;
            lblTargetSecond.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lblTargetSecond.ForeColor = SystemColors.ControlLightLight;
            lblTargetSecond.Location = new Point(413, 685);
            lblTargetSecond.Name = "lblTargetSecond";
            lblTargetSecond.Size = new Size(29, 29);
            lblTargetSecond.TabIndex = 43;
            lblTargetSecond.Text = "_";
            // 
            // ctrlCompareVisual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(lblTargetSecond);
            Controls.Add(lblTargetFirst);
            Controls.Add(lblTargetIndex);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ctrlPureArray2);
            Controls.Add(label2);
            Controls.Add(ctrlPureArray1);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnInCompare);
            Name = "ctrlCompareVisual";
            Size = new Size(1924, 1036);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnInCompare;
        private Button btnBack;
        private Label label1;
        private UIControls.ctrlVisualArray.ctrlPureArray ctrlPureArray1;
        private Label label2;
        private UIControls.ctrlVisualArray.ctrlPureArray ctrlPureArray2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblTargetIndex;
        private Label lblTargetFirst;
        private Label lblTargetSecond;
    }
}
