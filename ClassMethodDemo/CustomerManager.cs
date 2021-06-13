using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer) 
        {
            if (customer.Gender == "Male")
            {
                customer.Gender = "Mr";
            }
            else
            {
                customer.Gender = "Mrs";
            }

            Console.WriteLine(customer.Gender +" "+ customer.Name + " " + customer.Surname+ " "+"Register complete! ");
        }
        public void List(Customer[] customers)
        {

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + " "+ customer.Gender + " " + customer.Name + " " + customer.Surname + " " + customer.Balance + " " + customer.Debt);
            }

        }
    
        public void AvailableBalance(Customer customer)
        {
          
            int Available = customer.Balance - customer.Debt;
            if (customer.Balance>customer.Debt)
            {
                Console.WriteLine(customer.Gender+" "+ customer.Name+ " " +"Your balance is " + Available);
            }
            else
            {
                Console.WriteLine(customer.Gender+" " +customer.Name+" "+"Your debt is " + Available);
            }
            
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Gender+ " "+customer.Name+" "+ customer.Surname+" "+"Your account have deleted! " );
        }
    }
}
