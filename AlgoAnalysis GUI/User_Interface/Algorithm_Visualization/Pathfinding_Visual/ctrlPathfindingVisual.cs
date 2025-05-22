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
        public ctrlPathfindingVisual()
        {
            InitializeComponent();
            Pathfinding.OnNodeVisited += Pathfinding_OnNodeVisited;
            Pathfinding.OnEdgeVisited += Pathfinding_OnEdgeVisited;
            Pathfinding.OnGraphState += Pathfinding_OnGraphState;
            Pathfinding.OnMemoryNote += Pathfinding_OnMemoryNote;
            Pathfinding.OnSendNote += Pathfinding_OnSendNote;

        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            ctrlAlgorithmVisualization algorithmVisualization = new ctrlAlgorithmVisualization();
            frmMainMenu.globalForm?.ChangeControl(algorithmVisualization);
        }

        private void btnFloydWarshall_Click(object sender, EventArgs e)
        {
            FormsUtils.DisableAllButtons(this, btnCancel.Tag);
            Metrics metrics = Pathfinding.FloydWarshall(ctrlGraphVisualizer1.currentGraph);
            ctrlMetricsBox1.SetMetrics(metrics);
            FormsUtils.EnableAllButtons(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormsUtils.DisableAllButtons(this, btnCancel.Tag);
            Node root = ctrlGraphVisualizer1.currentGraph.nodes[0];
            Node goal = ctrlGraphVisualizer1.currentGraph.nodes.Last();
            Metrics metrics = Pathfinding.BellmanFord(ctrlGraphVisualizer1.currentGraph, root, goal);
            ctrlMetricsBox1.SetMetrics(metrics);
            FormsUtils.EnableAllButtons(this);
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            FormsUtils.DisableAllButtons(this, btnCancel.Tag);


            Node root = ctrlGraphVisualizer1.currentGraph.nodes[0];
            Node goal = ctrlGraphVisualizer1.currentGraph.nodes.Last();
            Metrics metrics = Pathfinding.DijkstraWithPriorityQueue(ctrlGraphVisualizer1.currentGraph, root, goal);
            ctrlMetricsBox1.SetMetrics(metrics);

            FormsUtils.EnableAllButtons(this);

        }


        // ======================================================================= CUSTOM EVENTS

        private void Pathfinding_OnNodeVisited(object sender, Node ProcessedNode, PathfindingStateDictionary e)
        {
            ctrlGraphVisualizer1.HighlightVertex(ProcessedNode);
        }

        private void Pathfinding_OnEdgeVisited(object sender, Node edgeNode1, Node edgeNode2)
        {
            ctrlGraphVisualizer1.HighlightEdge(edgeNode1, edgeNode2);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMainMenu.globalForm?.ChangeControl(new ctrlPathfindingVisual());
        }

        private void Pathfinding_OnSendNote(object sender, string note)
        {
            ctrlDpVisualization1.AddNote(note);
        }

        private void Pathfinding_OnMemoryNote(object sender, string HitState)
        {
            ctrlDpVisualization1.AddMemoryStateNote(HitState);
        }

        private void Pathfinding_OnGraphState(object sender, string runtimeNote)
        {
            ctrlDpVisualization1.AddRuntimeNote(runtimeNote);
        }


    }
}
