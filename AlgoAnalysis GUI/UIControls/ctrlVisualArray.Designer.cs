namespace MainGUIcsproj.Controls
{
    partial class ctrlVisualArray
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            btnGenerateArray = new Button();
            trackBar1 = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            lblDelayValue = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1537, 172);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(114, 261);
            numericUpDown1.Maximum = new decimal(new int[] { 44, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 255);
            label1.Name = "label1";
            label1.Size = new Size(109, 29);
            label1.TabIndex = 1;
            label1.Text = "Range:";
            // 
            // btnGenerateArray
            // 
            btnGenerateArray.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            btnGenerateArray.Location = new Point(622, 261);
            btnGenerateArray.Name = "btnGenerateArray";
            btnGenerateArray.Size = new Size(277, 45);
            btnGenerateArray.TabIndex = 2;
            btnGenerateArray.Text = "Generate Array";
            btnGenerateArray.UseVisualStyleBackColor = true;
            btnGenerateArray.Click += btnGenerateArray_Click_1;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 500;
            trackBar1.Location = new Point(1261, 261);
            trackBar1.Maximum = 5000;
            trackBar1.Minimum = 500;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(210, 45);
            trackBar1.SmallChange = 100;
            trackBar1.TabIndex = 3;
            trackBar1.Value = 500;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(1114, 261);
            label2.Name = "label2";
            label2.Size = new Size(109, 29);
            label2.TabIndex = 4;
            label2.Text = "Delay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(1114, 318);
            label3.Name = "label3";
            label3.Size = new Size(205, 29);
            label3.TabIndex = 5;
            label3.Text = "Delay Value:";
            // 
            // lblDelayValue
            // 
            lblDelayValue.AutoSize = true;
            lblDelayValue.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            lblDelayValue.ForeColor = SystemColors.ControlLightLight;
            lblDelayValue.Location = new Point(1325, 318);
            lblDelayValue.Name = "lblDelayValue";
            lblDelayValue.Size = new Size(61, 29);
            lblDelayValue.TabIndex = 6;
            lblDelayValue.Text = "500";
            lblDelayValue.Click += label4_Click;
            // 
            // ctrlVisualArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDelayValue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(trackBar1);
            Controls.Add(btnGenerateArray);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(flowLayoutPanel1);
            Name = "ctrlVisualArray";
            Size = new Size(1537, 371);
            Load += ctrlVisualArray_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button btnGenerateArray;
        private TrackBar trackBar1;
        private Label label2;
        private Label label3;
        private Label lblDelayValue;
    }
}
