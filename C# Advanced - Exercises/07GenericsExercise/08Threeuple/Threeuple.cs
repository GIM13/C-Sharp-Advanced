
namespace _08Threeuple
{
    public class Threeuple<T,V,W>
    {
        public Threeuple(T item1, V item2, W item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public T item1 { get; set; }

        public V item2 { get; set; }

        public W item3 { get; set; }

        public override string ToString()
        {
            return $"{item1} -> {item2} -> {item3}";
        }
    }
}
