using System;
using System.Collections;
using System.Collections.Generic;

namespace _02Collection
{
    public class ListyIterator<T> : IEnumerator<T>,IEnumerable<T>
    {
        private int index;

        public ListyIterator(params T[] collection)
        {
            if (collection.Length == 0)
            {
                this.LisCollection = new List<T>();
            }
            else
            {
                this.LisCollection = new List<T>();

                foreach (var item in collection)
                {
                    this.LisCollection.Add(item);
                }
            }
        }

        public List<T> LisCollection { get; set; }

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public bool Move()
        {
            if (LisCollection.Count - 1 <= index)
            {
                return false;
            }

            index++;

            return true;
        }

        public bool HasNext()
        {
            if (LisCollection.Count - 1 <= index)
            {
                return false;
            }

            return true;
        }

        public void Print()
        {
            if (LisCollection.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.LisCollection[index]);
            }
        }
        public void PrintAll()
        {
            if (LisCollection.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                string result = string.Empty;

                foreach (var item in LisCollection)
                {
                    result = result + item + " ";
                }

                Console.Write(string.Join(" ", result.Trim()));
            }
        }

        public bool MoveNext()
        {
            if (LisCollection.Count - 1 < ++index)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            index = 0;
        }

        public void Dispose()
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in LisCollection)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
