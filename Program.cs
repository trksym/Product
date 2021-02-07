using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Firstname = "Ayşe";
            customer1.Lastname = "Bulut";
            customer1.Id = 34567;
            customer1.Old = 36;

            Customer customer2 = new Customer();
            customer2.Firstname = "Zeynep";
            customer2.Lastname = "Kurt";
            customer2.Id = 89767;
            customer2.Old = 27;

            Customer customer3 = new Customer();
            customer3.Firstname = "Mustafa";
            customer3.Lastname = "Güneş";
            customer3.Id = 56467;
            customer3.Old = 42;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);

            Console.WriteLine("............");

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            customerManager.List(customers);
        }

        
        
    }

    
    }
