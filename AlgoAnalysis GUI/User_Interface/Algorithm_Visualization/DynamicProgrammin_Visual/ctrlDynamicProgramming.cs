using Algorithms_Unit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIControls.ctrlVisualArray;
using WinFormsApp1;

namespace MainGUIcsproj.Algorithm_Visualization.DynamicProgrammin_Visual
{
    public partial class ctrlDynamicProgramming : UserControl
    {
        public ctrlDynamicProgramming()
        {
            InitializeComponent();

            DynamicProgramming.OnChoiceChange += DynamicProgramming_OnChoiceChange;
            DynamicProgramming.OnCacheHit += DynamicProgramming_OnCacheHit;
            DynamicProgramming.OnCalculation += DynamicProgramming_OnCalculation;
        }

        private void DynamicProgramming_OnCalculation(object sender, params List<int> indices)
        {
            throw new NotImplementedException();
        }

        private void DynamicProgramming_OnCacheHit(object sender, string HitState)
        {
            throw new NotImplementedException();
        }

        private void DynamicProgramming_OnChoiceChange(object sender, DynamicProgrammingStateDictionary e)
        {
            // Modify props accordingy
        }




        private void btnInsertionSort_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ctrlAlgorithmVisualization algorithmVisualization = new ctrlAlgorithmVisualization();
            frmMainMenu.globalForm?.ChangeControl(algorithmVisualization);
        }

        ctrlPureArray PureArray;
        private void btnMemoFib_Click(object sender, EventArgs e)
        {
            DynamicProgramming.FiboMemoized(10);

            PureArray = new ctrlPureArray();
            ctrlDpVisualization1.setEvent1(PureArray);
        }
    }
}
