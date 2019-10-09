using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public Family(List<Person> persons)
        {
            Members = persons;
        }

        public List<Person> Members { get; set; }

        public void AddMember(Person member)
        {
            if (!Members.Contains(member))
            {
                Members.Add(member);
            }
        }

        public Person GetOldestMember()
        {
            // var oldestMember = Members
            //     .OrderByDescending(x => x.Age)
            //     .FirstOrDefault();
            var oldestMember = new Person(0);

            foreach (var person in Members)
            {
                if (oldestMember.Age < person.Age)
                {
                    oldestMember.Age = person.Age;
                    oldestMember.Name = person.Name;
                }
            }

            return oldestMember;
        }
    }
}
