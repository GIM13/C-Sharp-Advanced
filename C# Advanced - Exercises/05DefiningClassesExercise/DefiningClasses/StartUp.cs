namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
           var firstPerson = new Person();
           var secondPerson = new Person();
           var thirdPerson = new Person();

           firstPerson.Name = "Pesho";
           firstPerson.Age = 20;

           secondPerson.Name = "Gosho";
           secondPerson.Age = 18;

           thirdPerson.Name = "Stamat";
           thirdPerson.Age = 43;
        }
    }
}
