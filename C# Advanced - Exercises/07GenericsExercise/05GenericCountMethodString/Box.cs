using System;

namespace _05GenericCountMethodString
{
    public class Box<T>
        where T : IComparable<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            return $"{Value.GetType()}: {Value}";
        }
    }
}
