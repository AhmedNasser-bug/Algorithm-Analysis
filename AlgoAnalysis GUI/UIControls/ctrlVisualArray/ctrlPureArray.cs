using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIControls.ctrlVisualArray
{
    public partial class ctrlPureArray : UserControl
    {
        public int CurrentSize = 0;
        public List<Int16> CurrentArray;
        public ctrlPureArray()
        {
            InitializeComponent();
            List<Int16> SortedArray = GenerateRandomArray(20, 1, 1001);
            SortedArray.Sort();
            foreach (Int16 i in SortedArray)
            {
                Button curItem = new Button();
                curItem.Text = i.ToString();
                curItem.BackColor = SystemColors.Control;
                curItem.MinimumSize = new Size(60, 60);
                curItem.AutoSize = true;
                curItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                flowLayoutPanel1.Controls.Add(curItem);
            }

            CurrentSize = 20;
            CurrentArray = SortedArray;
        }

        public void ChangeArray(int size)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Int16> newArr = GenerateRandomArray(size, 1, 1001);
            
            foreach (Int16 i in newArr)
            {
                Button curItem = new Button();
                curItem.Text = i.ToString();
                curItem.BackColor = SystemColors.Control;
                curItem.MinimumSize = new Size(40, 40);
                curItem.MaximumSize = new Size(80, 80);
                curItem.AutoSize = true;
                curItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                flowLayoutPanel1.Controls.Add(curItem);
            }


            CurrentSize = size;
            CurrentArray = newArr;
        }

        private static List<Int16> GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            List<Int16> array = new List<Int16>();
            for (int i = 0; i < size; i++)
            {
                array.Add((Int16)random.Next(minValue, maxValue));
            }
            return array;
        }

        public string GetValue(int index)
        {
            /*
            if (index < 0 || index >= CurrentSize)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            */
            return flowLayoutPanel1.Controls[index].Text;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
