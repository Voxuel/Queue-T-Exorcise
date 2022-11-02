using System;
using System.Collections.Generic;
using System.Linq;
namespace ExcerciseQueue221102
{
    class Program
    {
        static void Main(string[] args)
        {
            var patientQue = new Queue<Patient> { };

            var p1 = new Patient("Joe", "Male", 13253, "2012-03-15", "Leprasy", false,true,"2015-03-15");
            var p2 = new Patient("Sara", "Female", 13244, "2012-01-07", "Scurvy", false,false,"2013-11-13");
            var p3 = new Patient("Bob", "Male", 15332, "2012-10-31", "Ligma", false,false,"2012-11-01");
            var p4 = new Patient("Sandra", "Female", 199329, "2012-06-08", "The heelees", false,true,"2012-07-07");
            var p5 = new Patient("DarkMagichian", "Unknown", 999999, "0001-01-01", "Consuming Darkness", false,true,"Never");


            patientQue.Enqueue(p1);
            patientQue.Enqueue(p2);
            patientQue.Enqueue(p3);
            patientQue.Enqueue(p4);
            patientQue.Enqueue(p5);

            var doc1 = new Doctor("Lars", "Male", 132533, 25345.33m);
            var doc2 = new Doctor("Cindy", "Female", 123243, 300000);
            var nurse = new Nurse("Bosse", "Male", 342325, 14000);

            var staffQue = new Queue<Person> { };
            staffQue.Enqueue(doc1);
            staffQue.Enqueue(doc2);
            staffQue.Enqueue(nurse);

            Console.WriteLine("-------------Patiens----------------");

            foreach (Patient patient in patientQue)
            {
                Console.WriteLine(patient.ToString());
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("-------------Staff----------------");
            foreach (Person staff in staffQue)
            {
                Console.WriteLine(staff.ToString());
                Console.WriteLine("-----------------");
            }
            while(patientQue.Count > 0)
            {
                nurse.Vaccinate(patientQue.Peek());
                patientQue.Dequeue();    
            }
            Console.WriteLine($"Patiens left to vaccinate : {patientQue.Count}");

        }
    }
}
