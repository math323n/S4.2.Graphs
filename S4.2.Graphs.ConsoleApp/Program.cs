using S4._2.Graphs.Library;
using S4._2.Graphs.Library.Graphs;

using System;
using System.Collections.Generic;

namespace S4._2.Graphs.ConsoleApp
{
    class Program
    {
        static void Main()
        {
             
            Vertex<string> kastrup = new("Kastrup");
            Vertex<string> tirstrup = new("Tirstrup");
            Vertex<string> ronne = new("Ronne");
            Vertex<string> aalborg = new("Aalborg");
            Vertex<string> billund = new("Billund");
            Vertex<string> odense = new("Odense");

            billund.AddNeighbour(aalborg);
            billund.AddNeighbour(kastrup);

            kastrup.AddNeighbour(aalborg);
            kastrup.AddNeighbour(tirstrup);
            kastrup.AddNeighbour(ronne);
            kastrup.AddNeighbour(billund);

            aalborg.AddNeighbour(ronne);
            aalborg.AddNeighbour(billund);
            aalborg.AddNeighbour(odense);



            GraphTraverser<string> graph = new(new List<Vertex<string>>() { kastrup, odense, ronne, aalborg, billund, tirstrup });

            // Test DFS searching algorithm
            Console.WriteLine("DFS:");
            Console.WriteLine(graph.DepthFirstSearch(aalborg));

            Console.WriteLine("BFS:");
            Console.WriteLine(graph.BreadthFirstSearch(aalborg));

            // Directed graph
            DirectedGraph<string, int> directedGraph = new(new List<Vertex<string>>() { kastrup, odense, ronne, aalborg, billund, tirstrup });
            directedGraph.AddEdge(kastrup, tirstrup, 200);
            directedGraph.AddEdge(kastrup, ronne, 150);

            directedGraph.AddEdge(aalborg, ronne, 450);
            directedGraph.AddEdge(aalborg, billund, 152);
            directedGraph.AddEdge(aalborg, odense, 256);
            directedGraph.AddEdge(kastrup, billund, 300);
            directedGraph.AddEdge(kastrup, aalborg, 456);

            // Get the edges
            Console.WriteLine(directedGraph.FindEdges(kastrup));
            // Count of vertex
            Console.WriteLine(directedGraph.Vertices.Count);

            // Count of edges 
            Console.WriteLine("Count: " + directedGraph.Edges.Count);

            foreach (Vertex<string> vertex in graph.Vertices)
            {
                vertex.Visited = false;
            }


           
         


            // Directed graph
            

        }
    }
}