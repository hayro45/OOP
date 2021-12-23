using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            Console.WriteLine();
            Console.WriteLine("************");
            Console.WriteLine();

            ILiving[] livings = new ILiving[]
            {
                new Manager(),
                new Worker()
            };
            foreach (var living in livings)
            {
                living.Eat();
                living.GetSalary();
            }
            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();

    }
    interface ILiving
    {
        void Eat();
        void GetSalary();
    }
    class Manager : IWorker, ILiving
    {
        public void Eat()
        {
            Console.WriteLine("the manager ate");
        }

        public void GetSalary()
        {
            Console.WriteLine("manager got paid");

        }

        public void Work()
        {
            Console.WriteLine("the manager worked");
        }
    }
    class Worker : IWorker, ILiving
    {
        public void Eat()
        {
            Console.WriteLine("the worker ate");

        }

        public void GetSalary()
        {
            Console.WriteLine("worker got paid");

        }

        public void Work()
        {
            Console.WriteLine("the worker worked");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("the robot worked");

        }
    }
}
