
using C1.Win.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGUIcsproj.Controls
{
    public partial class ctrlSortingHistogram : UserControl
    {
        public ctrlSortingHistogram(List<double> startingNumbers)
        {
            InitializeComponent();

            // Initialize histogram
            flexChart1.Series.Clear();
            Series series = new();

            // Setting the x axis
            series.BindingX = "Key";
            List<double> keys = new();
            for (int i = 0; i < startingNumbers.Count; i++)
                keys.Add(i);
            
            // Setting the histogram values
            series.SetData(keys.ToArray(), startingNumbers.ToArray());
            series.Binding = "Value";
            series.Name = "Histogram";
            flexChart1.Series.Add(series);
             
        }

        /// <summary>
        /// Used to update the histogram inside the sorting visualization screen
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void UpdateHistogram()
        {
            throw new NotImplementedException();
        }
    }
}
