namespace S4._2.Graphs.Library
{
    public class Node<T>
    {
        protected T _item;

        public Node()
        {

        }

        public Node(T item)
        {
            _item = item;
        }

        public virtual T Item
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

        public override string ToString()
        {
            return Item.ToString();
        }
    }
}