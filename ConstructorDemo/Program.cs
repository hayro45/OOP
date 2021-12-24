using System;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entiy)
        {
            _entity = entiy;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)
        {
                
        }
    }
}
