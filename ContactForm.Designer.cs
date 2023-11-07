namespace assignment5
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NamegroupBox = new GroupBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNamelabel = new Label();
            firstNamelabel = new Label();
            emailPhonegroupBox = new GroupBox();
            textBoxHomePhone = new TextBox();
            textBoxCellPhone = new TextBox();
            textBoxEmailBusiness = new TextBox();
            textBoxEmailPrivate = new TextBox();
            emailPrivatelabel = new Label();
            emailbusinesslabel = new Label();
            cellPhonelabel = new Label();
            homephonelabel = new Label();
            adressGroupBox = new GroupBox();
            comboBoxCountry = new ComboBox();
            labelCountry = new Label();
            textBoxZipode = new TextBox();
            textBoxCity = new TextBox();
            textBoxStreet = new TextBox();
            ZipCodelabel = new Label();
            City = new Label();
            streetlabel = new Label();
            buttonOk = new Button();
            buttonCancel = new Button();
            NamegroupBox.SuspendLayout();
            emailPhonegroupBox.SuspendLayout();
            adressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // NamegroupBox
            // 
            NamegroupBox.Controls.Add(lastNameTextBox);
            NamegroupBox.Controls.Add(firstNameTextBox);
            NamegroupBox.Controls.Add(lastNamelabel);
            NamegroupBox.Controls.Add(firstNamelabel);
            NamegroupBox.Location = new Point(29, 38);
            NamegroupBox.Name = "NamegroupBox";
            NamegroupBox.Size = new Size(580, 167);
            NamegroupBox.TabIndex = 0;
            NamegroupBox.TabStop = false;
            NamegroupBox.Text = "Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(146, 102);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(391, 31);
            lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(146, 52);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(391, 31);
            firstNameTextBox.TabIndex = 2;
            // 
            // lastNamelabel
            // 
            lastNamelabel.AutoSize = true;
            lastNamelabel.Location = new Point(26, 107);
            lastNamelabel.Name = "lastNamelabel";
            lastNamelabel.Size = new Size(87, 25);
            lastNamelabel.TabIndex = 1;
            lastNamelabel.Text = "Lastname";
            // 
            // firstNamelabel
            // 
            firstNamelabel.AutoSize = true;
            firstNamelabel.Location = new Point(29, 52);
            firstNamelabel.Name = "firstNamelabel";
            firstNamelabel.Size = new Size(92, 25);
            firstNamelabel.TabIndex = 0;
            firstNamelabel.Text = "FirstName";
            // 
            // emailPhonegroupBox
            // 
            emailPhonegroupBox.Controls.Add(textBoxHomePhone);
            emailPhonegroupBox.Controls.Add(textBoxCellPhone);
            emailPhonegroupBox.Controls.Add(textBoxEmailBusiness);
            emailPhonegroupBox.Controls.Add(textBoxEmailPrivate);
            emailPhonegroupBox.Controls.Add(emailPrivatelabel);
            emailPhonegroupBox.Controls.Add(emailbusinesslabel);
            emailPhonegroupBox.Controls.Add(cellPhonelabel);
            emailPhonegroupBox.Controls.Add(homephonelabel);
            emailPhonegroupBox.Location = new Point(31, 232);
            emailPhonegroupBox.Name = "emailPhonegroupBox";
            emailPhonegroupBox.Size = new Size(576, 272);
            emailPhonegroupBox.TabIndex = 1;
            emailPhonegroupBox.TabStop = false;
            emailPhonegroupBox.Text = "Email and Phone";
            // 
            // textBoxHomePhone
            // 
            textBoxHomePhone.Location = new Point(163, 37);
            textBoxHomePhone.Name = "textBoxHomePhone";
            textBoxHomePhone.Size = new Size(391, 31);
            textBoxHomePhone.TabIndex = 4;
            // 
            // textBoxCellPhone
            // 
            textBoxCellPhone.Location = new Point(163, 95);
            textBoxCellPhone.Name = "textBoxCellPhone";
            textBoxCellPhone.Size = new Size(391, 31);
            textBoxCellPhone.TabIndex = 5;
            // 
            // textBoxEmailBusiness
            // 
            textBoxEmailBusiness.Location = new Point(163, 153);
            textBoxEmailBusiness.Name = "textBoxEmailBusiness";
            textBoxEmailBusiness.Size = new Size(391, 31);
            textBoxEmailBusiness.TabIndex = 6;
            // 
            // textBoxEmailPrivate
            // 
            textBoxEmailPrivate.Location = new Point(163, 212);
            textBoxEmailPrivate.Name = "textBoxEmailPrivate";
            textBoxEmailPrivate.Size = new Size(391, 31);
            textBoxEmailPrivate.TabIndex = 7;
            // 
            // emailPrivatelabel
            // 
            emailPrivatelabel.AutoSize = true;
            emailPrivatelabel.Location = new Point(6, 198);
            emailPrivatelabel.Name = "emailPrivatelabel";
            emailPrivatelabel.Size = new Size(112, 25);
            emailPrivatelabel.TabIndex = 3;
            emailPrivatelabel.Text = "Email.private";
            // 
            // emailbusinesslabel
            // 
            emailbusinesslabel.AutoSize = true;
            emailbusinesslabel.Location = new Point(6, 147);
            emailbusinesslabel.Name = "emailbusinesslabel";
            emailbusinesslabel.Size = new Size(126, 25);
            emailbusinesslabel.TabIndex = 2;
            emailbusinesslabel.Text = "Email.business";
            // 
            // cellPhonelabel
            // 
            cellPhonelabel.AutoSize = true;
            cellPhonelabel.Location = new Point(6, 95);
            cellPhonelabel.Name = "cellPhonelabel";
            cellPhonelabel.Size = new Size(96, 25);
            cellPhonelabel.TabIndex = 1;
            cellPhonelabel.Text = "Cell phone";
            // 
            // homephonelabel
            // 
            homephonelabel.AutoSize = true;
            homephonelabel.Location = new Point(6, 43);
            homephonelabel.Name = "homephonelabel";
            homephonelabel.Size = new Size(117, 25);
            homephonelabel.TabIndex = 0;
            homephonelabel.Text = "Home phone";
            // 
            // adressGroupBox
            // 
            adressGroupBox.Controls.Add(comboBoxCountry);
            adressGroupBox.Controls.Add(labelCountry);
            adressGroupBox.Controls.Add(textBoxZipode);
            adressGroupBox.Controls.Add(textBoxCity);
            adressGroupBox.Controls.Add(textBoxStreet);
            adressGroupBox.Controls.Add(ZipCodelabel);
            adressGroupBox.Controls.Add(City);
            adressGroupBox.Controls.Add(streetlabel);
            adressGroupBox.Location = new Point(29, 522);
            adressGroupBox.Name = "adressGroupBox";
            adressGroupBox.Size = new Size(580, 257);
            adressGroupBox.TabIndex = 2;
            adressGroupBox.TabStop = false;
            adressGroupBox.Text = "Adress";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(170, 198);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(318, 33);
            comboBoxCountry.TabIndex = 7;
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(51, 202);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(75, 25);
            labelCountry.TabIndex = 6;
            labelCountry.Text = "Country";
            // 
            // textBoxZipode
            // 
            textBoxZipode.Location = new Point(170, 137);
            textBoxZipode.Name = "textBoxZipode";
            textBoxZipode.Size = new Size(318, 31);
            textBoxZipode.TabIndex = 5;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(170, 87);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(318, 31);
            textBoxCity.TabIndex = 4;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(170, 35);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(318, 31);
            textBoxStreet.TabIndex = 3;
            // 
            // ZipCodelabel
            // 
            ZipCodelabel.AutoSize = true;
            ZipCodelabel.Location = new Point(54, 137);
            ZipCodelabel.Name = "ZipCodelabel";
            ZipCodelabel.Size = new Size(77, 25);
            ZipCodelabel.TabIndex = 2;
            ZipCodelabel.Text = "zipCode";
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(54, 87);
            City.Name = "City";
            City.Size = new Size(42, 25);
            City.TabIndex = 1;
            City.Text = "City";
            // 
            // streetlabel
            // 
            streetlabel.AutoSize = true;
            streetlabel.Location = new Point(54, 38);
            streetlabel.Name = "streetlabel";
            streetlabel.Size = new Size(57, 25);
            streetlabel.TabIndex = 0;
            streetlabel.Text = "Street";
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(80, 798);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(187, 42);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(339, 798);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(187, 42);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 875);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(adressGroupBox);
            Controls.Add(emailPhonegroupBox);
            Controls.Add(NamegroupBox);
            Name = "ContactForm";
            Text = "ContactForm";
            Load += ContactForm_Load;
            NamegroupBox.ResumeLayout(false);
            NamegroupBox.PerformLayout();
            emailPhonegroupBox.ResumeLayout(false);
            emailPhonegroupBox.PerformLayout();
            adressGroupBox.ResumeLayout(false);
            adressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox NamegroupBox;
        private Label lastNamelabel;
        private Label firstNamelabel;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private GroupBox emailPhonegroupBox;
        private Label homephonelabel;
        private Label cellPhonelabel;
        private TextBox textBoxHomePhone;
        private TextBox textBoxCellPhone;
        private TextBox textBoxEmailBusiness;
        private TextBox textBoxEmailPrivate;
        private Label emailPrivatelabel;
        private Label emailbusinesslabel;
        private GroupBox adressGroupBox;
        private Label City;
        private Label streetlabel;
        private Label ZipCodelabel;
        private TextBox textBoxZipode;
        private TextBox textBoxCity;
        private TextBox textBoxStreet;
        private ComboBox comboBoxCountry;
        private Label labelCountry;
        private Button buttonOk;
        private Button buttonCancel;
    }
}