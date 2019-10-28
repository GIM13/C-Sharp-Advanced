using System.Collections;
using System.Collections.Generic;

namespace _04Froggy
{
    public class Lake : IEnumerable<int>
    {
        public Lake(int[] stones)
        {
            Stones = stones;
        }

        public int[] Stones { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Stones.Length; i++)
            {
                if (i % 2 == 0)
                {
                    yield return Stones[i];
                }
            }

            for (int i = Stones.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return Stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
