
namespace _07Tuple
{
    public class Tuple<T,V>
    {
        public Tuple(T item1, V item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        public T item1 { get; set; }

        public V item2 { get; set; }

        public override string ToString()
        {
            return $"{item1} -> {item2}";
        }
    }
}
