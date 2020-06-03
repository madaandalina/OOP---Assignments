using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Personala
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ion = Engine.CreatePerson("Popescu", "Ion", 
                new DateTime(1991, 4, 13),
                "ion.popescu@gmail.com");

            Person ioana = Engine.CreatePerson("Pop", "ioana",
               new DateTime(1990, 1, 17),
               "ioana.pop@gmail.com");

            Console.WriteLine();
            Activity gradinarit = ion.CreateActivity("gradinarit", "(plantat de rosii)",
                DateTime.Now, DateTime.Now.AddHours(1));

            Activity hobby = Engine.CreateActivity("sport", "(alergare)", 
                DateTime.Now, DateTime.Now.AddHours(3));
            Console.WriteLine();


            Console.WriteLine();
            ioana.AddActivity(gradinarit);
            ioana.AddActivity(hobby);
            Console.WriteLine();

            List<Activity> allactivities = ion.FindActivitiesByName("hobby");

            ioana.FindActivitiesByInterval(new DateTime(2020, 4, 23),
                new DateTime(2020, 4, 24));

            Console.WriteLine();
            Engine.DeleteActivity(gradinarit);
            Console.WriteLine();
            Engine.FindMeetingWithGroup(2, ion, ioana);


            Console.ReadLine();
        }
    }
}
