using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.Controls;
using MainGUIcsproj.Algorithm_Visualization.Sorting_Visual;
using MainGUIcsproj.Algorithm_Visualization.Pathfinding_Visual;
using MainGUIcsproj.Algorithm_Visualization.Greedy_Visual;
using MainGUIcsproj.Algorithm_Visualization.Searching_Visual;
using MainGUIcsproj.Algorithm_Visualization.DynamicProgrammin_Visual;

namespace MainGUIcsproj.Algorithm_Visualization
{
    public partial class ctrlAlgorithmVisualization : UserControl
    {

        public ctrlAlgorithmVisualization()
        {
            InitializeComponent();
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            ctrlSortingVisual sortingVisual = new ctrlSortingVisual();
            frmMainMenu.globalForm.ChangeControl(sortingVisual);
        }

        private void ctrlAlgorithmVisualization_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ctrlMainMenu mainMenu = new ctrlMainMenu();
            frmMainMenu.globalForm?.ChangeControl(mainMenu);
        }


        private void btnGreedy_Click(object sender, EventArgs e)
        {
            ctrlGreedyVisual greedyVisual = new ctrlGreedyVisual();
            frmMainMenu.globalForm.ChangeControl(greedyVisual);
        }

        private void btnSearching_Click(object sender, EventArgs e)
        {
            ctrlSearchingVisual searchingVisual = new ctrlSearchingVisual();
            frmMainMenu.globalForm.ChangeControl(searchingVisual);
        }

        private void btnDynamicProgramming_Click(object sender, EventArgs e)
        {
            ctrlDynamicProgramming visual = new ctrlDynamicProgramming();
            frmMainMenu.globalForm.ChangeControl(visual);
        }

        private void btnPathfinding_Click(object sender, EventArgs e)
        {
            ctrlPathfindingVisual pathfindingVisual = new ctrlPathfindingVisual();
            frmMainMenu.globalForm.ChangeControl(pathfindingVisual);
        }
    }
}
