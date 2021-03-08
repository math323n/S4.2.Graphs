using System.Collections.Generic;

namespace S4._2.Graphs.Library
{
    public class Vertex<T> : Node<T>
    {
        protected bool visited;
        protected List<Vertex<T>> neighbours;

        public Vertex(T item)
        {
            _item = item;
            neighbours = new();
        }

        public virtual void AddNeighbour(Vertex<T> neighbour)
        {
            Neighbours.Add(neighbour);
            neighbour.Neighbours.Add(this);
        }

        public virtual bool HasNeighbor(Vertex<T> neighbour)
        {
            if (neighbours.Contains(neighbour))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Vertex<T>> Neighbours
        {
            get
            {
                return neighbours;
            }
            set
            {
                neighbours = value;
            }
        }

        public bool Visited
        {
            get
            {
                return visited;
            }
            set
            {
                visited = value;
            }
        }
    }
}
