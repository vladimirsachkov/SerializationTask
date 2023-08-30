using SerializationTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTask.Service
{
    internal class PersonGeneration
    {
        private int count;
        public PersonGeneration(int count) {
            this.count = count;
        }

        public List<Person> generatePersons()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                Person person = new Person();
                people.Add(person);
            }
            return people;
        }
    }
}
