using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01JorgeVargas;

namespace Lab01.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Person");
            // Person person = new Person();

            //person.Id = 1;
            //person.Name = "Juan";
            //person.LastName = "Perez";

            //Segunda Forma

            Person person = new Person(1, "Juan", "Perez");

            //ILogger logger = person;
            //Tercera Forma

            //Person person = new Person
            //{
             //   Id = 1,
             //   Name = "Juan",
             //   LastName = "Perez"
            //};


            string personString = string.Format("Id:{0}, Name: {1}, LastName:{2}", person.Id, person.Name, person.LastName);
            System.Console.WriteLine(personString);
            person.log("Hola");
            System.Console.ReadKey();

        }
    }

    internal interface ILogger
    {
    }
}
