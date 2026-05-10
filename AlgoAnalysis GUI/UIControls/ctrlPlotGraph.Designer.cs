namespace WinFormsApp1.Controls
{
    partial class ctrlPlotGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tableLayoutPanel1 = new TableLayoutPanel();
            chrtTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chrtTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1743126F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8256874F));
            tableLayoutPanel1.Controls.Add(chrtTime, 0, 0);
            tableLayoutPanel1.Controls.Add(chart2, 1, 0);
            tableLayoutPanel1.Controls.Add(chart3, 1, 1);
            tableLayoutPanel1.Controls.Add(chart4, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1090, 593);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // chrtTime
            // 
            chartArea5.Name = "ChartArea1";
            chrtTime.ChartAreas.Add(chartArea5);
            chrtTime.Dock = DockStyle.Fill;
            legend5.Name = "Legend1";
            chrtTime.Legends.Add(legend5);
            chrtTime.Location = new Point(3, 3);
            chrtTime.Name = "chrtTime";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chrtTime.Series.Add(series5);
            chrtTime.Size = new Size(530, 290);
            chrtTime.TabIndex = 0;
            chrtTime.Text = "chart1";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea6);
            chart2.Dock = DockStyle.Fill;
            legend6.Name = "Legend1";
            chart2.Legends.Add(legend6);
            chart2.Location = new Point(539, 3);
            chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chart2.Series.Add(series6);
            chart2.Size = new Size(548, 290);
            chart2.TabIndex = 1;
            chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea7.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea7);
            chart3.Dock = DockStyle.Fill;
            legend7.Name = "Legend1";
            chart3.Legends.Add(legend7);
            chart3.Location = new Point(539, 299);
            chart3.Name = "chart3";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            chart3.Series.Add(series7);
            chart3.Size = new Size(548, 291);
            chart3.TabIndex = 2;
            chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea8.Name = "ChartArea1";
            chart4.ChartAreas.Add(chartArea8);
            chart4.Dock = DockStyle.Fill;
            legend8.Name = "Legend1";
            chart4.Legends.Add(legend8);
            chart4.Location = new Point(3, 299);
            chart4.Name = "chart4";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            chart4.Series.Add(series8);
            chart4.Size = new Size(530, 291);
            chart4.TabIndex = 3;
            chart4.Text = "chart4";
            // 
            // ctrlPlotGraph
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ctrlPlotGraph";
            Size = new Size(1090, 593);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chrtTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}
