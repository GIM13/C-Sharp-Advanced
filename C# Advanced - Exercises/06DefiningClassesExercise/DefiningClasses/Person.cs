
namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {
            this.Name = "No name";

            this.Age = 1;
        }
        public Person(double age) :this()
        {
            this.Age = age;
        }
        public Person(double age, string name) : this(age)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public double Age { get; set; }
    }
}
