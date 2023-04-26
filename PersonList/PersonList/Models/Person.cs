using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public void UpdateData(Person person)
        {
            Name = person.Name;
            Sex = person.Sex;
            Age = person.Age;
        }
                
    }
}
