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
using WinFormsApp1;

namespace MainGUIcsproj.Algorithm_Visualization.Greedy_Visual
{
    public partial class ctrlGreedyVisual : UserControl
    {
        public ctrlGreedyVisual()
        {
            InitializeComponent();

            Greedy.OnGreedyStateChange += Greedy_OnGreedyStateChange;
            Greedy.OnMemoryNote += Greedy_OnMemoryNote;
            Greedy.OnSendNote += Greedy_OnSendNote;
        }

        private void Greedy_OnSendNote(object sender, string note)
        {
            ctrlDpVisualization1.AddNote(note);
        }

        private void Greedy_OnMemoryNote(object sender, string HitState)
        {
            ctrlDpVisualization1.AddMemoryStateNote(HitState);
        }

        private void Greedy_OnGreedyStateChange(object sender, GreedyStateDictionary e)
        {
           ctrlDpVisualization1.AddRuntimeNote(e.StateRepr);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ctrlAlgorithmVisualization algorithmVisualization = new ctrlAlgorithmVisualization();
            frmMainMenu.globalForm?.ChangeControl(algorithmVisualization);
        }

        private void btnActivitySelection_Click(object sender, EventArgs e)
        {
            // Activities with start and finish times
            int[] start = { 1, 3, 0, 5, 8, 5 };
            int[] finish = { 2, 4, 6, 7, 9, 9 };


            Metrics metrics = Greedy.ActivitySelectionProblem(start, finish);
            ctrlMetricsBox1.SetMetrics(metrics);
        }

        private void btncCoinChange_Click(object sender, EventArgs e)
        {
            // Number of ways to make sum=7 with coins [1,2,5]
            int[] coins = { 1, 2, 5 };
            int sum = 7;

            Metrics metrics = Greedy.CoinChangeProblem(coins, sum);
            ctrlMetricsBox1.SetMetrics(metrics);
        }

        private void btnHuffmanCoding_Click(object sender, EventArgs e)
        {
            // String with character frequencies
            string s = "abcdef";
            int[] freq = { 5, 9, 12, 13, 16, 45 };

            Greedy.HuffmanCoding(s, freq);
        }

        private void btnKruskal_Click(object sender, EventArgs e)
        {
            // Graph with 4 vertices and 5 edges
            int V = 4;
            int[][] edges = new int[][] {
    new int[] { 0, 1, 10 },  // edge from 0 to 1 with weight 10
    new int[] { 0, 2, 6 },   // edge from 0 to 2 with weight 6
    new int[] { 0, 3, 5 },   // edge from 0 to 3 with weight 5
    new int[] { 1, 3, 15 },  // edge from 1 to 3 with weight 15
    new int[] { 2, 3, 4 }    // edge from 2 to 3 with weight 4
};

           Metrics metrics = Greedy.KruskalsMST(V, edges);
            ctrlMetricsBox1.SetMetrics(metrics);
        }
    }
}
