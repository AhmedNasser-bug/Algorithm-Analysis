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
            flowLayoutPanel1 = new FlowLayoutPanel();
            ctrlMetricsBox1 = new UIControls.ctrlMetricsBox();
            ctrlDpVisualization1 = new UIControls.ctrlDpVisualization();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(223, 208, 184);
            btnBack.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1367, 21);
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
            lblTitle.Size = new Size(1601, 84);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Select Algorithm";
            // 
            // btnKruskal
            // 
            btnKruskal.Anchor = AnchorStyles.None;
            btnKruskal.BackColor = Color.FromArgb(223, 208, 184);
            btnKruskal.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKruskal.Location = new Point(3, 267);
            btnKruskal.Name = "btnKruskal";
            btnKruskal.Size = new Size(230, 82);
            btnKruskal.TabIndex = 23;
            btnKruskal.Text = "Kruskal";
            btnKruskal.UseVisualStyleBackColor = false;
            btnKruskal.Click += btnKruskal_Click;
            // 
            // btnHuffmanCoding
            // 
            btnHuffmanCoding.Anchor = AnchorStyles.None;
            btnHuffmanCoding.BackColor = Color.FromArgb(223, 208, 184);
            btnHuffmanCoding.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuffmanCoding.Location = new Point(3, 179);
            btnHuffmanCoding.Name = "btnHuffmanCoding";
            btnHuffmanCoding.Size = new Size(230, 82);
            btnHuffmanCoding.TabIndex = 22;
            btnHuffmanCoding.Text = "Huffman Coding";
            btnHuffmanCoding.UseVisualStyleBackColor = false;
            btnHuffmanCoding.Click += btnHuffmanCoding_Click;
            // 
            // btncCoinChange
            // 
            btncCoinChange.Anchor = AnchorStyles.None;
            btncCoinChange.BackColor = Color.FromArgb(223, 208, 184);
            btncCoinChange.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncCoinChange.Location = new Point(3, 91);
            btncCoinChange.Name = "btncCoinChange";
            btncCoinChange.Size = new Size(230, 82);
            btncCoinChange.TabIndex = 21;
            btncCoinChange.Text = "Coin Change";
            btncCoinChange.UseVisualStyleBackColor = false;
            btncCoinChange.Click += btncCoinChange_Click;
            // 
            // btnActivitySelection
            // 
            btnActivitySelection.Anchor = AnchorStyles.None;
            btnActivitySelection.BackColor = Color.FromArgb(223, 208, 184);
            btnActivitySelection.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivitySelection.Location = new Point(3, 3);
            btnActivitySelection.Name = "btnActivitySelection";
            btnActivitySelection.Size = new Size(230, 82);
            btnActivitySelection.TabIndex = 20;
            btnActivitySelection.Text = "Activity Selection";
            btnActivitySelection.UseVisualStyleBackColor = false;
            btnActivitySelection.Click += btnActivitySelection_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnActivitySelection);
            flowLayoutPanel1.Controls.Add(btncCoinChange);
            flowLayoutPanel1.Controls.Add(btnHuffmanCoding);
            flowLayoutPanel1.Controls.Add(btnKruskal);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(1379, 84);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(222, 1021);
            flowLayoutPanel1.TabIndex = 27;
            // 
            // ctrlMetricsBox1
            // 
            ctrlMetricsBox1.Location = new Point(3, 890);
            ctrlMetricsBox1.Name = "ctrlMetricsBox1";
            ctrlMetricsBox1.Size = new Size(585, 215);
            ctrlMetricsBox1.TabIndex = 28;
            // 
            // ctrlDpVisualization1
            // 
            ctrlDpVisualization1.BackColor = Color.FromArgb(34, 40, 49);
            ctrlDpVisualization1.Location = new Point(3, 74);
            ctrlDpVisualization1.Name = "ctrlDpVisualization1";
            ctrlDpVisualization1.Size = new Size(1033, 698);
            ctrlDpVisualization1.TabIndex = 29;
            // 
            // ctrlGreedyVisual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(ctrlDpVisualization1);
            Controls.Add(ctrlMetricsBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Name = "ctrlGreedyVisual";
            Size = new Size(1601, 1105);
            flowLayoutPanel1.ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanel1;
        private UIControls.ctrlMetricsBox ctrlMetricsBox1;
        private UIControls.ctrlDpVisualization ctrlDpVisualization1;
    }
}
