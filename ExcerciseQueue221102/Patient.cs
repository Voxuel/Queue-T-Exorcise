using System;
using System.Collections.Generic;
using System.Text;

namespace ExcerciseQueue221102
{
    class Patient : Person
    {
        public string RegIn { get; set; }
        public string RegOut { get; set; }
        public string DownWithTheSickness { get; set; }
        public bool IsVaccinated { get; set; }
        public bool HasRecipe { get; set; }

        public Patient(string _name,string _gender, int _id, string _regIn, string _sick, bool _isVacc, bool _hasRep,string _regOut) 
            : base(_name,_gender,_id)
        {
            RegIn = _regIn;
            RegOut = _regOut;
            DownWithTheSickness = _sick;
            IsVaccinated = _isVacc;
            HasRecipe = _hasRep;
            Role = "Patient";
        }
        public override string ToString()
        {
            return $"ID : {ID} \nName : {Name}\nRole : {Role}\nDisease : {DownWithTheSickness}\nHas a recipe : {HasRecipe}" +
                $"\nDay of entry : {RegIn}\nDay discharged : {RegOut}";
        }

    }
}
