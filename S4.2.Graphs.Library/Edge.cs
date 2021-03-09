using System;

namespace S4._2.Graphs.Library
{
    public class Edge<T, TEdge> : IComparable<TEdge>
    {
        protected TEdge _item;
        protected Vertex<T> _left;
        protected Vertex<T> _right;

        public Edge(Vertex<T> left, Vertex<T> right, TEdge item)
        {
            _left = left;
            _right = right;
            _item = item;
        }

        public virtual Vertex<T> Left
        {
            get
            {
                return _left;
            }
        }

        public virtual Vertex<T> Right
        {
            get
            {
                return _right;
            }
        }

        public virtual TEdge Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }

        public int CompareTo(TEdge other)
        {
            return CompareTo(other);
        }

        public override string ToString()
        {
            return Item.ToString();
        }
    }
}