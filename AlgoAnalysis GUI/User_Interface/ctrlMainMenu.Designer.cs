namespace MainGUIcsproj.Algorithm_Visualization
{
    partial class ctrlMainMenu
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
            lblTitle = new Label();
            btnCompare = new Button();
            btnVisualize = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(52, 62, 70);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("SimSun-ExtB", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Transparent;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1131, 118);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Algorithm Analysis Engine";
            // 
            // btnCompare
            // 
            btnCompare.Anchor = AnchorStyles.None;
            btnCompare.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCompare.BackColor = Color.FromArgb(223, 208, 184);
            btnCompare.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompare.Location = new Point(682, 231);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(298, 292);
            btnCompare.TabIndex = 5;
            btnCompare.Text = "Compare Algorithms";
            btnCompare.UseVisualStyleBackColor = false;
            // 
            // btnVisualize
            // 
            btnVisualize.Anchor = AnchorStyles.None;
            btnVisualize.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVisualize.BackColor = Color.FromArgb(223, 208, 184);
            btnVisualize.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVisualize.Location = new Point(164, 231);
            btnVisualize.Name = "btnVisualize";
            btnVisualize.Size = new Size(298, 292);
            btnVisualize.TabIndex = 4;
            btnVisualize.Text = "Visualize algorithms";
            btnVisualize.UseVisualStyleBackColor = false;
            btnVisualize.Click += btnVisualize_Click;
            // 
            // ctrlMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            Controls.Add(lblTitle);
            Controls.Add(btnCompare);
            Controls.Add(btnVisualize);
            Name = "ctrlMainMenu";
            Size = new Size(1131, 596);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnCompare;
        private Button btnVisualize;
    }
}
