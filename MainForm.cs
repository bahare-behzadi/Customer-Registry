using System.Windows.Forms;

namespace assignment5
{
    public partial class MainForm : Form
    {
        ContactForm contactForm;
        CustomerManager customerManager;
        public MainForm()
        {
            this.Text = "Customer registery by Bahareh Behzadi";//showing thw nameof writer on top of the form
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            customerManager = new CustomerManager();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            ContactForm dlg = new ContactForm();//constructing a new form
            dlg.Text = "Add new customer";
            dlg.FormClosed += (s, args) =>
            {
                if (dlg.DialogResult == DialogResult.OK)
                {
                    customerManager.AddCustomer(dlg.FirstName, dlg.LastName, dlg.CurrContact);
                    int index = customerManager.Count;
                    allcustomerslistView.Items.Add(string.Format("{0, -10} {1, -95} {2, -50} {3}",
                        index.ToString(), string.Format("{0} {1}", dlg.FirstName, dlg.LastName), dlg.CurrContact.ContactPhone.PhoneNumber, dlg.CurrContact.ContactEmail.Work));
                }
                // Handle other cases as needed. this is because in the ontact form i have another message box
                // and the program should be abel to handel that case also.
            };
            dlg.Show();// show instead of showdialog for the above reason.
        }



        private void editButton_Click_1(object sender, EventArgs e)
        {
            ContactForm dlg = new ContactForm();
            dlg.Text = "Edit customer";
            if (allcustomerslistView.SelectedItems != null)
            {
                int index = FindingSelectedCustomersIndex();
                Customer editingcustomer = new Customer(customerManager.GetCustometByIndex(index));
                string[] customerIn = new string[10];
                customerIn[0] = editingcustomer.FirstName;
                customerIn[1] = editingcustomer.LastName;
                customerIn[2] = editingcustomer.ContactInfo.ContactPhone.PhoneNumber;
                customerIn[3] = editingcustomer.ContactInfo.ContactPhone.Mobilenumber;
                customerIn[4] = editingcustomer.ContactInfo.ContactEmail.Personal;
                customerIn[5] = editingcustomer.ContactInfo.ContactEmail.Work;
                customerIn[6] = editingcustomer.ContactInfo.ContactAdress.Street;
                customerIn[7] = editingcustomer.ContactInfo.ContactAdress.City;
                customerIn[8] = editingcustomer.ContactInfo.ContactAdress.ZipCode;
                int selectedIndex = (int)editingcustomer.ContactInfo.ContactAdress.Countries;
                customerIn[9] = selectedIndex.ToString();
                dlg.ShowEditingCustomer(customerIn);//sending the selected customer's information to the cotact form.
                int ListBoxEditedIndex = allcustomerslistView.SelectedIndex;// finding the index of selected item on the listBox
                allcustomerslistView.Items.RemoveAt(ListBoxEditedIndex);
                dlg.FormClosed += (s, args) =>
                {
                    if (dlg.DialogResult == DialogResult.OK)
                    {
                        editingcustomer = new Customer(index, dlg.FirstName, dlg.LastName, dlg.CurrContact);
                        customerManager.ChangeCustomerByIndex(index, editingcustomer);
                        index++;
                        allcustomerslistView.Items.Insert(ListBoxEditedIndex, string.Format("{0, -10} {1, -95} {2, -50} {3}",
                            index.ToString(), string.Format("{0} {1}", dlg.FirstName, dlg.LastName),
                            dlg.CurrContact.ContactPhone.PhoneNumber, dlg.CurrContact.ContactEmail.Work));
                        customerDetailsRichTextBox.Text = string.Empty;
                    }
                    // Handle other cases as needed.
                };
                dlg.Show();
                
            }
            else
            {
                MessageBox.Show("You should select an Item first! Then you can edit it.", "Error");
            }

        }


        private void deletebutton_Click(object sender, EventArgs e)
        {
            int index = FindingSelectedCustomersIndex();
            customerManager.DeleteCustomerByIndex(index);
            allcustomerslistView.Items.Clear();//refreshing the listBox with new list
            foreach (Customer customer in customerManager.ListOfCustomers)
            {
                allcustomerslistView.Items.Add(string.Format("{0, -10} {1, -70} {2, -30} {3}",
                                            customer.CustomId.ToString(), string.Format("{0} {1}", customer.FirstName, customer.LastName),
                                            customer.ContactInfo.ContactPhone.PhoneNumber, customer.ContactInfo.ContactEmail.Work));
            }
        }
        private int FindingSelectedCustomersIndex()//this is a method for finding the index of selected item on listbox.
        {
            string selectedItem = allcustomerslistView.SelectedItems[0].ToString();
            string id = selectedItem.Substring(0, 5).Trim();
            int index = int.Parse(id) - 1;
            return index;
        }
        //this is for showing the customer's detil when an item on listbox is chosen
        private void allcustomerslistView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (allcustomerslistView.SelectedIndex != -1)
            {
                customerDetailsRichTextBox.Text = string.Empty;
                Customer selectedCustomer = new Customer(customerManager.GetCustometByIndex(FindingSelectedCustomersIndex()));
                customerDetailsRichTextBox.Text = string.Format("{0} {1}", selectedCustomer.FirstName, selectedCustomer.LastName) +
                    "\n" + selectedCustomer.ContactInfo.ContactAdress.ToString() +
                     selectedCustomer.ContactInfo.ContactEmail.ToString() +
                     selectedCustomer.ContactInfo.ContactPhone.ToString();
            }
        }
    }
}