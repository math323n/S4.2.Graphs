using System.Collections.Generic;

namespace S4._2.Graphs.Library.Graphs
{
    public class UndirectedGraph<T> : GraphTraverser<T>
    {
        public UndirectedGraph()
        {

        }

        public UndirectedGraph(List<Vertex<T>> vertices)
        {
            _vertices = vertices;
        }
    }
}