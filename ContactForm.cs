using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace assignment5
{
    public partial class ContactForm : Form
    {
        Contact currcontact;
        //cunstruction for contact form
        #region CONSTRUCTION
        public ContactForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = " ";
            FillTheComboBox();
            currcontact = new Contact();
        }
        #endregion
        #region PROPERTIES
        // this property is for the times that the program needs to access
        // to the first name of a customer i the form
        public string FirstName
        {
            get { return firstNameTextBox.Text; }
        }
        // this property is for the times that the program needs to access
        // to the last name of a customer i the form
        public string LastName
        {
            get { return lastNameTextBox.Text; }
        }
        // this property is for the times that the program needs to access
        // to the contact information of a customer i the form
        internal Contact CurrContact
        {
            get { return currcontact; }
        }


        #endregion
        private void ContactForm_Load(object sender, EventArgs e)
        {

        }
        // this method is for fillig the combobox with the countries which are in the enum
        private void FillTheComboBox()
        {
            comboBoxCountry.Items.Clear();
            var countries = Enum.GetValues(typeof(Countries));
            foreach (var country in countries)
            {
                comboBoxCountry.Items.Add(country);
            }
            comboBoxCountry.SelectedIndex = 164;
        }
        // this method is for saving contact details in a contact object
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (readName() && readLastName())// I supposed that the user can save the name of a customer
                                             // without having the contact information details. it is possible for the user
                                             // to save just the name of the customer and edit the contact informtion latter.
            {
                currcontact.ContactAdress.City = textBoxCity.Text;
                currcontact.ContactAdress.Street = textBoxStreet.Text;
                currcontact.ContactAdress.ZipCode = textBoxZipode.Text;
                currcontact.ContactAdress.Countries = (Countries)comboBoxCountry.SelectedItem;
                currcontact.ContactPhone.PhoneNumber = textBoxHomePhone.Text;
                currcontact.ContactPhone.Mobilenumber = textBoxCellPhone.Text;
                currcontact.ContactEmail.Personal = textBoxEmailPrivate.Text;
                currcontact.ContactEmail.Work = textBoxEmailBusiness.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        // this method is for filling the text boxes with the information whih are existed now in the form
        public void ShowEditingCustomer(string[] customerIn)
        {
            firstNameTextBox.Text = customerIn[0];
            lastNameTextBox.Text = customerIn[1];
            textBoxHomePhone.Text = customerIn[2];
            textBoxCellPhone.Text = customerIn[3];
            textBoxEmailPrivate.Text = customerIn[4];
            textBoxEmailBusiness.Text = customerIn[5];
            textBoxStreet.Text = customerIn[6];
            textBoxCity.Text = customerIn[7];
            textBoxZipode.Text = customerIn[8];
            comboBoxCountry.SelectedIndex = int.Parse(customerIn[9]);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
            // Display a confirmation message box.
            //the messgeBox is a yesno messagebox beacuse if the user was not sure about cancelling
            //can return back and contunue with the contact form.
            DialogResult result = MessageBox.Show("Do you want to cancel and discard changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.ToString() == "Yes")
            {
                // User clicked Yes, close the form without saving changes.
                Close();
            }
            // If the user clicked No or closed the message box, do nothing and keep the form open. 
        }
        // these two next method are for checking that the customer atleast has a customer first name and last anme.
        private bool readName() 
        {
            if (firstNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("First name of the customer can not be empty!", "Errore");
                return false;
            }
            else
            return true;
        }
        private bool readLastName()
        {
            if (!string.IsNullOrEmpty(lastNameTextBox.Text))
                return true;
            else
            {
                MessageBox.Show("Last name of the customer can not be empty!", "Errore");
                return false;
            }
        }

    }
}
