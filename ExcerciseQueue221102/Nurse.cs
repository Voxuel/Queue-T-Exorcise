using System;
using System.Collections.Generic;
using System.Text;

namespace ExcerciseQueue221102
{
    class Nurse : Person
    {
        public int WorkHours { get; set; }
        public Nurse(string _name, string _gender, int _id, int _workHours) : base(_name,_gender,_id)
        {
            WorkHours = _workHours;
            Role = "Nurse";
        }
        public void TakeBloodTest()
        {
            Console.WriteLine($"Nurse {Name} takes your blood");
        }
        public bool Vaccinate(Patient p)
        {
            return p.IsVaccinated = true;
        }
        public override string ToString()
        {
            return $"ID : {ID} \nName : {Name}\nRole : {Role}\nWorkHours : {WorkHours}";
        }
    }
}
