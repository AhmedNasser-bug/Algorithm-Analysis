using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Unit.Utils
{

    /// <summary>
    /// This class is used to generate the inputs of various algorithms.
    /// Methods:
    ///     - GenerateRandomArray: Generates a random array of integers.
    ///     - GenerateSortedArray: Generates a sorted array of integers.
    ///     - GenerateReversedArray: Generates a reversed array of integers.
    ///     - GenerateRandomGraph: Generates a random graph with a given number of vertices and edges.
    ///     - GenerateGraphFromAdjacencyList: Generates a graph from an adjacency list.
    /// </summary>
    public class Input
    {

        /*
         TODO:
            - GenerateRandomArray: Generates a random array of integers.
            - GenerateSortedArray: Generates a sorted array of integers.
            - GenerateReversedArray: Generates a reversed array of integers.
            - GenerateRandomGraph: Generates a random graph with a given number of vertices and edges.
            - GenerateGraphFromAdjacencyList: Generates a graph from an adjacency list.
         */

        public static List<Int128> GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            List<Int128> array = new List<Int128>();
            for (int i = 0; i < size; i++)
            {
                array.Add((Int128)random.Next(minValue, maxValue));
            }
            return array;
        }
        public static List<Int128> GenerateRandomRange(int minValue, int maxValue)
        {
            Random random = new Random();
            List<Int128> array = new();

            // Initialize values for the array
            for (Int128 i = minValue; i < maxValue; i++)array.Add(i);

            // Shuffle the array
            SortingUtils.Shuffle(ref array);

            return array;
        }
        public static List<Int128> GenerateSortedArray(int size, int minValue, int maxValue)
        {
            List<Int128> array = new();
            for (int i = minValue; i < maxValue; i++)
            {
                array.Add((Int128)i);
            }
            return array;
        }
        public static List<Int128> GenerateReverseSortedArray(int minValue, int maxValue)
        {
            List<Int128> arr = new();

            for (Int128 i = maxValue; i >= minValue; i--)
            {
                arr.Add(i);
            }

            return arr;
        }
    }
}
