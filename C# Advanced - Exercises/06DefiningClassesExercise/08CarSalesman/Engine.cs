
namespace _08CarSalesman
{
    public class Engine
    {
        public Engine(string model, string power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, string power, int displacement)
            : this(model, power)
        {
            Displacement = displacement;
        }

        public Engine(string model, string power, string color)
            : this(model, power)
        {
            Efficiency = color;
        }

        public Engine(string model, string power, int displacement, string efficiency)
            : this(model, power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model { get; set; }

        public string Power { get; set; }

        public int Displacement { get; set; } 

        public string Efficiency { get; set; } = "n/a";
    }
}
