using System;

namespace _06EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (Name.CompareTo(other.Name) != 0)
            {
                return Name.CompareTo(other.Name); 
            }

            if (Age.CompareTo(other.Age) != 0)
            {
                return Age.CompareTo(other.Age);
            }

            return 0;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Age.GetHashCode() ;
        }
        public override bool Equals(object obj)
        {
            var objec = obj as Person;

            if (objec.Name == this.Name && objec.Name == this.Name)
            {
                return true;
            }

            return false;
        }
    }
}
