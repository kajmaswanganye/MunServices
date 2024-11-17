using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunServices
{
    // Service Request Graph Implementation
    public class ServiceRequestGraph
    {
        private Dictionary<string, HashSet<string>> adjacencyList;
        private Dictionary<string, Issue> issueMap;

        public ServiceRequestGraph()
        {
            adjacencyList = new Dictionary<string, HashSet<string>>();
            issueMap = new Dictionary<string, Issue>();
        }

        public void AddVertex(Issue issue)
        {
            if (!adjacencyList.ContainsKey(issue.Location))
            {
                adjacencyList[issue.Location] = new HashSet<string>();
                issueMap[issue.Location] = issue;
            }
        }

        public void AddEdge(string location1, string location2)
        {
            if (!adjacencyList.ContainsKey(location1))
                adjacencyList[location1] = new HashSet<string>();
            if (!adjacencyList.ContainsKey(location2))
                adjacencyList[location2] = new HashSet<string>();

            adjacencyList[location1].Add(location2);
            adjacencyList[location2].Add(location1);
        }

        // DFS Traversal
        public List<Issue> DFSTraversal(string startLocation)
        {
            var visited = new HashSet<string>();
            var result = new List<Issue>();
            DFSUtil(startLocation, visited, result);
            return result;
        }

        private void DFSUtil(string location, HashSet<string> visited, List<Issue> result)
        {
            visited.Add(location);
            if (issueMap.ContainsKey(location))
                result.Add(issueMap[location]);

            foreach (var neighbor in adjacencyList[location])
            {
                if (!visited.Contains(neighbor))
                    DFSUtil(neighbor, visited, result);
            }
        }

        // BFS Traversal
        public List<Issue> BFSTraversal(string startLocation)
        {
            var visited = new HashSet<string>();
            var result = new List<Issue>();
            var queue = new Queue<string>();

            visited.Add(startLocation);
            queue.Enqueue(startLocation);

            while (queue.Count > 0)
            {
                string current = queue.Dequeue();
                if (issueMap.ContainsKey(current))
                    result.Add(issueMap[current]);

                foreach (var neighbor in adjacencyList[current])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return result;
        }

        // Minimum Spanning Tree using Kruskal's Algorithm
        public List<(string, string)> GetMinimumSpanningTree()
        {
            var edges = new List<(string, string, double)>();
            var result = new List<(string, string)>();
            var disjointSet = new Dictionary<string, string>();

            foreach (var vertex in adjacencyList.Keys)
            {
                disjointSet[vertex] = vertex;
                foreach (var neighbor in adjacencyList[vertex])
                {
                    var weight = CalculateWeight(vertex, neighbor);
                    edges.Add((vertex, neighbor, weight));
                }
            }

            edges.Sort((a, b) => a.Item3.CompareTo(b.Item3));

            foreach (var edge in edges)
            {
                var root1 = Find(disjointSet, edge.Item1);
                var root2 = Find(disjointSet, edge.Item2);

                if (root1 != root2)
                {
                    result.Add((edge.Item1, edge.Item2));
                    Union(disjointSet, root1, root2);
                }
            }

            return result;
        }
        private string Find(Dictionary<string, string> disjointSet, string vertex)
        {
            if (disjointSet[vertex] != vertex)
                disjointSet[vertex] = Find(disjointSet, disjointSet[vertex]);
            return disjointSet[vertex];
        }

        private void Union(Dictionary<string, string> disjointSet, string x, string y)
        {
            disjointSet[x] = y;
        }

        private double CalculateWeight(string location1, string location2)
        {
            // Simple weight calculation based on string comparison
            return Math.Abs(string.Compare(location1, location2));
        }
    }

}
