using JsonParser;
using System.Collections.Generic;
using System.IO;
using System;

namespace JsonParserProgram
{
    class School
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public School(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public School School { get; set; }

        public Person(int id, string firstname, string lastname, School school)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            School = school;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Firstname: {Firstname}, Lastname: {Lastname}, School: {School}";
        }
    }

    class Program
    {
        static void Main()
        {
            Person person = new Person(1, "alx", "brn", new School(72, "Alien School"));
            string json = person.Parse();

            Console.WriteLine(json);

            Person newPerson = json.Parse<Person>();

            Console.WriteLine(newPerson);
        }
    }
}
