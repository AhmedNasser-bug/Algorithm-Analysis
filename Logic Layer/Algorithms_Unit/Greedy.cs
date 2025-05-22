using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Algorithms_Unit.DynamicProgramming;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms_Unit
{

    public class Greedy
    {
        public delegate void GreedyStateChangeHandler(object sender, GreedyStateDictionary e);
        public static event GreedyStateChangeHandler? OnGreedyStateChange;
        public delegate void MemoryNoteEventHandler(object sender, string HitState);
        public static event MemoryNoteEventHandler? OnMemoryNote;
        public static event SendNoteEventHandler? OnSendNote;


        /// <summary>
        /// Call on each iteration of each algorithm with the exact state of all tracked variables
        /// </summary>
        public static void SendRuntimeNote(string choiceRepresentation, Dictionary<string, object> problemSpec, object sender = null)
        {
            OnGreedyStateChange?.Invoke(sender, new GreedyStateDictionary(choiceRepresentation, null));
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



        public static Metrics CoinChangeProblem(int[] coins, int sum, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            SendRuntimeNote("Starting coin change problem calculation", new Dictionary<string, object> { { "Sum", sum }, { "CoinsCount", coins.Length } }, sender);

            int count = countRecur(coins, coins.Length, sum, ref metrics, sender);

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            SendRuntimeNote("Completed coin change problem", new Dictionary<string, object> { { "Result", count } }, sender);
            return metrics;
        }

        static int countRecur(int[] coins, int n, int sum, ref Metrics metrics, object sender = null)
        {
            SendRuntimeNote($"Checking subproblem", new Dictionary<string, object> { { "n", n }, { "sum", sum } }, sender);

            metrics.TotalNumbersOfComparisons++;
            // If sum is 0 then there is 1 solution
            // (do not include any coin)
            if (sum == 0)
            {
                SendNote("Found valid coin combination (sum = 0)", sender);
                return 1;
            }

            metrics.TotalNumbersOfComparisons++;
            // 0 ways in the following two cases
            if (sum < 0 || n == 0)
            {
                SendNote("Invalid coin combination (negative sum or no coins left)", sender);
                return 0;
            }

            // count is sum of solutions (i)
            // including coins[n-1] (ii) excluding coins[n-1]
            metrics.TotalNumbersOfComparisons++;
            metrics.TotalNumbersOfIterations++;
            metrics.TotalNumbersOfArrayAccesses++;

            SendMemoryNote($"Creating recursive branches for n={n}, sum={sum}", sender);
            SendRuntimeNote("Splitting into two subproblems", new Dictionary<string, object> {
        { "Including coin", coins[n-1] },
        { "New sum for branch 1", sum - coins[n-1] },
        { "New n for branch 2", n-1 }
    }, sender);

            return countRecur(coins, n, sum - coins[n - 1], ref metrics, sender) +
                   countRecur(coins, n - 1, sum, ref metrics, sender);
        }

        public static Metrics ActivitySelectionProblem(int[] start, int[] finish, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            metrics.TotalNumbersOfSteps += 3;
            int n = start.Length;
            int ans = 0;

            SendRuntimeNote("Initializing activity selection problem", new Dictionary<string, object> { { "Activities", n } }, sender);

            int[,] arr = new int[n, 2];
            SendMemoryNote($"Created 2D array of size {n}x2 to store activities", sender);

            metrics.TotalNumbersOfComparisons++;
            for (int i = 0; i < n; i++)
            {
                metrics.TotalNumbersOfComparisons++;
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfSteps += 2;
                metrics.TotalNumbersOfArrayAccesses += 2;
                arr[i, 0] = finish[i];
                arr[i, 1] = start[i];
                SendRuntimeNote($"Stored activity {i}", new Dictionary<string, object> { { "Start", start[i] }, { "Finish", finish[i] } }, sender);
            }

            metrics.TotalNumbersOfSteps += 2;
            SendRuntimeNote("Sorting activities by finish time", new Dictionary<string, object>(), sender);
            SendMemoryNote("Rearranging arrays in sorted order", sender);
            Array.Sort(finish, start);

            int finishtime = -1;
            SendRuntimeNote("Starting activity selection with initial finish time = -1", new Dictionary<string, object>(), sender);

            metrics.TotalNumbersOfIterations++;
            for (int i = 0; i < n; i++)
            {
                metrics.TotalNumbersOfIterations += 2;
                metrics.TotalNumbersOfArrayAccesses++;
                SendRuntimeNote($"Examining activity {i}", new Dictionary<string, object> { { "Start", start[i] }, { "Finish", finish[i] } }, sender);

                if (start[i] > finishtime)
                {
                    metrics.TotalNumbersOfSteps += 2;
                    metrics.TotalNumbersOfArrayAccesses++;
                    finishtime = finish[i];
                    ans++;
                    SendNote($"Selected activity {i} with start time {start[i]} and finish time {finish[i]}", sender);
                    SendRuntimeNote($"Updated finish time to {finishtime}", new Dictionary<string, object> { { "Selected count", ans } }, sender);
                }
            }

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            SendNote($"Maximum number of activities that can be performed: {ans}", sender);
            return metrics;
        }

        class Node : IComparable<Node>
        {
            public int data;
            public Node left, right;
            public Node(int x)
            {
                data = x;
                left = null;
                right = null;
            }

            public int CompareTo(Node other)
            {
                if (other == null)
                {
                    return 0;
                }

                if (other.data > this.data)
                {
                    return 1;
                }

                if (other.data < this.data)
                {
                    return -1;
                }

                return 0;
            }
        }

        static void preOrder(Node root, List<string> ans, string curr, ref object sender, Metrics metrics)
        {
            SendRuntimeNote($"Traversing node with recursive depth", new Dictionary<string, object> { { "CurrentCode", curr }, { "NodeFreq", root?.data } }, sender);

            metrics.TotalNumbersOfComparisons++;
            if (root == null) return;

            metrics.TotalNumbersOfComparisons += 2;

            if (root.left == null && root.right == null)
            {
                metrics.TotalNumbersOfSteps++;
                SendNote($"Found leaf node with frequency {root.data}, assigning code: {curr}", sender);
                SendMemoryNote($"Adding new code to result list: {curr}", sender);
                ans.Add(curr);
                return;
            }

            metrics.TotalNumbersOfSteps++;
            SendRuntimeNote("Going left in Huffman tree", new Dictionary<string, object> { { "AppendingBit", "0" } }, sender);
            metrics.TotalNumbersOfSteps++;
            preOrder(root.left, ans, curr + "0", ref sender, metrics);

            SendRuntimeNote("Going right in Huffman tree", new Dictionary<string, object> { { "AppendingBit", "1" } }, sender);
            metrics.TotalNumbersOfSteps++;
            preOrder(root.right, ans, curr + "1", ref sender, metrics);
        }

        public static Metrics HuffmanCoding(string s, int[] freq, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            metrics.TotalNumbersOfSteps++;

            SendRuntimeNote("Starting Huffman coding algorithm", new Dictionary<string, object> { { "StringLength", s.Length } }, sender);

            int n = s.Length;
            metrics.TotalNumbersOfSteps++;

            // Min heap for node class.
            SendMemoryNote("Creating priority queue for Huffman tree construction", sender);
            PriorityQueue<Node, int> pq = new System.Collections.Generic.PriorityQueue<Node, int>();

            metrics.TotalNumbersOfComparisons += 2;
            for (int i = 0; i < n; i++)
            {
                metrics.TotalNumbersOfComparisons++;
                metrics.TotalNumbersOfArrayAccesses++;
                metrics.TotalNumbersOfSteps++;

                Node tmp = new Node(freq[i]);
                SendRuntimeNote($"Creating leaf node for character", new Dictionary<string, object> { { "Character", s[i] }, { "Frequency", freq[i] } }, sender);
                SendMemoryNote($"Adding node with frequency {freq[i]} to priority queue", sender);
                pq.Enqueue(tmp, tmp.data);
            }

            SendNote("Starting Huffman tree construction by merging nodes", sender);
            metrics.TotalNumbersOfComparisons++;
            while (pq.Count >= 2)
            {
                metrics.TotalNumbersOfComparisons++;
                metrics.TotalNumbersOfSteps++;
                metrics.TotalNumbersOfIterations++;

                SendMemoryNote("Removing two nodes with lowest frequencies from queue", sender);
                Node l = pq.Dequeue();
                metrics.TotalNumbersOfArrayAccesses++;
                Node r = pq.Dequeue();
                metrics.TotalNumbersOfArrayAccesses++;

                metrics.TotalNumbersOfSteps++;
                int combinedFreq = l.data + r.data;
                SendRuntimeNote("Merging nodes", new Dictionary<string, object> { { "LeftFreq", l.data }, { "RightFreq", r.data }, { "CombinedFreq", combinedFreq } }, sender);

                Node newNode = new Node(combinedFreq);
                newNode.left = l;
                newNode.right = r;

                metrics.TotalNumbersOfSteps++;
                SendMemoryNote($"Adding new internal node with frequency {combinedFreq} to priority queue", sender);
                pq.Enqueue(newNode, newNode.data);
            }

            metrics.TotalNumbersOfSteps++;
            SendNote("Huffman tree construction complete, retrieving root node", sender);
            Node root = pq.Dequeue();
            metrics.TotalNumbersOfArrayAccesses++;

            SendMemoryNote("Creating list to store Huffman codes", sender);
            List<string> ans = new List<string>();
            metrics.TotalNumbersOfSteps++;

            SendNote("Starting pre-order traversal to generate Huffman codes", sender);
            preOrder(root, ans, "", ref sender, metrics);

            SendNote($"Huffman coding complete, generated {ans.Count} codes", sender);
            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            return metrics;
        }


        public class DSU
        {
            public int[] parent, rank;

            public DSU(int n, object sender = null)
            {
                SendMemoryNote($"Creating DSU data structure with {n} elements", sender);
                parent = new int[n];
                rank = new int[n];

                for (int i = 0; i < n; i++)
                {
                    parent[i] = i;
                    rank[i] = 1;
                    SendRuntimeNote($"Initializing element {i}", new Dictionary<string, object> { { "parent", i }, { "rank", 1 } }, sender);
                }
            }

            public int Find(int i, object sender = null)
            {
                SendRuntimeNote($"Finding representative for element {i}", new Dictionary<string, object> { { "Current parent", parent[i] } }, sender);

                if (parent[i] != i)
                {
                    SendNote($"Path compression: element {i} not directly connected to its representative", sender);
                    int originalParent = parent[i];
                    parent[i] = Find(parent[i], sender);
                    SendMemoryNote($"Updated parent of {i} from {originalParent} to {parent[i]}", sender);
                }
                return parent[i];
            }

            public void Union(int x, int y, object sender = null)
            {
                SendRuntimeNote($"Performing union of sets containing {x} and {y}", new Dictionary<string, object>(), sender);

                int s1 = Find(x, sender);
                int s2 = Find(y, sender);

                SendRuntimeNote($"Representatives found", new Dictionary<string, object> { { "Representative of " + x, s1 }, { "Representative of " + y, s2 } }, sender);

                if (s1 != s2)
                {
                    if (rank[s1] < rank[s2])
                    {
                        SendMemoryNote($"Merging smaller set {s1} into larger set {s2}", sender);
                        parent[s1] = s2;
                        SendRuntimeNote($"Updated parent of {s1}", new Dictionary<string, object> { { "New parent", s2 } }, sender);
                    }
                    else if (rank[s1] > rank[s2])
                    {
                        SendMemoryNote($"Merging smaller set {s2} into larger set {s1}", sender);
                        parent[s2] = s1;
                        SendRuntimeNote($"Updated parent of {s2}", new Dictionary<string, object> { { "New parent", s1 } }, sender);
                    }
                    else
                    {
                        SendMemoryNote($"Sets {s1} and {s2} have equal rank, merging {s2} into {s1} and increasing rank", sender);
                        parent[s2] = s1;
                        rank[s1]++;
                        SendRuntimeNote($"Updated values", new Dictionary<string, object> { { "New parent of " + s2, s1 }, { "New rank of " + s1, rank[s1] } }, sender);
                    }
                    SendNote($"Union successful: sets {x} and {y} are now connected", sender);
                }
                else
                {
                    SendNote($"Union skipped: elements {x} and {y} already in same set", sender);
                }
            }
        }

        public static Metrics KruskalsMST(int V, int[][] edges, object sender = null)
        {
            Metrics metrics = new Metrics();
            DateTime begin = DateTime.Now;
            metrics.TotalNumbersOfSteps++;

            SendRuntimeNote("Starting Kruskal's MST algorithm", new Dictionary<string, object> { { "Vertices", V }, { "Edges", edges.Length } }, sender);

            // Sort edges by weight
            SendNote("Sorting edges by weight in ascending order", sender);
            Array.Sort(edges, (e1, e2) => {
                metrics.TotalNumbersOfComparisons++;
                metrics.TotalNumbersOfArrayAccesses += 2;
                SendRuntimeNote($"Comparing edges", new Dictionary<string, object> {
            { "Edge1", $"{e1[0]}-{e1[1]} (weight: {e1[2]})" },
            { "Edge2", $"{e2[0]}-{e2[1]} (weight: {e2[2]})" }
        }, sender);
                return e1[2].CompareTo(e2[2]);
            });
            SendMemoryNote("Edges sorted by weight", sender);

            DSU dsu = new DSU(V, sender);
            metrics.TotalNumbersOfSteps++;

            int cost = 0, count = 0;
            metrics.TotalNumbersOfSteps++;
            SendRuntimeNote("Initialized MST construction", new Dictionary<string, object> { { "Initial cost", 0 }, { "Edges in MST", 0 } }, sender);

            foreach (var e in edges)
            {
                metrics.TotalNumbersOfSteps++;
                metrics.TotalNumbersOfIterations++;
                metrics.TotalNumbersOfArrayAccesses += 3;

                int x = e[0], y = e[1], w = e[2];
                SendRuntimeNote($"Examining edge", new Dictionary<string, object> { { "From", x }, { "To", y }, { "Weight", w } }, sender);

                metrics.TotalNumbersOfSteps++;
                metrics.TotalNumbersOfComparisons++;
                if (dsu.Find(x, sender) != dsu.Find(y, sender))
                {
                    SendNote($"Edge ({x},{y}) with weight {w} doesn't create a cycle - adding to MST", sender);
                    metrics.TotalNumbersOfSteps++;
                    dsu.Union(x, y, sender);

                    cost += w;
                    metrics.TotalNumbersOfSteps++;
                    SendRuntimeNote($"Updated MST cost", new Dictionary<string, object> { { "Current cost", cost }, { "Added edge weight", w } }, sender);

                    count++;
                    SendRuntimeNote($"Edge added to MST", new Dictionary<string, object> { { "Edges in MST", count }, { "Required edges", V - 1 } }, sender);
                    metrics.TotalNumbersOfComparisons++;
                    if (count == V - 1)
                    {
                        SendNote("MST complete: found all required edges", sender);
                        break;
                    }
                }
                else
                {
                    SendNote($"Edge ({x},{y}) with weight {w} creates a cycle - skipping", sender);
                }
            }

            metrics.TotalRuntimeTicks = (DateTime.Now - begin).Ticks;
            SendRuntimeNote("Kruskal's algorithm completed", new Dictionary<string, object> { { "Final MST cost", cost }, { "Edges in MST", count } }, sender);
            return metrics;
        }


    }
}
