using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Firstname + " " + "Müşterisi Eklendi..");

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Firstname + " " + "Müşterisi Silindi..");

        }

        public void List(Customer[] customers)
        {
            foreach(var customer in customers)
            {

                Console.WriteLine(customer.Firstname + " " + customer.Lastname + " "
                    + customer.Id + " " + customer.Old);
                
            }

        }
    }
}
