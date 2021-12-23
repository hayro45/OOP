using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces1
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Server Customer Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server Customer Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Server Customer Updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Customer Added");

        }

        public void Delete()
        {
            Console.WriteLine("Oracle Customer Deleted");

        }

        public void Update()
        {
            Console.WriteLine("Oracle Customer Updated");

        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customer)
        {
            customer.Add();
        }
    }
}
