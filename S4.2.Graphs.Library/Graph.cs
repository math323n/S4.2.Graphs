using System;
using System.Collections.Generic;

namespace S4._2.Graphs.Library
{
    public class Graph<T>
    {
        protected List<Vertex<T>> _vertices;

        public Graph()
        {

        }

        public Graph(List<Vertex<T>> vertices)
        {
            _vertices = vertices;
        }

        public virtual List<Vertex<T>> Vertices
        {
            get
            {
                return _vertices;
            }
            set
            {
                _vertices = value;
            }
        }

        public string DepthFirstSearch(Vertex<T> root)
        {
            string toReturn = "";
            if (!root.Visited)
            {
                toReturn += root + "\n";
                root.Visited = true;

                foreach (Vertex<T> neighbor in root.Neighbours)
                {
                    toReturn += DepthFirstSearch(neighbor);
                }

            }
            return toReturn;
        }

        public string BreadthFirstSearch(Vertex<T> root)
        {
            string toReturn = "";
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();

            root.Visited = true;
            toReturn += root + "\n";
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Vertex<T> current = queue.Dequeue();
                foreach (Vertex<T> neighbor in current.Neighbours)
                {
                    if (!neighbor.Visited)
                    {
                        toReturn += neighbor + "\n";
                        neighbor.Visited = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
            return toReturn;
        }
    }
}