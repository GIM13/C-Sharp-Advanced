using System;
using System.Linq;
using System.Collections.Generic;

namespace Rabbits
{
    internal class Cage
    {
        private int data;

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            var Rabbits = new List<Rabbit>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Rabbit> Rabbits { get; set; }

       

        internal void Add(Rabbit rabbit)
        {
            if (Rabbits.Count < Capacity)
            {
                Rabbits.Add(rabbit);

                data++;
            }
        }

        internal bool RemoveRabbit(string rabbitName)
        {
            var result = Rabbits.FirstOrDefault(x => x.Name == rabbitName);

            if (result != null)
            {
                Rabbits.Remove(result);

                return true;
            }
            return false;
        }

        internal Rabbit SellRabbit(string species)
        {
            for (int i = 0; i < Rabbits.Count; i++)
            {
                var result = Rabbits.FirstOrDefault(x => x.Species == species);

                if (result != null)
                {
                    Rabbits.Remove(result);
                }
                return result
            }
        }

        internal Rabbit[] SellRabbitsBySpecies(string v)
        {
            throw new NotImplementedException();
        }

        internal bool Report()
        {
            throw new NotImplementedException();
        }
    }
}