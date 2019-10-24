using System;
using System.Collections.Generic;

namespace HealthyHeaven
{
    public class Salad
    {
        private int calories;

        private List<Vegetable> products;

        public Salad(string name)
        {
            Name = name;

            products = new List<Vegetable>();
        }

        public string Name { get; set; }

        public override string ToString()
        {
            calories = GetTotalCalories();

            string result = $"* Salad {Name} is {calories} calories and have {products.Count} products:" + Environment.NewLine;

            foreach (var product in products)
            {
                result = result + product + Environment.NewLine;
            }

            return result.Trim();
        }

        public int GetTotalCalories()
        {
            calories = 0;

            foreach (var product in products)
            {
                calories += product.Calories;
            }
            return calories;
        }

        public int GetProductCount()
        {
            return products.Count;
        }

        public void Add(Vegetable product)
        {
            products.Add(product);
        }
    }
}
