using System;
using System.Collections.Generic;

namespace _01ListyIterator
{
    public class ListyIterator<T> 
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
    }
}
