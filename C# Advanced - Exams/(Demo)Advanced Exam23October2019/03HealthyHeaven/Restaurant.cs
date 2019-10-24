using System;
using System.Linq;
using System.Collections.Generic;

namespace HealthyHeaven
{
    internal class Restaurant
    {
        private int counter;

        private List<Salad> salads;

        public Restaurant(string name)
        {
            this.Name = name;

            salads = new List<Salad>();
        }

        public string Name { get; private set; }

        internal void Add(Salad salad)
        {
            this.salads.Add(salad);

            counter++;
        }

        internal bool Buy(string saladName)
        {
            Salad salad = this.salads.FirstOrDefault(x => x.Name == saladName);

            if (salads.Contains(salad))
            {
                this.salads.Remove(salad);

                counter--;

                return true;
            }

            return false;
        }

        internal string GetHealthiestSalad()
        {
            var result = salads.OrderBy(x => x.GetTotalCalories()).FirstOrDefault();

            return result.Name;
        }

        internal string GenerateMenu()
        {
            string result = $"{Name} have {counter} salads:" + Environment.NewLine;

            foreach (var salad in salads)
            {
                result = result + salad + Environment.NewLine;
            }

            return result.Trim();
        }
    }
}