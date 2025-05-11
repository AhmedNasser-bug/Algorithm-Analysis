namespace MainGUIcsproj.Algorithm_Visualization.Greedy_Visual
{
    partial class ctrlGreedyVisual
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
            btnKruskal = new Button();
            btnHuffmanCoding = new Button();
            btncCoinChange = new Button();
            btnActivitySelection = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(223, 208, 184);
            btnBack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(811, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(231, 46);
            btnBack.TabIndex = 26;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(52, 62, 70);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("SimSun-ExtB", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Transparent;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1045, 84);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Select Algorithm";
            // 
            // btnKruskal
            // 
            btnKruskal.Anchor = AnchorStyles.None;
            btnKruskal.BackColor = Color.FromArgb(223, 208, 184);
            btnKruskal.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKruskal.Location = new Point(368, 291);
            btnKruskal.Name = "btnKruskal";
            btnKruskal.Size = new Size(230, 82);
            btnKruskal.TabIndex = 23;
            btnKruskal.Text = "Kruskal";
            btnKruskal.UseVisualStyleBackColor = false;
            // 
            // btnHuffmanCoding
            // 
            btnHuffmanCoding.Anchor = AnchorStyles.None;
            btnHuffmanCoding.BackColor = Color.FromArgb(223, 208, 184);
            btnHuffmanCoding.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuffmanCoding.Location = new Point(619, 176);
            btnHuffmanCoding.Name = "btnHuffmanCoding";
            btnHuffmanCoding.Size = new Size(230, 82);
            btnHuffmanCoding.TabIndex = 22;
            btnHuffmanCoding.Text = "Huffman Coding";
            btnHuffmanCoding.UseVisualStyleBackColor = false;
            // 
            // btncCoinChange
            // 
            btncCoinChange.Anchor = AnchorStyles.None;
            btncCoinChange.BackColor = Color.FromArgb(223, 208, 184);
            btncCoinChange.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncCoinChange.Location = new Point(118, 176);
            btncCoinChange.Name = "btncCoinChange";
            btncCoinChange.Size = new Size(230, 82);
            btncCoinChange.TabIndex = 21;
            btncCoinChange.Text = "Coin Change";
            btncCoinChange.UseVisualStyleBackColor = false;
            // 
            // btnActivitySelection
            // 
            btnActivitySelection.Anchor = AnchorStyles.None;
            btnActivitySelection.BackColor = Color.FromArgb(223, 208, 184);
            btnActivitySelection.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivitySelection.Location = new Point(368, 176);
            btnActivitySelection.Name = "btnActivitySelection";
            btnActivitySelection.Size = new Size(230, 82);
            btnActivitySelection.TabIndex = 20;
            btnActivitySelection.Text = "Activity Selection";
            btnActivitySelection.UseVisualStyleBackColor = false;
            // 
            // ctrlGreedyVisual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 62, 70);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Controls.Add(btnKruskal);
            Controls.Add(btnHuffmanCoding);
            Controls.Add(btncCoinChange);
            Controls.Add(btnActivitySelection);
            Name = "ctrlGreedyVisual";
            Size = new Size(1045, 478);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Label lblTitle;
        private Button btnHeapSort;
        private Button btnKruskal;
        private Button btnHuffmanCoding;
        private Button btncCoinChange;
        private Button btnActivitySelection;
    }
}
