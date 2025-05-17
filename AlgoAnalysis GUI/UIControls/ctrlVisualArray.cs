using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGUIcsproj.Controls
{
    public partial class ctrlVisualArray : UserControl
    {


        public int CurrentSize = 0;
        public ctrlVisualArray()
        {
            InitializeComponent();
            numericUpDown1.Value = 10;
        }

        /// <summary>
        /// Initializes the chart with the given values
        /// </summary>
        /// <param name="values"></param>


        /// <summary>
        /// Updates the chart with new values
        /// </summary>
        /// <param name="values"></param>

        public void HighlightThreeIndex(int i1, int i2, int i3, Color color1, Color color2, Color color3)
        {

            flowLayoutPanel1.Controls[i1].BackColor = color1;
            flowLayoutPanel1.Controls[i2].BackColor = color2;
            flowLayoutPanel1.Controls[i3].BackColor = color3;
            Task.Delay(Convert.ToInt16(trackBar1.Value)).Wait();
            flowLayoutPanel1.Controls[i1].BackColor = Color.White;
            flowLayoutPanel1.Controls[i2].BackColor = Color.White;
            flowLayoutPanel1.Controls[i3].BackColor = Color.White;
        }
        public void HighlightCurrentIndex(int index, Color color)
        {
            flowLayoutPanel1.Controls[index].BackColor = color;
            Task.Delay(800).Wait();
            flowLayoutPanel1.Controls[index].BackColor = Color.White;
        }
        private void ctrlVisualArray_Load(object sender, EventArgs e)
        {

        }
        public string GetValue(int index)
        {
            return flowLayoutPanel1.Controls[index].Text;
        }
        private void btnGenerateArray_Click(object sender, EventArgs e)
        {

        }
        private Random random = new Random();
        private int GenerateRandomNumber()
        {
            return random.Next(1, 1001);
        }
        public static List<Int16> GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            List<Int16> array = new List<Int16>();
            for (int i = 0; i < size; i++)
            {
                array.Add((Int16)random.Next(minValue, maxValue));
            }
            return array;
        }

        private void btnGenerateArray_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Int16> SortedArray = GenerateRandomArray(Convert.ToInt16(numericUpDown1.Value), 1, 1001);
            SortedArray.Sort();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                Button btn = new Button();
                btn.Text = SortedArray[i].ToString();
                btn.Size = new Size(80, 80);
                btn.UseVisualStyleBackColor = true;
                btn.Enabled = false;
                flowLayoutPanel1.Controls.Add(btn);
            }
            CurrentSize = ((int)numericUpDown1.Value);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblDelayValue.Text = trackBar1.Value.ToString();
        }
    }
}
