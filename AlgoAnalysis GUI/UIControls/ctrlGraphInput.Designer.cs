namespace UIControls
{
    partial class ctrlGraphInput
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
            ctrlGraphVisualizer1 = new ctrlGraphVisualizer();
            SuspendLayout();
            // 
            // ctrlGraphVisualizer1
            // 
            ctrlGraphVisualizer1.Dock = DockStyle.Left;
            ctrlGraphVisualizer1.Location = new Point(0, 0);
            ctrlGraphVisualizer1.Name = "ctrlGraphVisualizer1";
            ctrlGraphVisualizer1.Size = new Size(456, 550);
            ctrlGraphVisualizer1.TabIndex = 0;
            // 
            // ctrlGraphInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(ctrlGraphVisualizer1);
            Name = "ctrlGraphInput";
            Size = new Size(1052, 550);
            ResumeLayout(false);
        }

        #endregion

        private ctrlGraphVisualizer ctrlGraphVisualizer1;
    }
}
