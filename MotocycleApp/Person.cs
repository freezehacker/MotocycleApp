using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotocycleApp
{
    public class Person
    {
        public Person() { }
        public Person(string name, string id, DateTime birthDate, Gender gender)
        {
            this.name = name;
            this.id = id;
            this.birthDate = birthDate;
            this.gender = gender;
        }
        public string name { get; set; }
        public string id { get; set; }
        public DateTime birthDate { get; set; }
        public Gender gender { get; set; }

        public enum Gender
        {
            MALE = 1,
            FEMALE
        }
    }
}
