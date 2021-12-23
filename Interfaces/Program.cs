using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonEkle();

        }

        private static void PersonEkle()
        {
            Customer customer = new Customer() { Id = 1, FirstName = "Hayrettin", LastName = "Dal", Adress = "Çukur Mah." };
            Student student = new Student() { Id = 2, FirstName = "Zeynep", LastName = "Dal", Departmant = "Midwife" };

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
