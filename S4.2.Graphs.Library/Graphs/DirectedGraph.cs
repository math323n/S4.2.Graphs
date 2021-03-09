using System.Collections.Generic;

namespace S4._2.Graphs.Library.Graphs
{
    public class DirectedGraph<T, TEdge> : GraphTraverser<T>
    {
        protected List<Edge<T, TEdge>> _edges;

        public DirectedGraph()
        {

        }

        public DirectedGraph(List<Vertex<T>> vertices)
        {
            _vertices = vertices;
            _edges = new();
        }

        public virtual List<Edge<T, TEdge>> Edges
        {
            get
            {
                return _edges;
            }
            set
            {
                _edges = value;
            }
        }

        public virtual void AddEdge(Vertex<T> left, Vertex<T> right, TEdge item)
        {
            left.AddNeighbour(right);
            Edge<T, TEdge> edge = new(left, right, item);
            Edges.Add(edge);
        }


        public virtual string FindEdges(Vertex<T> vertex)
        {
            string toReturn = "";
            foreach (Edge<T, TEdge> edge in Edges)
            {
                if (edge.Left == vertex)
                {
                    toReturn += $"{edge.Left} -- {edge.Item} -- {edge.Right} \n";
                }
            }
            return toReturn;
        }

        public override string DepthFirstSearch(Vertex<T> root)
        {
            string toReturn = "";
            if (!root.Visited)
            {
                toReturn += FindEdges(root) + "\n";
                root.Visited = true;

                foreach (Vertex<T> neighbor in root.Neighbours)
                {
                    toReturn += DepthFirstSearch(neighbor);
                }

            }
            return toReturn;
        }
    }
}