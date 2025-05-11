namespace UIControls
{
    partial class ctrlButtonTemplate
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(223, 208, 184);
            button1.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 3);
            button1.Name = "button1";
            button1.Size = new Size(250, 90);
            button1.TabIndex = 0;
            button1.Text = "Placeholder Button";
            button1.UseVisualStyleBackColor = false;
            // 
            // ctrlButtonTemplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Name = "ctrlButtonTemplate";
            Size = new Size(256, 96);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
