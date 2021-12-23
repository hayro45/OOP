using System;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            Two();
        }

        private static void One()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }
        private static void Two()
        {
            ICustomerDal[] customerDals= new ICustomerDal[2]
            {
                new OracleCustomerDal(),
                new SqlServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }
    }
}
