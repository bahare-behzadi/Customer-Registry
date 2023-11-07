using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    internal class Phone
    {
        //private email
        private string phoneNumber;
        //officeMail mail
        private string mobileNumber;

        //Constructors are overloaded and called in a chain

        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        /// <remarks></remarks>
        public Phone():this(string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// Constructor with one parameter - calls the constructor with 
        /// two parameters, using a default value as the second argument.
        /// </summary>
        /// <param name="phoneNumber">input coming from the client object</param>
        /// <remarks></remarks>
        public Phone(string phoneNumber) : this(phoneNumber, string.Empty)
        {
        }
        /// <summary>
        /// Copy constructor returning copy
        /// </summary>
        public Phone(Phone theOther): this(theOther.phoneNumber, theOther.mobileNumber) 
        {
        }
        /// <summary>
        /// Constructor with two parameters. This is  constructor that has most
        /// number of parameters. It is in tis constructor that all coding 
        /// should be done.
        /// </summary>
        /// <param name="phoneNumber">Input - phone number</param>
        /// <param name="mobileNumber">Input - mobile number</param>
        /// <remarks></remarks>
        public Phone(string phoneNumber, string mobileNumber)
        {
            this.phoneNumber = phoneNumber;
            this.mobileNumber = mobileNumber;
        }

        /// <summary>
        /// Property related to the field Phone number
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string PhoneNumber
        {
            //private mail
            get { return phoneNumber; }

            set { phoneNumber = value; }
        }


        /// <summary>
        /// Property related to mobile number field
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Mobilenumber
        {
            get { return mobileNumber; }

            set { mobileNumber = value; }
        }

        /// <summary>
        /// This method prepares a format string that is in sync with the ToString
        /// method.  It will be used in the MainForm as part of the heading for the ListBox
        /// before customer information is added in the ListBox.
        /// </summary>
        /// <value></value>
        /// <returns>A formatted string as heading for the values formatted in the ToString
        /// method below.</returns>
        /// <remarks></remarks>
        public string GetToStringItemsHeadings
        {
            get { return string.Format("{0,-20} {1, -20}", "Phone number", "Mobile Number"); }
        }

        /// <summary>
        /// Delivers a formatted string with data stored in the object. The values will
        /// appear as columns.  Make sure that a font like "Courier New" is used in
        /// the control displaying this information.
        /// </summary>
        /// <returns>the Formatted strings.</returns>
        /// <remarks></remarks>
        public override string ToString()
        {
            string strOut = "\n" + "Phone numbers" + "\n";

            strOut += string.Format(" {0,-10} {1, -10}\n", "Private", phoneNumber);
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Office", mobileNumber);

            return strOut;
        }
    }
}
