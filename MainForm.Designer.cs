namespace assignment5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addbutton = new Button();
            deletebutton = new Button();
            idLabel = new Label();
            nameLabel = new Label();
            phoneLabel = new Label();
            officeEmaillabel = new Label();
            contactlabel = new Label();
            allcustomerslistView = new ListBox();
            editButton = new Button();
            customerDetailsRichTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // addbutton
            // 
            addbutton.Location = new Point(141, 692);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(199, 68);
            addbutton.TabIndex = 2;
            addbutton.Text = "Add";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(729, 692);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(199, 68);
            deletebutton.TabIndex = 4;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            idLabel.ForeColor = Color.FromArgb(0, 192, 0);
            idLabel.Location = new Point(79, 42);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(40, 32);
            idLabel.TabIndex = 5;
            idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.FromArgb(0, 192, 0);
            nameLabel.Location = new Point(206, 42);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(82, 32);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            phoneLabel.ForeColor = Color.FromArgb(0, 192, 0);
            phoneLabel.Location = new Point(496, 42);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(164, 32);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Office phone";
            // 
            // officeEmaillabel
            // 
            officeEmaillabel.AutoSize = true;
            officeEmaillabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            officeEmaillabel.ForeColor = Color.FromArgb(0, 192, 0);
            officeEmaillabel.Location = new Point(811, 42);
            officeEmaillabel.Name = "officeEmaillabel";
            officeEmaillabel.Size = new Size(164, 32);
            officeEmaillabel.TabIndex = 8;
            officeEmaillabel.Text = "Office E-mail";
            // 
            // contactlabel
            // 
            contactlabel.AutoSize = true;
            contactlabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            contactlabel.ForeColor = Color.FromArgb(0, 192, 0);
            contactlabel.Location = new Point(1180, 42);
            contactlabel.Name = "contactlabel";
            contactlabel.Size = new Size(191, 32);
            contactlabel.TabIndex = 9;
            contactlabel.Text = "Contact Details";
            // 
            // allcustomerslistView
            // 
            allcustomerslistView.FormattingEnabled = true;
            allcustomerslistView.ItemHeight = 25;
            allcustomerslistView.Location = new Point(54, 113);
            allcustomerslistView.Name = "allcustomerslistView";
            allcustomerslistView.Size = new Size(955, 554);
            allcustomerslistView.TabIndex = 10;
            allcustomerslistView.SelectedIndexChanged += allcustomerslistView_SelectedIndexChanged_1;
            // 
            // editButton
            // 
            editButton.Location = new Point(430, 692);
            editButton.Name = "editButton";
            editButton.Size = new Size(199, 68);
            editButton.TabIndex = 11;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click_1;
            // 
            // customerDetailsRichTextBox
            // 
            customerDetailsRichTextBox.BackColor = SystemColors.ActiveBorder;
            customerDetailsRichTextBox.Location = new Point(1036, 113);
            customerDetailsRichTextBox.Name = "customerDetailsRichTextBox";
            customerDetailsRichTextBox.ReadOnly = true;
            customerDetailsRichTextBox.Size = new Size(438, 647);
            customerDetailsRichTextBox.TabIndex = 12;
            customerDetailsRichTextBox.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 817);
            Controls.Add(customerDetailsRichTextBox);
            Controls.Add(editButton);
            Controls.Add(allcustomerslistView);
            Controls.Add(contactlabel);
            Controls.Add(officeEmaillabel);
            Controls.Add(phoneLabel);
            Controls.Add(nameLabel);
            Controls.Add(idLabel);
            Controls.Add(deletebutton);
            Controls.Add(addbutton);
            Name = "MainForm";
            Text = "Customer registery by Bahareh Behzadi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addbutton;
        private Button deletebutton;
        private Label idLabel;
        private Label nameLabel;
        private Label phoneLabel;
        private Label officeEmaillabel;
        private Label contactlabel;
        private ListBox allcustomerslistView;
        private Button editButton;
        private RichTextBox customerDetailsRichTextBox;
    }
}