using Algorithms_Unit.Datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    public class Pathfinding
    {
        public delegate void GraphNodeVisitHandler(object sender, Node ProcessedNode, PathfindingStateDictionary e);
        public delegate void GraphEdgeVisitHandler(object sender, Node edgeNode1, Node edgeNode2);
        public static event GraphNodeVisitHandler? OnNodeVisited;
        public static event GraphEdgeVisitHandler? OnEdgeVisited;


        /// <summary>
        /// Call on each iteration of each algorithm with the exact state of all tracked variables
        /// </summary>
        public static void SendNode(Node ProcessedNode, Dictionary<String, object>? ProblemSpecificArgs, object sender = null)
        {
            OnNodeVisited?.Invoke(sender, ProcessedNode, new PathfindingStateDictionary(ProcessedNode, ProblemSpecificArgs));
        }

        public static void SendEdge(Node edgeNode1, Node edgeNode2, object sender = null)
        {
            OnEdgeVisited?.Invoke(sender, edgeNode1, edgeNode2);
        }

        public static void BFS(Graph graph, object sender = null)
        {
            // Node highlight test
            foreach (Node node in graph.nodes)
            {
                SendNode(node, null, sender);
            }

            foreach (Node node in graph.nodes)
            {
                foreach (Node nei in node.Neighbors)
                {
                    SendEdge(node, nei, sender);
                }

            }
        }

        /*
        TODO: 
            - Dijkstra using Heap
            - Bellman Ford
            - Floyd Warshall
            
        Input: 
            - Graph object

        Output: 
            - Metrics object
            
        Notes:
            - Each iteration/node processing call OnPathfindingIteration() with the processed node as an argument
            -All methods must have a clone that does not fire the event 
         

         */
        //public static Metrics DijkstraHeap(Graph graph, Node start, Node end, object sender = null);
        //public static Metrics BellmanFord(Graph graph, Node start, Node end, object sender = null);
        //public static Metrics FloydWarshal(graph, object sender = null);
    }
}