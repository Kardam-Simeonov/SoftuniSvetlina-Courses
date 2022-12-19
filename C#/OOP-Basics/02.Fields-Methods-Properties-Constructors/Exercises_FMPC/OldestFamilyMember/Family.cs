using System.Collections.Generic;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers = new List<Person>();


        public void AddMember(Person inputPerson)
        {
            familyMembers.Add(inputPerson);
        }

        public Person GetOldestMember()
        {
            Person oldest = new Person();

            foreach (var person in familyMembers)
                if (person.Age > oldest.Age)
                    oldest = person;

            return oldest;
        }
    }
}