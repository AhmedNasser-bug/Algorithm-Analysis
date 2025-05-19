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
            for (int i = 0; i < 20; i++)
            {
                flowLayoutPanel1.Controls[i].Text = SortedArray[i].ToString();
                flowLayoutPanel1.Controls[i].Enabled = false;
            }
            CurrentSize = 20;
            CurrentArray = SortedArray;
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
