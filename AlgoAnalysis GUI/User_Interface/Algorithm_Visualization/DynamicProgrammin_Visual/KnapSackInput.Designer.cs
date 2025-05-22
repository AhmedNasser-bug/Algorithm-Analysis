namespace MainGUIcsproj.Algorithm_Visualization.DynamicProgrammin_Visual
{
    partial class KnapSackInput
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label1 = new Label();
            mtbInpsize = new MaskedTextBox();
            mtpCapacity = new MaskedTextBox();
            brnConfirm = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 37);
            label4.Name = "label4";
            label4.Size = new Size(189, 29);
            label4.TabIndex = 41;
            label4.Text = "input size:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(157, 29);
            label1.TabIndex = 42;
            label1.Text = "Capacity:";
            // 
            // mtbInpsize
            // 
            mtbInpsize.Location = new Point(207, 43);
            mtbInpsize.Mask = "00000";
            mtbInpsize.Name = "mtbInpsize";
            mtbInpsize.Size = new Size(100, 23);
            mtbInpsize.TabIndex = 43;
            mtbInpsize.ValidatingType = typeof(int);
            // 
            // mtpCapacity
            // 
            mtpCapacity.Location = new Point(207, 76);
            mtpCapacity.Mask = "00000";
            mtpCapacity.Name = "mtpCapacity";
            mtpCapacity.Size = new Size(100, 23);
            mtpCapacity.TabIndex = 44;
            mtpCapacity.ValidatingType = typeof(int);
            // 
            // brnConfirm
            // 
            brnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            brnConfirm.BackColor = Color.FromArgb(223, 208, 184);
            brnConfirm.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnConfirm.Location = new Point(74, 129);
            brnConfirm.Name = "brnConfirm";
            brnConfirm.Size = new Size(187, 42);
            brnConfirm.TabIndex = 45;
            brnConfirm.Text = "Confirm";
            brnConfirm.UseVisualStyleBackColor = false;
            brnConfirm.Click += brnConfirm_Click;
            // 
            // KnapSackInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(333, 183);
            Controls.Add(brnConfirm);
            Controls.Add(mtpCapacity);
            Controls.Add(mtbInpsize);
            Controls.Add(label1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "KnapSackInput";
            Text = "KnapSackInput";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label1;
        private MaskedTextBox mtbInpsize;
        private MaskedTextBox mtpCapacity;
        private Button brnConfirm;
    }
}