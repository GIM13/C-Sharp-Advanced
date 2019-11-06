using System;
using System.Linq;
using System.Collections.Generic;

namespace Rabbits
{
    public class Cage
    {
        private int data;

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Rabbits = new List<Rabbit>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Rabbit> Rabbits { get; set; }

        public int Count { get; private set; }

        public void Add(Rabbit rabbit)
        {
            if (Rabbits.Count < Capacity)
            {
                Rabbits.Add(rabbit);

                data++;

                Count++;
            }
        }

        public bool RemoveRabbit(string rabbitName)
        {
            var result = Rabbits.FirstOrDefault(x => x.Name == rabbitName);

            if (Rabbits.Contains(result))
            {
                Rabbits.Remove(result);

                Count--;

                Console.WriteLine("true");
                return true;
            }

            Console.WriteLine("false");
            return false;
        }

        public void RemoveSpecies(string species)
        {
            List<Rabbit> result = Rabbits.Where(x => x.Species != species).ToList();

            Count -= result.Count;

            Rabbits = result;
        }

        public Rabbit SellRabbit(string rabbitName)
        {
            var result = Rabbits.FirstOrDefault(x => x.Name == rabbitName);

            Rabbits.FirstOrDefault(x => x.Name == rabbitName).Available = false;

            Count--;

            return result;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            foreach (var rabbit in Rabbits)
            {
                if (rabbit.Species == species)
                {
                    rabbit.Available = false;

                    Count--;
                }
            }

            return Rabbits.Where(x => x.Species == species).ToArray();
        }

        public string Report()
        {
            string result = $"Rabbits available at {Name}:" + Environment.NewLine;

            foreach (var rabbit in Rabbits)
            {
                if (rabbit.Available == true)
                {
                    result += rabbit + Environment.NewLine;
                }
            }

            return result;
        }
    }
}