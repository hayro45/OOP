using System;

namespace Recapdemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new DatabaseLogger();
            customerManager.Add();
        }
    }
    class CustomerManager
    {
        public ILogger logger { get; set; }
        public void Add()
        {
            logger.Log();
        }
    }
    
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to database!");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to file!");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
