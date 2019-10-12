
namespace _08CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int weight) 
            : this(model,engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight  { get; set; } 

        public string Color  { get; set; } = "n/a";

        public override string ToString()
        {
            string engineDisplacement = "n/a";

            if (Engine.Displacement != 0)
            {
                engineDisplacement = string.Empty + Engine.Displacement;
            }
            string weight = "n/a";

            if (Weight!= 0)
            {
                weight = string.Empty + Weight;
            }

            return $"{Model}:\n" +
                   $"  {Engine.Model}:\n" +
                   $"    Power: {Engine.Power}\n" +
                   $"    Displacement: {engineDisplacement}\n" +
                   $"    Efficiency: {Engine.Efficiency}\n" +
                   $"  Weight: {weight}\n" +
                   $"  Color: {Color}";
        }
    }
}
