namespace UIControls
{
    partial class ctrlGreedyVisualization
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
            label1 = new Label();
            cbChoosenProblem = new ComboBox();
            ds = new TabControl();
            tbCoinChange = new TabPage();
            tbActivitySelection = new TabPage();
            tbHuffmanCoding = new TabPage();
            tbKruskal = new TabPage();
            ctrlMetricsBox1 = new ctrlMetricsBox();
            ds.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(285, 29);
            label1.TabIndex = 5;
            label1.Text = "Choose Algorithm:";
            // 
            // cbChoosenProblem
            // 
            cbChoosenProblem.FormattingEnabled = true;
            cbChoosenProblem.Items.AddRange(new object[] { "Coin Change", "Activity Selection", "Huffman Coding", "Kruskal" });
            cbChoosenProblem.Location = new Point(294, 15);
            cbChoosenProblem.Name = "cbChoosenProblem";
            cbChoosenProblem.Size = new Size(223, 23);
            cbChoosenProblem.TabIndex = 4;
            // 
            // ds
            // 
            ds.Controls.Add(tbCoinChange);
            ds.Controls.Add(tbActivitySelection);
            ds.Controls.Add(tbHuffmanCoding);
            ds.Controls.Add(tbKruskal);
            ds.Location = new Point(558, 124);
            ds.Name = "ds";
            ds.SelectedIndex = 0;
            ds.Size = new Size(751, 382);
            ds.TabIndex = 6;
            // 
            // tbCoinChange
            // 
            tbCoinChange.Location = new Point(4, 24);
            tbCoinChange.Name = "tbCoinChange";
            tbCoinChange.Padding = new Padding(3);
            tbCoinChange.Size = new Size(743, 354);
            tbCoinChange.TabIndex = 0;
            tbCoinChange.Text = "CoinChangeTab";
            tbCoinChange.UseVisualStyleBackColor = true;
            // 
            // tbActivitySelection
            // 
            tbActivitySelection.Location = new Point(4, 24);
            tbActivitySelection.Name = "tbActivitySelection";
            tbActivitySelection.Padding = new Padding(3);
            tbActivitySelection.Size = new Size(743, 354);
            tbActivitySelection.TabIndex = 1;
            tbActivitySelection.Text = "ActivitySelectionTab";
            tbActivitySelection.UseVisualStyleBackColor = true;
            // 
            // tbHuffmanCoding
            // 
            tbHuffmanCoding.Location = new Point(4, 24);
            tbHuffmanCoding.Name = "tbHuffmanCoding";
            tbHuffmanCoding.Padding = new Padding(3);
            tbHuffmanCoding.Size = new Size(743, 354);
            tbHuffmanCoding.TabIndex = 2;
            tbHuffmanCoding.Text = "HuffmanCodingTab";
            tbHuffmanCoding.UseVisualStyleBackColor = true;
            // 
            // tbKruskal
            // 
            tbKruskal.Location = new Point(4, 24);
            tbKruskal.Name = "tbKruskal";
            tbKruskal.Padding = new Padding(3);
            tbKruskal.Size = new Size(743, 354);
            tbKruskal.TabIndex = 3;
            tbKruskal.Text = "KruskalTab";
            tbKruskal.UseVisualStyleBackColor = true;
            // 
            // ctrlMetricsBox1
            // 
            ctrlMetricsBox1.Location = new Point(3, 339);
            ctrlMetricsBox1.Name = "ctrlMetricsBox1";
            ctrlMetricsBox1.Size = new Size(517, 215);
            ctrlMetricsBox1.TabIndex = 7;
            // 
            // ctrlGreedyVisualization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlMetricsBox1);
            Controls.Add(ds);
            Controls.Add(label1);
            Controls.Add(cbChoosenProblem);
            Name = "ctrlGreedyVisualization";
            Size = new Size(1406, 557);
            ds.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbChoosenProblem;
        private TabControl ds;
        private TabPage tbCoinChange;
        private TabPage tbActivitySelection;
        private ctrlMetricsBox ctrlMetricsBox1;
        private TabPage tbHuffmanCoding;
        private TabPage tbKruskal;
    }
}
