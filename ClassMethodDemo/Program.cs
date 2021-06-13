using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Steve";
            customer1.Surname = "Works";
            customer1.Gender = "Male";
            customer1.Balance = 100000;
            customer1.Debt = 5000000;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Elon";
            customer2.Surname = "Tusk";
            customer2.Gender = "Male";
            customer2.Balance = 900000;
            customer2.Debt = 75000;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Rick";
            customer3.Surname = "Morty";
            customer3.Gender = "Male";
            customer3.Balance = 100;
            customer3.Debt = 30000;

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Olivia";
            customer4.Surname = "Dunham";
            customer4.Gender = "Female";
            customer4.Balance = 60000;
            customer4.Debt = 10000;

            CustomerManager manager1 = new CustomerManager();
            manager1.Add(customer1);
            manager1.Add(customer2);
            manager1.Add(customer3);
            manager1.Add(customer4);

            Console.WriteLine("*******************************************************************************");
            
            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4 };

            
            manager1.List(customers);

            Console.WriteLine("*******************************************************************************");

            manager1.AvailableBalance(customer1);
            manager1.AvailableBalance(customer3);
            manager1.AvailableBalance(customer2);
            manager1.AvailableBalance(customer4);

            Console.WriteLine("*******************************************************************************");

            manager1.Delete(customer3);
            manager1.Delete(customer4);
            manager1.Delete(customer1);

        }
    }
}
