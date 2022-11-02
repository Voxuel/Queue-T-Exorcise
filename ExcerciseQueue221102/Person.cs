using System;
using System.Collections.Generic;
using System.Text;

namespace ExcerciseQueue221102
{
    class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int ID { get; set; }
        public string Role { get; set; }

        public Person(string _name, string _gender, int _id)
        {
            Name = _name;
            Gender = _gender;
            ID = _id;
        }
    }
}
