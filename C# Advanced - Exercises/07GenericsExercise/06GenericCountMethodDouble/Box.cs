using System;

namespace _06GenericCountMethodDouble
{
    public class Box<T>
        where T : IComparable<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            return $"{value.GetType()}: {value}";
        }
    }
}
