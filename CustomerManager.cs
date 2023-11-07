using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    internal class CustomerManager
    {
        private List<Customer> listOfCustomers; // defining a list for customers
        // constructor
        public CustomerManager()
        {
            listOfCustomers = new List<Customer>();
        }
        #region PROPERTIES
        public List<Customer> ListOfCustomers
        { get { return listOfCustomers; } }
        #endregion
        #region METHODS TO HANDEL THELIST
        public Customer GetCustometByIndex(int index)
        {
            if ( !CheckIndex(index))
                return null;

            return listOfCustomers[index];
        }
        public int Count // returnig the number of registered customers
        { 
            get { return listOfCustomers.Count; } 
        }
        public bool AddCustomer(string firstName, string lastName, Contact contactOfCustomer) //adding a customer
        {
            Customer newCustomer = new Customer(listOfCustomers.Count+1, firstName, lastName, contactOfCustomer);
            listOfCustomers.Add(newCustomer);
            return true;
        }
        public bool AddCustomer(Customer customerIn)// copy of the method of adding customer
        {
            if (customerIn == null)
                return false;
            listOfCustomers.Add(customerIn);
            return true;
        }
        public bool ChangeCustomerByIndex(int index, Customer customerIn)// this method will ahnge the customer's information
                                                                         // on a specific index
        { 
            if ( (customerIn != null) && (CheckIndex(index))) 
            {
                listOfCustomers[index] = customerIn;
                return true;
            }
            return false;
        }
        private bool CheckIndex(int index)// this method is for cheking the index which should be in range more than 0 and less that number of customers
        {
            if (index < 0 || index > listOfCustomers.Count)
                return false;
            return true;
        }
        public bool DeleteCustomerByIndex(int index)//deletening a customer
        {
            Customer customer = listOfCustomers[index];
            if (CheckIndex(index))
            {
                listOfCustomers.Remove(customer);// this line will remove the customer from the list
                for (int i = index; i < listOfCustomers.Count; i++)
                {
                    listOfCustomers[i].CustomId = i + 1;//this line will fix the customer id of the next customers.
                                                        //when a customer will be deleted, other customerId should change.
                    MessageBox.Show(listOfCustomers[i].CustomId.ToString());
                }
                return true;
            }
            return false;
        }
        public int NumberOfCustomer()
        { return listOfCustomers.Count; }
        



        #endregion
    }
}
