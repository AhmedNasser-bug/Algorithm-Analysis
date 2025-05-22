namespace MainGUIcsproj.Algorithm_Visualization.DynamicProgrammin_Visual
{
    partial class FibonacciInput
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
            brnConfirm = new Button();
            mtbInpsize = new MaskedTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // brnConfirm
            // 
            brnConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            brnConfirm.BackColor = Color.FromArgb(223, 208, 184);
            brnConfirm.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnConfirm.Location = new Point(86, 103);
            brnConfirm.Name = "brnConfirm";
            brnConfirm.Size = new Size(187, 42);
            brnConfirm.TabIndex = 51;
            brnConfirm.Text = "Confirm";
            brnConfirm.UseVisualStyleBackColor = false;
            // 
            // mtbInpsize
            // 
            mtbInpsize.Location = new Point(215, 59);
            mtbInpsize.Mask = "00000";
            mtbInpsize.Name = "mtbInpsize";
            mtbInpsize.Size = new Size(100, 23);
            mtbInpsize.TabIndex = 49;
            mtbInpsize.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 53);
            label4.Name = "label4";
            label4.Size = new Size(189, 29);
            label4.TabIndex = 47;
            label4.Text = "input size:";
            // 
            // FibonacciInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(350, 167);
            Controls.Add(brnConfirm);
            Controls.Add(mtbInpsize);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FibonacciInput";
            Text = "FibonacciInput";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button brnConfirm;
        private MaskedTextBox mtbInpsize;
        private Label label4;
    }
}