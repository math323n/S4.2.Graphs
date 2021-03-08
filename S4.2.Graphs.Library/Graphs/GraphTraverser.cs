using System.Collections.Generic;

namespace S4._2.Graphs.Library
{
    public class GraphTraverser<T>
    {
        protected List<Vertex<T>> _vertices;

        public GraphTraverser()
        {

        }

        public GraphTraverser(List<Vertex<T>> vertices)
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


        public virtual string DepthFirstSearch(Vertex<T> root)
        {
            string toReturn = "";
            // check root
            if (!root.Visited)
            {
                toReturn += root + "\n";
                // Set root to visited
                root.Visited = true;

                foreach (Vertex<T> neighbour in root.Neighbours)
                {
                    toReturn += DepthFirstSearch(neighbour);
                }

            }
            return toReturn;
        }

        public virtual string BreadthFirstSearch(Vertex<T> root)
        {
            string toReturn = "";
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();

            // check if root is visited
            root.Visited = true;
            toReturn += root + "\n";
            // add object to end of queue
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Vertex<T> current = queue.Dequeue();
                foreach (Vertex<T> neighbour in current.Neighbours)
                {
                    if (!neighbour.Visited)
                    {
                        toReturn += neighbour + "\n";
                        neighbour.Visited = true;
                        queue.Enqueue(neighbour);
                    }
                }
            }
            return toReturn;
        }
    }
}