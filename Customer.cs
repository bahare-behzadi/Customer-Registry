using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    internal class Customer
    {
        // defining the variables which are neede for the method.
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private int customId = 0;
        private Contact contactInfo;
        #region CONSTRUCTOR
        /// <summary>
        /// constructors with 4 operators used by other constructors too.
        /// compiler gives null to string variable for initializing so it is better that
        /// we give them initialized values in constructors.
        /// </summary>
        public Customer(int customId, string firstName, string lastName, Contact contactInfo)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || contactInfo == null || customId < 0) 
            {
                MessageBox.Show("Name and contact information must be provided.", "Error");
            }

            this.firstName = firstName;
            this.lastName = lastName;
            this.contactInfo = contactInfo;
            this.customId = customId;
        }
        public Customer(Customer customer) : this(customer.customId, customer.firstName, customer.lastName, customer.contactInfo)
        { }
        #endregion
        #region PEROPERTIES
        // this is the part for defining the properties for customer's adress
        // these lines are used becuase the program should have access to the contact information details.
        public string FirstName
        { 
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    FirstName = value; 
            }
            get { return firstName; } 
        }
        public string LastName
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                    LastName = value;
            }
            get { return lastName; }
        }
        public int CustomId
        { 
            set 
            { 
                if (value > 0)
                    customId = value;
            }
            get { return customId; } 
        }
        public Contact ContactInfo
        {
            set
            {
                if (value != null)
                {
                    contactInfo = value;
                }
            }
            get { return contactInfo; }
        }
        #endregion
    }
}
