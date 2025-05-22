namespace UIControls
{
    partial class ctrlKnapsackInput
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
            ctrlPureArray2 = new ctrlVisualArray.ctrlPureArray();
            ctrlPureArray1 = new ctrlVisualArray.ctrlPureArray();
            lblCapacity = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ctrlPureArray2
            // 
            ctrlPureArray2.Location = new Point(128, 111);
            ctrlPureArray2.Name = "ctrlPureArray2";
            ctrlPureArray2.Size = new Size(1238, 66);
            ctrlPureArray2.TabIndex = 40;
            // 
            // ctrlPureArray1
            // 
            ctrlPureArray1.Location = new Point(128, 39);
            ctrlPureArray1.Name = "ctrlPureArray1";
            ctrlPureArray1.Size = new Size(1238, 66);
            ctrlPureArray1.TabIndex = 39;
            // 
            // lblCapacity
            // 
            lblCapacity.BackColor = Color.FromArgb(34, 40, 49);
            lblCapacity.Font = new Font("SimSun-ExtB", 22F, FontStyle.Bold);
            lblCapacity.ForeColor = Color.Transparent;
            lblCapacity.Location = new Point(159, -5);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(172, 41);
            lblCapacity.TabIndex = 38;
            lblCapacity.Text = "Capacity:";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(34, 40, 49);
            label3.Font = new Font("SimSun-ExtB", 22F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(2, -5);
            label3.Name = "label3";
            label3.Size = new Size(172, 41);
            label3.TabIndex = 37;
            label3.Text = "Capacity:";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(34, 40, 49);
            label2.Font = new Font("SimSun-ExtB", 22F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(2, 125);
            label2.Name = "label2";
            label2.Size = new Size(151, 41);
            label2.TabIndex = 36;
            label2.Text = "Values";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(34, 40, 49);
            label1.Font = new Font("SimSun-ExtB", 22F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(-1, 51);
            label1.Name = "label1";
            label1.Size = new Size(151, 41);
            label1.TabIndex = 35;
            label1.Text = "Weights";
            // 
            // ctrlKnapsackInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(ctrlPureArray2);
            Controls.Add(ctrlPureArray1);
            Controls.Add(lblCapacity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ctrlKnapsackInput";
            Size = new Size(1334, 199);
            ResumeLayout(false);
        }

        #endregion

        private ctrlVisualArray.ctrlPureArray ctrlPureArray2;
        private ctrlVisualArray.ctrlPureArray ctrlPureArray1;
        private Label lblCapacity;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
