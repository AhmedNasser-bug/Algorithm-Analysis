
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit
{
    public class Pathfinding
    {
        public delegate void PathfindingIterationHandler(object sender, PathfindingStateDictionary e);
        public static event PathfindingIterationHandler? PathfindingIteration;


        /// <summary>
        /// Call on each iteration of each algorithm with the exact state of all tracked variables
        /// </summary>
        public static void OnPathfindingIteration(char ProcessedNode, Dictionary<String, object>? ProblemSpecificArgs)
        {
            PathfindingIteration?.Invoke(null, new PathfindingStateDictionary(ProcessedNode, ProblemSpecificArgs));
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
    }
}
