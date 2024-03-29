namespace WebApplication3.TempDb
{
    using System.Collections.Generic;
    using System.Linq;
    using WebApplication3.Models;

    public static class MockDatabase
    {
        public static List<Person> Persons { get; set; } = new List<Person>
        {
            new Person { Id = 1, FirstName = "John", LastName = "Doe"},
            new Person { Id = 2, FirstName = "Emily", LastName = "Johnson"},
            new Person { Id = 3, FirstName = "Olivia", LastName = "Smith" },
            new Person { Id = 4, FirstName = "William", LastName = "Davis"},
            new Person { Id = 5, FirstName = "Sophia", LastName = "Doe"},
            new Person { Id = 6, FirstName = "Ethan", LastName = "Wilson" }
       
            // add more initial data if necessary
        };

        public static List<Person> GetAll()
        {
            return Persons;
        }
        public static Person GetById(int id)
        {
            return Persons.FirstOrDefault(p => p.Id == id);
        }

        public static void Create(Person person)
        {
            int newId = Persons.Count > 0 ? Persons.Max(p => p.Id) + 1 : 1;
            person.Id = newId;
            Persons.Add(person);
        }

        public static void Update(int id, Person updatedPerson)
        {
            var existingPerson = Persons.FirstOrDefault(p => p.Id == id);
            if (existingPerson != null)
            {
                existingPerson.FirstName = updatedPerson.FirstName;
                existingPerson.LastName = updatedPerson.LastName;
                // update other fields as necessary
            }
        }

        public static bool Delete(int id)
        {
            var person = Persons.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                return false;
            }
            Persons.Remove(person);
            return true;
        }

        // Add more methods to mimic database operations (e.g., update, delete) as needed.
    }

}
