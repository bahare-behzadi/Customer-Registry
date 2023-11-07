using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    internal class Contact
    {
        private Adress contactAdress = new Adress();
        private Phone contctPhone = new Phone();
        private Email contctEmail = new Email();
        
        #region CONSTRUCTORS
        /// <summary>
        /// constructors with 4 operators used by other constructors too.
        /// compiler gives null to string variable for initializing so it is better that
        /// we give them initialized values in constructors.
        /// </summary>
        public Contact(Adress contactAdress, Phone contctPhone, Email contctEmail)
        {
            this.contactAdress = contactAdress;
            this.contctPhone = contctPhone;
            this.contctEmail = contctEmail;
        }
        public Contact(Contact theoth) : this( theoth.contactAdress, theoth.contctPhone, theoth.contctEmail)
        { }

        public Contact()
        {
        }
        #endregion

        #region PROPERTIES
        public Adress ContactAdress
        { 
            set { contactAdress = value; }
            get { return contactAdress; } 
        }
        public Phone ContactPhone 
        { 
            set {  contctPhone = value; }
            get { return contctPhone; } 
        }
        public Email ContactEmail
        {
            set { contctEmail = value; }
            get { return contctEmail; }
        }
        #endregion

        #region Other Methods
        public string GetContantDetails()
        {
            string contantDetail = contactAdress + "\n\n" + contctEmail + "\n\n" + contctPhone;
            return contantDetail;
        }
        #endregion
    }
}
