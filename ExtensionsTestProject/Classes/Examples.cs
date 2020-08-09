using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsTestProject.Classes
{
    class Examples
    {
        public void ToListExample()
        {
            Person[] people = new[] {new Person(), new Person()};
            List<Person> persons = people.ToList();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
