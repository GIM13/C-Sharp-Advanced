using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> repository;

        public Stack()
        {
            this.repository = new List<T>();
        }

        public void Push(T element)
        {
            repository.Add(element);
        }

        public T Pop()
        {
            var result = repository[repository.Count - 1];

            repository.RemoveAt(repository.Count - 1);

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = repository.Count - 1; i >= 0; i--)
            {
                yield return repository[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
