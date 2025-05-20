using Algorithms_Unit.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit.Datastructures
{
    public enum GraphTypes { Cyclic, Acyclic, Axis }

    /// <summary>
    /// Represents a node in a graph with a string value
    /// </summary>
    public class Node
    {
        public (int x, int y) Value { get; set; }
        public HashSet<Node> Neighbors { get; set; } = []; // For storing neighbors of the node

        public Node((int x, int y) value)
        {
            Value = value;
        }

        public void AddEdge(Node node)
        {
            if (node == null)
                throw new ArgumentNullException(nameof(node));
            Neighbors.Add(node);
            if(!node.Neighbors.Contains(this))node.AddEdge(this);
        }

        public bool makesCycle(Node potentialNode)
        {
            HashSet<Node> visited = [this];
            Stack<Node> nodes = [];


            nodes.Push(this);

            while(nodes.Count > 0)
            {
                Node current = nodes.Pop();

                foreach(Node nei in current.Neighbors)
                {
                    if (nei.Equals(potentialNode))
                    {
                        return true;
                    }
                    nodes.Push(nei);
                    visited.Add(nei);
                }
            }

            return false;

        }

        public override string ToString()
        {
            return $"({Value.x}, {Value.y})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Node other)
                return Value == other.Value;
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    




    /// <summary>
    /// Represents a weighted graph using an adjacency matrix
    /// </summary>
    public class Graph
    {
        public List<Node> nodes;
        public Node? Root { get; private set; }
        public int MaxXY { get; private set; }
        public GraphTypes GraphType { get; private set; }

        // Constant to represent infinity (no connection)
        private const double INFINITY = double.PositiveInfinity;
        private HashSet<Node> currentVertices;
        public Graph(GraphTypes type)
        {
            nodes = new List<Node>();
            GraphType = type;
            currentVertices = [];

        }

        /// <summary>
        /// Adds a new node to the graph and connects it to an existing node
        /// </summary>
        /// <param name="newNode">The new node to add</param>
        /// <param name="existingNode">The existing node to connect to</param>
        /// <param name="edgeCost">The cost of the edge between the nodes</param>
        public void AddNode(Node newNode, Node? neighbor = null)
        {
            
            
            // If this is the first node we're adding, set it as the root
            if (Root == null)
            {
                Root = newNode;
            }

            switch (GraphType)
            {
                case GraphTypes.Cyclic:
                    if (neighbor != null)
                    {
                        newNode.AddEdge(neighbor);
                    }
                    break;
                case GraphTypes.Acyclic:
                    if (neighbor != null)
                    {
                        if (newNode.makesCycle(neighbor))
                        {
                            throw new InvalidOperationException($"The new Edge between {newNode.ToString()} and {neighbor.ToString()} makes a cycle in an Acyclic Graph");
                        };
                        newNode.AddEdge(neighbor);
                    }
                    break;
                default:
                    break;
            }

            if (neighbor != null && !currentVertices.Contains(neighbor)) 
            { 
                nodes.Add(neighbor);
                currentVertices.Add(neighbor);

                MaxXY = Math.Max(MaxXY, neighbor.Value.y);
                MaxXY = Math.Max(MaxXY, neighbor.Value.x);
            }
            if (!currentVertices.Contains(newNode)) 
            {
                nodes.Add(newNode);
                currentVertices.Add(newNode);

                MaxXY = Math.Max(MaxXY, newNode.Value.y);
                MaxXY = Math.Max(MaxXY, newNode.Value.x);
            }
        }

        /// <summary>
        /// Gets the cost of the edge between two nodes
        /// </summary>
        /// <returns>The edge cost, or infinity if no edge exists</returns>
        public double GetEdgeCost(Node node1, Node node2)
        {
            if (!node1.Neighbors.Contains(node2) && GraphType != GraphTypes.Axis)
            {
                return INFINITY;
            }

            return Math.Sqrt(Math.Pow(node1.Value.x - node2.Value.x, 2) + Math.Pow(node2.Value.y + node1.Value.y, 2));
        }

        /// <summary>
        /// Gets an adjacency list representation of the graph
        /// </summary>
        public Dictionary<Node, List<(Node, double)>> GetAdjacencyList()
        {
            var adjacencyList = new Dictionary<Node, List<(Node, double)>>(); // For each node , store the node's neighbors and their costs

            // Initialize empty lists for each node
            foreach (var node in nodes)
            {
                adjacencyList[node] = new List<(Node, double)>();
            }

            // Populate the adjacency list
            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = i+1; j < nodes.Count; j++)
                {
                    if (nodes[i].Neighbors.Contains(nodes[j]))
                    {
                        adjacencyList[nodes[i]].Add((nodes[j], GetEdgeCost(nodes[i], nodes[j])));
                    }
                }
            }

            return adjacencyList;
        }

    }


}
