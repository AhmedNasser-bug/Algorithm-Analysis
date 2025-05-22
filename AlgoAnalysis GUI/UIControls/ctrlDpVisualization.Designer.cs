namespace UIControls
{
    partial class ctrlDpVisualization
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
            flpNotes = new FlowLayoutPanel();
            flpState = new FlowLayoutPanel();
            flpRuntime = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // flpNotes
            // 
            flpNotes.Dock = DockStyle.Fill;
            flpNotes.FlowDirection = FlowDirection.TopDown;
            flpNotes.Location = new Point(3, 32);
            flpNotes.Name = "flpNotes";
            flpNotes.Size = new Size(336, 663);
            flpNotes.TabIndex = 0;
            // 
            // flpState
            // 
            flpState.Dock = DockStyle.Fill;
            flpState.FlowDirection = FlowDirection.TopDown;
            flpState.Location = new Point(3, 32);
            flpState.Name = "flpState";
            flpState.Size = new Size(336, 663);
            flpState.TabIndex = 1;
            // 
            // flpRuntime
            // 
            flpRuntime.Dock = DockStyle.Fill;
            flpRuntime.FlowDirection = FlowDirection.TopDown;
            flpRuntime.Location = new Point(3, 32);
            flpRuntime.Name = "flpRuntime";
            flpRuntime.Size = new Size(336, 663);
            flpRuntime.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flpRuntime);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 698);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Runtime";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flpState);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(342, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 698);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Memory State";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flpNotes);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Font = new Font("SimSun-ExtB", 21.75F, FontStyle.Bold);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(684, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(342, 698);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Notes";
            // 
            // ctrlDpVisualization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ctrlDpVisualization";
            Size = new Size(1033, 698);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpNotes;
        private FlowLayoutPanel flpState;
        private FlowLayoutPanel flpRuntime;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
