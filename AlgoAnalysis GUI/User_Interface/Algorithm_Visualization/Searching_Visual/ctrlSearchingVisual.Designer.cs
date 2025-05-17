namespace MainGUIcsproj.Algorithm_Visualization.Searching_Visual
{
    partial class ctrlSearchingVisual
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
            btnBinarySEarch = new Button();
            btnLinearSearch = new Button();
            ctrlVisualArray1 = new Controls.ctrlVisualArray();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(223, 208, 184);
            btnBack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1296, 21);
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
            lblTitle.Size = new Size(1530, 118);
            lblTitle.TabIndex = 29;
            lblTitle.Text = "Select Algorithm";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBinarySEarch
            // 
            btnBinarySEarch.Anchor = AnchorStyles.None;
            btnBinarySEarch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBinarySEarch.BackColor = Color.FromArgb(223, 208, 184);
            btnBinarySEarch.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBinarySEarch.Location = new Point(796, 505);
            btnBinarySEarch.Name = "btnBinarySEarch";
            btnBinarySEarch.Size = new Size(298, 175);
            btnBinarySEarch.TabIndex = 28;
            btnBinarySEarch.Text = "Binary Search";
            btnBinarySEarch.UseVisualStyleBackColor = false;
            btnBinarySEarch.Click += btnBinarySEarch_Click;
            // 
            // btnLinearSearch
            // 
            btnLinearSearch.Anchor = AnchorStyles.None;
            btnLinearSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLinearSearch.BackColor = Color.FromArgb(223, 208, 184);
            btnLinearSearch.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLinearSearch.Location = new Point(465, 505);
            btnLinearSearch.Name = "btnLinearSearch";
            btnLinearSearch.Size = new Size(298, 175);
            btnLinearSearch.TabIndex = 27;
            btnLinearSearch.Text = "Linear Search";
            btnLinearSearch.UseVisualStyleBackColor = false;
            btnLinearSearch.Click += btnLinearSearch_Click;
            // 
            // ctrlVisualArray1
            // 
            ctrlVisualArray1.Dock = DockStyle.Top;
            ctrlVisualArray1.Location = new Point(0, 118);
            ctrlVisualArray1.Name = "ctrlVisualArray1";
            ctrlVisualArray1.Size = new Size(1530, 362);
            ctrlVisualArray1.TabIndex = 30;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(172, 620);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(141, 23);
            maskedTextBox1.TabIndex = 31;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(41, 614);
            label1.Name = "label1";
            label1.Size = new Size(125, 29);
            label1.TabIndex = 32;
            label1.Text = "Target:";
            // 
            // ctrlSearchingVisual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Controls.Add(ctrlVisualArray1);
            Controls.Add(btnBinarySEarch);
            Controls.Add(btnLinearSearch);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Name = "ctrlSearchingVisual";
            Size = new Size(1530, 840);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblTitle;
        private Button btnBinarySEarch;
        private Button btnLinearSearch;
        private Controls.ctrlVisualArray ctrlVisualArray1;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
    }
}
