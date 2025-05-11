using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit.Datastructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a node in a graph with a string value
    /// </summary>
    public class Node
    {
        public string Value { get; set; }

        public Node(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
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
        private double[,] adjacencyMatrix;
        private Dictionary<string, int> nodeToIndex;
        private List<Node> nodes;
        public Node Root { get; private set; }

        // Constant to represent infinity (no connection)
        private const double INFINITY = double.PositiveInfinity;

        public Graph()
        {
            adjacencyMatrix = new double[0, 0];
            nodeToIndex = new Dictionary<string, int>();
            nodes = new List<Node>();
        }

        /// <summary>
        /// Adds a new node to the graph and connects it to an existing node
        /// </summary>
        /// <param name="newNode">The new node to add</param>
        /// <param name="existingNode">The existing node to connect to</param>
        /// <param name="edgeCost">The cost of the edge between the nodes</param>
        public void AddNode(Node newNode, Node existingNode = null, double edgeCost = 1.0)
        {
            // Check if node already exists
            if (nodeToIndex.ContainsKey(newNode.Value))
            {
                throw new ArgumentException($"Node with value '{newNode.Value}' already exists in the graph");
            }

            // For the first node (no existing node to connect to)
            if (existingNode == null)
            {
                if (nodes.Count > 0)
                {
                    throw new ArgumentException("Existing node must be provided when adding to a non-empty graph");
                }

                // This is the first node - set as root
                ResizeMatrix(1);
                nodeToIndex[newNode.Value] = 0;
                nodes.Add(newNode);
                Root = newNode;
                return;
            }

            // Validate existing node
            if (!nodeToIndex.ContainsKey(existingNode.Value))
            {
                throw new ArgumentException($"Existing node '{existingNode.Value}' not found in the graph");
            }

            // Add the new node - resize matrix
            int newIndex = nodes.Count;
            int existingIndex = nodeToIndex[existingNode.Value];

            ResizeMatrix(nodes.Count + 1);

            // Add the node to collections
            nodeToIndex[newNode.Value] = newIndex;
            nodes.Add(newNode);

            // Set up the bidirectional edge
            adjacencyMatrix[newIndex, existingIndex] = edgeCost;
            adjacencyMatrix[existingIndex, newIndex] = edgeCost;

            // If this is the first node we're adding, set it as the root
            if (Root == null)
            {
                Root = newNode;
            }
        }

        /// <summary>
        /// Adds an edge between two existing nodes in the graph
        /// </summary>
        public void AddEdge(Node node1, Node node2, double edgeCost)
        {
            if (!nodeToIndex.ContainsKey(node1.Value) || !nodeToIndex.ContainsKey(node2.Value))
            {
                throw new ArgumentException("Both nodes must exist in the graph");
            }

            int index1 = nodeToIndex[node1.Value];
            int index2 = nodeToIndex[node2.Value];

            adjacencyMatrix[index1, index2] = edgeCost;
            adjacencyMatrix[index2, index1] = edgeCost; // For undirected graph
        }

        /// <summary>
        /// Gets the cost of the edge between two nodes
        /// </summary>
        /// <returns>The edge cost, or infinity if no edge exists</returns>
        public double GetEdgeCost(Node node1, Node node2)
        {
            if (!nodeToIndex.ContainsKey(node1.Value) || !nodeToIndex.ContainsKey(node2.Value))
            {
                return INFINITY;
            }

            int index1 = nodeToIndex[node1.Value];
            int index2 = nodeToIndex[node2.Value];

            return adjacencyMatrix[index1, index2];
        }

        /// <summary>
        /// Gets an adjacency list representation of the graph
        /// </summary>
        public Dictionary<Node, List<(Node, double)>> GetAdjacencyList()
        {
            var adjacencyList = new Dictionary<Node, List<(Node, double)>>();

            // Initialize empty lists for each node
            foreach (var node in nodes)
            {
                adjacencyList[node] = new List<(Node, double)>();
            }

            // Populate the adjacency list
            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = 0; j < nodes.Count; j++)
                {
                    if (i != j && adjacencyMatrix[i, j] != INFINITY)
                    {
                        adjacencyList[nodes[i]].Add((nodes[j], adjacencyMatrix[i, j]));
                    }
                }
            }

            return adjacencyList;
        }

        /// <summary>
        /// Generates a random graph with the specified number of nodes
        /// </summary>
        public static Graph GenerateRandomGraph(int nodeCount, double density = 0.5,
                                              double minCost = 1.0, double maxCost = 10.0)
        {
            if (nodeCount <= 0)
                throw new ArgumentException("Node count must be positive");

            var random = new Random();
            var graph = new Graph();

            // Create nodes with random values
            var firstNode = new Node($"Node_{random.Next(1000)}");
            graph.AddNode(firstNode);

            // Add remaining nodes, connecting each to a random existing node
            for (int i = 1; i < nodeCount; i++)
            {
                var newNode = new Node($"Node_{random.Next(1000)}");
                var existingNode = graph.nodes[random.Next(graph.nodes.Count)];
                double cost = random.NextDouble() * (maxCost - minCost) + minCost;

                graph.AddNode(newNode, existingNode, cost);
            }

            // Add random additional edges based on density
            for (int i = 0; i < nodeCount; i++)
            {
                for (int j = i + 1; j < nodeCount; j++)
                {
                    // Skip if there's already an edge
                    if (graph.adjacencyMatrix[i, j] != INFINITY)
                        continue;

                    // Add edge with probability based on density
                    if (random.NextDouble() < density)
                    {
                        double cost = random.NextDouble() * (maxCost - minCost) + minCost;
                        graph.adjacencyMatrix[i, j] = cost;
                        graph.adjacencyMatrix[j, i] = cost;
                    }
                }
            }

            return graph;
        }

        /// <summary>
        /// Resizes the adjacency matrix to accommodate more nodes
        /// </summary>
        private void ResizeMatrix(int newSize)
        {
            var newMatrix = new double[newSize, newSize];

            // Initialize with INFINITY
            for (int i = 0; i < newSize; i++)
            {
                for (int j = 0; j < newSize; j++)
                {
                    newMatrix[i, j] = INFINITY;
                }
                // No cost to self
                newMatrix[i, i] = 0;
            }

            // Copy existing values
            int oldSize = adjacencyMatrix.GetLength(0);
            for (int i = 0; i < oldSize; i++)
            {
                for (int j = 0; j < oldSize; j++)
                {
                    newMatrix[i, j] = adjacencyMatrix[i, j];
                }
            }

            adjacencyMatrix = newMatrix;
        }
    }
}
