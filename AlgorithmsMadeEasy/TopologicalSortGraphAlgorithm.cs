using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    using QuickGraph;

    class TopologicalSortGraphAlgorithm
    {
        static AdjacencyGraph<string, Edge<string>> graph = new AdjacencyGraph<string, Edge<string>>(true);
        static HashSet<string> visited = new HashSet<string>();
        static HashSet<string> result = new HashSet<string>();
        static Stack<string> sorted = new Stack<string>();

        public void TopologicalSortGraphAlgorithmMethod()
        {
            // Add some vertices to the graph
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            graph.AddVertex("E");
            graph.AddVertex("F");
            graph.AddVertex("G");
            graph.AddVertex("H");
            graph.AddVertex("I");
            graph.AddVertex("J");

            // Create the edges
            Edge<string> a_b = new Edge<string>("A", "B");
            Edge<string> a_d = new Edge<string>("A", "D");
            Edge<string> b_a = new Edge<string>("B", "A");
            Edge<string> b_c = new Edge<string>("B", "C");
            Edge<string> b_e = new Edge<string>("B", "E");
            Edge<string> c_b = new Edge<string>("C", "B");
            Edge<string> c_f = new Edge<string>("C", "F");
            Edge<string> c_j = new Edge<string>("C", "J");
            Edge<string> d_e = new Edge<string>("D", "E");
            Edge<string> d_g = new Edge<string>("D", "G");
            Edge<string> e_d = new Edge<string>("E", "D");
            Edge<string> e_f = new Edge<string>("E", "F");
            Edge<string> e_h = new Edge<string>("E", "H");
            Edge<string> f_i = new Edge<string>("F", "I");
            Edge<string> f_j = new Edge<string>("F", "J");
            Edge<string> g_d = new Edge<string>("G", "D");
            Edge<string> g_h = new Edge<string>("G", "H");
            Edge<string> h_g = new Edge<string>("H", "G");
            Edge<string> h_i = new Edge<string>("H", "I");
            Edge<string> i_f = new Edge<string>("I", "F");
            Edge<string> i_j = new Edge<string>("I", "J");
            Edge<string> i_h = new Edge<string>("I", "H");
            Edge<string> j_f = new Edge<string>("J", "F");

            // Add the edges
            graph.AddEdge(a_b);
            graph.AddEdge(a_d);
            graph.AddEdge(b_c);
            graph.AddEdge(b_e);
            graph.AddEdge(c_f);
            graph.AddEdge(c_j);
            graph.AddEdge(d_e);
            graph.AddEdge(d_g);
            graph.AddEdge(e_f);
            graph.AddEdge(e_h);
            graph.AddEdge(f_i);
            graph.AddEdge(f_j);
            graph.AddEdge(g_h);
            graph.AddEdge(h_i);
            graph.AddEdge(i_j);

            foreach (var vertex in graph.Vertices)
            {
                if (visited.Contains(vertex))
                {
                    sorted.Push(vertex);
                }
                else
                {
                    visited.Add(vertex);

                    ExploreChild(vertex);
                    sorted.Push(vertex);
                }
            }

            while (sorted.Count > 0)
            {
                result.Add(sorted.Pop());
            }

            List<string> temp = new List<string>();

            foreach (var r in result)
            {
                temp.Add(r);
            }

            for (int j = temp.Count - 1; j >= 0; j--)
            {
                Console.Write(temp[j] + " ");
            }

            Console.ReadLine();
        }

        public static void ExploreChild(dynamic vertex)
        {
            bool noChildren = false;
            foreach (var e in graph.Edges)
            {
                if (e.Source.Equals(vertex))
                {
                    if (visited.Contains(e.Target))
                    {
                        //Do Nothing
                    }
                    else
                    {
                        visited.Add(e.Target);
                        ExploreChild(e.Target);
                        noChildren = true;

                    }
                }
            }

            if (!noChildren)
            {
                sorted.Push(vertex);
            }
        }
    }
}
