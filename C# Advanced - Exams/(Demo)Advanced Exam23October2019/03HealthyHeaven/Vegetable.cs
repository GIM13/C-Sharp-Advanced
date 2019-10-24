
namespace HealthyHeaven
{
    public class Vegetable
    {
        public Vegetable(string name,int calories)
        {
            Calories = calories;

            Name = name;
        }

        public int Calories { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $" - {Name} have {Calories} calories";
        }
    }
}
