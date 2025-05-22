using Algorithms_Unit.Datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Algorithms_Unit.Greedy;

namespace Algorithms_Unit
{
    public class Pathfinding
    {
        public delegate void GraphNodeVisitHandler(object sender, Node ProcessedNode, PathfindingStateDictionary e);
        public delegate void GraphEdgeVisitHandler(object sender, Node edgeNode1, Node edgeNode2);
        public delegate void GraphRunTimeNote(object sender,string runtimeNote);
        public static event GraphRunTimeNote? OnGraphState;
        public static event GraphNodeVisitHandler? OnNodeVisited;
        public static event GraphEdgeVisitHandler? OnEdgeVisited;
        public static event MemoryNoteEventHandler? OnMemoryNote;
        public static event SendNoteEventHandler? OnSendNote;


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

        /// <summary>
        /// Call on each iteration of each algorithm with the exact state of all tracked variables
        /// </summary>
        public static void SendRuntimeNote(string stateNote, Dictionary<string, object> problemSpec, object sender = null)
        {
            OnGraphState?.Invoke(sender,stateNote);
        }

        /// <summary>
        /// Happens on accessing the memo of a memoized solution of a dynamic programming problem
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Hit"></param>
        /// <param name="sender"></param>
        public static void SendMemoryNote(string memoryState, object sender = null)
        {
            OnMemoryNote?.Invoke(sender, memoryState);
        }

        /// <summary>
        /// Sends indices to event subscribers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="indices"></param>
        public static void SendNote(string note, object sender = null)
        {
            OnSendNote?.Invoke(sender, note);
        }




        public static Metrics DijkstraWithPriorityQueue(Graph graph, Node start, Node end, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            metrics.TotalNumbersOfSteps++;

            SendNote($"Starting Dijkstra's algorithm from {start} to {end}", sender);

            // Initialize distances dictionary and previous nodes for path reconstruction
            var distances = new Dictionary<Node, double>();
            var previous = new Dictionary<Node, Node>();
            var priorityQueue = new PriorityQueue<Node, double>();

            SendMemoryNote("Creating distances dictionary, previous nodes tracking and priority queue", sender);
            metrics.TotalNumbersOfSteps++;

            // Initialize all nodes with infinity distance except start node
            foreach (var node in graph.nodes)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps++;
                metrics.TotalNumbersOfArrayAccesses++;

                if (node.Equals(start))
                {
                    distances[node] = 0;
                    SendRuntimeNote($"Setting initial distance", new Dictionary<string, object> {
                { "Node", start.ToString() },
                { "Distance", 0 }
            }, sender);
                }
                else
                {
                    distances[node] = double.PositiveInfinity;
                    SendRuntimeNote($"Setting initial distance", new Dictionary<string, object> {
                { "Node", node.ToString() },
                { "Distance", "Infinity" }
            }, sender);
                }
            }

            // Add start node to priority queue
            priorityQueue.Enqueue(start, 0);
            SendMemoryNote($"Added start node {start} to priority queue with distance 0", sender);

            // Main Dijkstra algorithm loop
            while (priorityQueue.Count > 0)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfComparisons++;

                // Get node with smallest distance
                Node current = priorityQueue.Dequeue();
                metrics.TotalNumbersOfArrayAccesses++;

                SendNode(current, new Dictionary<string, object> { { "Distance", distances[current] } }, sender);
                SendRuntimeNote($"Processing node", new Dictionary<string, object> {
            { "Current", current.ToString() },
            { "Distance", distances[current] }
        }, sender);

                // If we reached the end node, we can stop
                metrics.TotalNumbersOfComparisons++;
                if (current.Equals(end))
                {
                    SendNote($"Reached destination node {end} with distance {distances[current]}", sender);
                    break;
                }

                // Process all neighbors
                foreach (var neighbor in current.Neighbors)
                {
                    metrics.TotalNumbersOfIterations++;
                    metrics.TotalNumbersOfSteps += 2;

                    SendEdge(current, neighbor, sender);

                    // Calculate new potential distance
                    double edgeCost = graph.GetEdgeCost(current, neighbor);
                    double newDistance = distances[current] + edgeCost;
                    metrics.TotalNumbersOfArrayAccesses += 2;

                    SendRuntimeNote($"Examining edge", new Dictionary<string, object> {
                { "From", current.ToString() },
                { "To", neighbor.ToString() },
                { "EdgeCost", edgeCost },
                { "NewDistance", newDistance },
                { "CurrentDistance", distances[neighbor] }
            }, sender);

                    // If we found a shorter path, update it
                    metrics.TotalNumbersOfComparisons++;
                    if (newDistance < distances[neighbor])
                    {
                        metrics.TotalNumbersOfSteps += 2;
                        metrics.TotalNumbersOfArrayAccesses += 2;

                        // Update distance and previous node
                        distances[neighbor] = newDistance;
                        previous[neighbor] = current;

                        SendMemoryNote($"Updated distance to {neighbor} to {newDistance} via {current}", sender);
                        SendRuntimeNote($"Found shorter path", new Dictionary<string, object> {
                    { "Node", neighbor.ToString() },
                    { "NewDistance", newDistance },
                    { "Via", current.ToString() }
                }, sender);

                        // Add to priority queue
                        priorityQueue.Enqueue(neighbor, newDistance);
                        SendMemoryNote($"Added {neighbor} to priority queue with priority {newDistance}", sender);
                    }
                }
            }

            // Reconstruct path if end was reached
            metrics.TotalNumbersOfComparisons++;
            if (distances.ContainsKey(end) && distances[end] != double.PositiveInfinity)
            {
                SendNote($"Path found from {start} to {end} with total distance {distances[end]}", sender);

                // Reconstruct and display path
                var path = new List<Node>();
                Node current = end;

                SendMemoryNote("Creating path list for reconstruction", sender);

                while (!current.Equals(start))
                {
                    metrics.TotalNumbersOfIterations++;
                    metrics.TotalNumbersOfSteps++;

                    path.Add(current);
                    current = previous[current];
                    metrics.TotalNumbersOfArrayAccesses++;

                    SendRuntimeNote($"Path reconstruction", new Dictionary<string, object> {
                { "Current", current.ToString() }
            }, sender);
                }

                path.Add(start);
                path.Reverse();

                SendMemoryNote("Path reconstruction complete", sender);
                SendNote($"Final path: {string.Join(" -> ", path)}", sender);
            }
            else
            {
                SendNote($"No path exists from {start} to {end}", sender);
            }

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
        }

        public static Metrics BellmanFord(Graph graph, Node start, Node end, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            metrics.TotalNumbersOfSteps++;

            SendNote($"Starting Bellman-Ford algorithm from {start} to {end}", sender);

            // Initialize distances and predecessor tracking
            var distances = new Dictionary<Node, double>();
            var predecessor = new Dictionary<Node, Node>();

            SendMemoryNote("Creating distances dictionary and predecessor tracking", sender);
            metrics.TotalNumbersOfSteps++;

            // Initialize all nodes with infinity distance except start node
            foreach (var node in graph.nodes)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps++;
                metrics.TotalNumbersOfArrayAccesses++;

                if (node.Equals(start))
                {
                    distances[node] = 0;
                    SendRuntimeNote($"Setting initial distance", new Dictionary<string, object> {
                { "Node", start.ToString() },
                { "Distance", 0 }
            }, sender);
                }
                else
                {
                    distances[node] = double.PositiveInfinity;
                    SendRuntimeNote($"Setting initial distance", new Dictionary<string, object> {
                { "Node", node.ToString() },
                { "Distance", "Infinity" }
            }, sender);
                }
            }

            // Extract all edges from the graph
            var edges = new List<(Node source, Node target, double weight)>();
            SendMemoryNote("Creating list to store all edges", sender);

            foreach (var node in graph.nodes)
            {
                metrics.TotalNumbersOfIterations++;

                foreach (var neighbor in node.Neighbors)
                {
                    metrics.TotalNumbersOfIterations++;
                    metrics.TotalNumbersOfSteps++;

                    double weight = graph.GetEdgeCost(node, neighbor);
                    edges.Add((node, neighbor, weight));

                    SendRuntimeNote($"Adding edge to list", new Dictionary<string, object> {
                { "From", node.ToString() },
                { "To", neighbor.ToString() },
                { "Weight", weight }
            }, sender);
                }
            }

            SendMemoryNote($"Created edge list with {edges.Count} edges", sender);

            // Main Bellman-Ford algorithm: relax edges |V|-1 times
            int vertexCount = graph.nodes.Count;
            SendNote($"Starting relaxation phase with {vertexCount - 1} iterations", sender);

            for (int i = 0; i < vertexCount - 1; i++)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps++;

                SendRuntimeNote($"Starting relaxation iteration", new Dictionary<string, object> {
            { "Iteration", i+1 },
            { "MaxIterations", vertexCount-1 }
        }, sender);

                bool anyUpdate = false; // To allow early termination if no changes

                foreach (var (source, target, weight) in edges)
                {
                    metrics.TotalNumbersOfIterations++;
                    metrics.TotalNumbersOfSteps += 2;
                    metrics.TotalNumbersOfArrayAccesses += 2;

                    SendEdge(source, target, sender);

                    // Skip if source distance is still infinity
                    metrics.TotalNumbersOfComparisons++;
                    if (distances[source] == double.PositiveInfinity)
                    {
                        SendRuntimeNote($"Skipping edge", new Dictionary<string, object> {
                    { "From", source.ToString() },
                    { "To", target.ToString() },
                    { "Reason", "Source distance is infinity" }
                }, sender);
                        continue;
                    }

                    // Try to relax the edge
                    double newDistance = distances[source] + weight;
                    metrics.TotalNumbersOfComparisons++;

                    SendRuntimeNote($"Examining edge", new Dictionary<string, object> {
                { "From", source.ToString() },
                { "To", target.ToString() },
                { "EdgeWeight", weight },
                { "NewDistance", newDistance },
                { "CurrentDistance", distances[target] }
            }, sender);

                    if (newDistance < distances[target])
                    {
                        metrics.TotalNumbersOfSteps += 2;
                        metrics.TotalNumbersOfArrayAccesses += 2;

                        distances[target] = newDistance;
                        predecessor[target] = source;
                        anyUpdate = true;

                        SendNode(target, new Dictionary<string, object> {
                    { "Distance", newDistance },
                    { "Via", source.ToString() }
                }, sender);

                        SendMemoryNote($"Updated distance to {target} to {newDistance} via {source}", sender);
                    }
                }

                // If no updates were made in this iteration, we can stop early
                if (!anyUpdate)
                {
                    SendNote($"No distance updates in iteration {i + 1}, stopping early", sender);
                    break;
                }
            }

            // Check for negative weight cycles
            SendNote("Checking for negative weight cycles", sender);
            bool hasNegativeCycle = false;

            foreach (var (source, target, weight) in edges)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps += 2;
                metrics.TotalNumbersOfArrayAccesses += 2;
                metrics.TotalNumbersOfComparisons += 2;

                if (distances[source] != double.PositiveInfinity && distances[source] + weight < distances[target])
                {
                    hasNegativeCycle = true;
                    SendNote($"Negative weight cycle detected involving edge from {source} to {target}", sender);
                    break;
                }
            }

            if (hasNegativeCycle)
            {
                SendNote("Graph contains negative weight cycle. Shortest path not defined.", sender);
            }
            else
            {
                // Check if end is reachable
                metrics.TotalNumbersOfComparisons++;
                if (distances.ContainsKey(end) && distances[end] != double.PositiveInfinity)
                {
                    SendNote($"Path found from {start} to {end} with total distance {distances[end]}", sender);

                    // Reconstruct and display path
                    var path = new List<Node>();
                    Node current = end;

                    SendMemoryNote("Creating path list for reconstruction", sender);

                    while (!current.Equals(start))
                    {
                        metrics.TotalNumbersOfIterations++;
                        metrics.TotalNumbersOfSteps++;

                        path.Add(current);
                        current = predecessor[current];
                        metrics.TotalNumbersOfArrayAccesses++;

                        SendRuntimeNote($"Path reconstruction", new Dictionary<string, object> {
                    { "Current", current.ToString() }
                }, sender);
                    }

                    path.Add(start);
                    path.Reverse();

                    SendMemoryNote("Path reconstruction complete", sender);
                    SendNote($"Final path: {string.Join(" -> ", path)}", sender);
                }
                else
                {
                    SendNote($"No path exists from {start} to {end}", sender);
                }
            }

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
        }


        public static Metrics FloydWarshall(Graph graph, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            metrics.TotalNumbersOfSteps++;

            SendNote("Starting Floyd-Warshall algorithm for all-pairs shortest paths", sender);

            int n = graph.nodes.Count;
            var nodes = graph.nodes;

            // Create distance matrix and initialize
            double[,] dist = new double[n, n];
            Node[,] next = new Node[n, n]; // For path reconstruction

            SendMemoryNote($"Creating {n}x{n} distance matrix and path reconstruction matrix", sender);
            metrics.TotalNumbersOfSteps++;

            // Initialize distance matrix
            for (int i = 0; i < n; i++)
            {
                metrics.TotalNumbersOfIterations++;

                for (int j = 0; j < n; j++)
                {
                    metrics.TotalNumbersOfIterations++;
                    metrics.TotalNumbersOfSteps++;
                    metrics.TotalNumbersOfArrayAccesses += 2;

                    if (i == j)
                    {
                        dist[i, j] = 0; // Distance to self is 0
                        SendRuntimeNote($"Setting initial distance", new Dictionary<string, object> {
                    { "From", nodes[i].ToString() },
                    { "To", nodes[j].ToString() },
                    { "Distance", 0 },
                    { "Reason", "Same node" }
                }, sender);
                    }
                    else if (nodes[i].Neighbors.Contains(nodes[j]))
                    {
                        dist[i, j] = graph.GetEdgeCost(nodes[i], nodes[j]);
                        next[i, j] = nodes[j]; // Direct path

                        SendEdge(nodes[i], nodes[j], sender);
                        SendRuntimeNote($"Setting initial distance", new Dictionary<string, object> {
                    { "From", nodes[i].ToString() },
                    { "To", nodes[j].ToString() },
                    { "Distance", dist[i, j] },
                    { "Reason", "Direct edge" }
                }, sender);
                    }
                    else
                    {
                        dist[i, j] = double.PositiveInfinity;
                        SendRuntimeNote($"Setting initial distance", new Dictionary<string, object> {
                    { "From", nodes[i].ToString() },
                    { "To", nodes[j].ToString() },
                    { "Distance", "Infinity" },
                    { "Reason", "No direct edge" }
                }, sender);
                    }
                }
            }

            SendMemoryNote("Distance matrix initialized", sender);
            SendNote("Starting main Floyd-Warshall algorithm loop", sender);

            // Main Floyd-Warshall algorithm
            for (int k = 0; k < n; k++)
            {
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps++;

                SendNode(nodes[k], new Dictionary<string, object> { { "Role", "Intermediate node" } }, sender);
                SendRuntimeNote($"Considering paths through intermediate node", new Dictionary<string, object> {
            { "Intermediate", nodes[k].ToString() }
        }, sender);

                for (int i = 0; i < n; i++)
                {
                    metrics.TotalNumbersOfIterations++;

                    for (int j = 0; j < n; j++)
                    {
                        metrics.TotalNumbersOfIterations++;
                        metrics.TotalNumbersOfSteps += 2;
                        metrics.TotalNumbersOfArrayAccesses += 3;
                        metrics.TotalNumbersOfComparisons++;

                        double throughK = dist[i, k] + dist[k, j];

                        SendRuntimeNote($"Checking path", new Dictionary<string, object> {
                    { "From", nodes[i].ToString() },
                    { "To", nodes[j].ToString() },
                    { "Via", nodes[k].ToString() },
                    { "DirectDistance", dist[i, j] },
                    { "PathThroughKDistance", throughK }
                }, sender);

                        if (throughK < dist[i, j])
                        {
                            metrics.TotalNumbersOfSteps += 2;
                            metrics.TotalNumbersOfArrayAccesses += 2;

                            dist[i, j] = throughK;
                            next[i, j] = next[i, k]; // Update path

                            SendMemoryNote($"Updated shortest path: {nodes[i]} to {nodes[j]} via {nodes[k]}, new distance: {throughK}", sender);
                        }
                    }
                }
            }

            SendNote("Floyd-Warshall algorithm completed", sender);

            // Display and return results
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && dist[i, j] != double.PositiveInfinity)
                    {
                        // Reconstruct path
                        List<Node> path = new List<Node>();
                        Node current = nodes[i];

                        SendRuntimeNote($"Path from {nodes[i]} to {nodes[j]}", new Dictionary<string, object> {
                    { "Distance", dist[i, j] }
                }, sender);

                        // Path reconstruction if we have the next matrix
                        if (next[i, j] != null)
                        {
                            path.Add(current);
                            while (!current.Equals(nodes[j]))
                            {
                                int currentIndex = nodes.IndexOf(current);
                                int nextIndex = nodes.IndexOf(next[currentIndex, j]);
                                current = nodes[nextIndex];
                                path.Add(current);

                                SendNode(current, new Dictionary<string, object> {
                            { "Role", "Path node" }
                        }, sender);
                            }

                            SendNote($"Path from {nodes[i]} to {nodes[j]}: {string.Join(" -> ", path)}", sender);
                        }
                    }
                }
            }

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
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