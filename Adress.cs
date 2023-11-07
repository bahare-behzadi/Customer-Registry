using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    internal class Adress
    {
        // defining needed variables
        private string street;
        private string zipCode;
        private string city;
        private Countries country;

        #region CONSTRUCTORS
        /// <summary>
        /// constructors with 4 operators used by other constructors too.
        /// compiler gives null to string variable for initializing so it is better that
        /// we give them initialized values in constructors.
        /// </summary>
        public Adress(string street, string zipCode, string city, Countries country)
        {
            this.street = street;
            this.zipCode = zipCode;
            this.city = city;
            this.country = country;
        }
        public Adress(string street, string zipCode, string city):
            this(street, zipCode, city, Countries.Sverige)
        { }
        public Adress() : this(string.Empty, string.Empty, string.Empty, Countries.Sverige)
        { }
        public Adress(Adress theoth): this(theoth.street, theoth.zipCode, theoth.city, theoth.country)
        { }
        #endregion

        #region PROPERTIES
        // this is the part for defining the properties for customer's adress
        // these lines are used becuase the program should have access to the contact information details.
        public string Street
        {   
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set
            { 
                if (!string.IsNullOrEmpty(value))
                    city = value; 
            }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public Countries Countries
        {
            get { return country; }
            set { country = value; }
        }
        #endregion

        #region Other Methods

        // this code will remove the "_" in countries which have more than one part.
        public string GetCountryString()
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }
        /// some checking of data is needed. Adress must have a city and a country.
        /// country has always a default value (Sverige) and its type is enum.
        /// city does not have a default and is must_have field so we should validate it.
        /// the rest of adress can be null.
        public bool ValidateCity()
        {
            bool cityIsOk = !string.IsNullOrEmpty(city);
            return cityIsOk;
        }
        // with this code we have the adress in several lines
        public string GetAdressLabel()
        {
            string adressLabel = street + Environment.NewLine;
            adressLabel += ZipCode + " " + City;
            return adressLabel;
        }
        // this code is overide of tostring() for returning the adress in a line.
        public override string ToString()
        {
            string adressLabel = string.Format("{0, -25} {1, -8} {2, -10} {3}", street, zipCode, city, GetCountryString());
            return adressLabel;
        }
        #endregion
    }

}
