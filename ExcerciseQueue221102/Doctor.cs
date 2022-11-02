using System;
using System.Collections.Generic;
using System.Text;

namespace ExcerciseQueue221102
{
    class Doctor : Person
    {
        public decimal Salery { get; set; }

        public Doctor(string _name, string _gender, int _id, decimal _salery) : base(_name, _gender,_id)
        {
            Salery = _salery;
            Role = "Doctor";
        }
        public void WriteRecipe(Patient p)
        {
            if (!p.HasRecipe)
            {
                Console.WriteLine($"Dr.{Name} writes you a recipe");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        public override string ToString()
        {
            return $"ID : {ID} \nName : {Name}\nRole : {Role}\nSalery : {Salery}";
        }
    }
}
