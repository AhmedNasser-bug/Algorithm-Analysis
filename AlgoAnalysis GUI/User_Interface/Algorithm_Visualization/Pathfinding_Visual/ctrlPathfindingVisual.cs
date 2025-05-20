using Algorithms_Unit;
using Algorithms_Unit.Datastructures;
using Algorithms_Unit.Utils;
using MainGUIcsproj.Utils;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace MainGUIcsproj.Algorithm_Visualization.Pathfinding_Visual
{
    public partial class ctrlPathfindingVisual : UserControl
    {
        bool LastCallDone = false;
        CancellationToken cancellationToken = new CancellationToken();
        public ctrlPathfindingVisual()
        {
            InitializeComponent();
            Pathfinding.OnNodeVisited += Pathfinding_OnNodeVisited;
            Pathfinding.OnEdgeVisited += Pathfinding_OnEdgeVisited;

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            ctrlAlgorithmVisualization algorithmVisualization = new ctrlAlgorithmVisualization();
            frmMainMenu.globalForm?.ChangeControl(algorithmVisualization);
        }
        


        private async void btnDijkstra_Click(object sender, EventArgs e)
        {
            FormsUtils.DisableAllButtons(this, btnCancel.Tag);

            await Task.Run(() => Pathfinding.BFS(ctrlGraphVisualizer1.currentGraph)); 
            
            FormsUtils.EnableAllButtons(this);
            
        }


        // ======================================================================= CUSTOM EVENTS

        private void Pathfinding_OnNodeVisited(Node ProcessedNode, PathfindingStateDictionary e)
        {
            ctrlGraphVisualizer1.HighlightVertex(ProcessedNode);
        }

        private void Pathfinding_OnEdgeVisited(Node edgeNode1, Node edgeNode2)
        {
            ctrlGraphVisualizer1.HighlightEdge(edgeNode1, edgeNode2);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMainMenu.globalForm?.ChangeControl(new ctrlPathfindingVisual());
        }
    }
}
