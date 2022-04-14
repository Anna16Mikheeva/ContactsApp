
namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ContactMenuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindLabel = new System.Windows.Forms.Label();
            this.VkComLable = new System.Windows.Forms.Label();
            this.EmailLable = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneLable = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.NameLable = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.VkComTextBox = new System.Windows.Forms.TextBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ContactMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactMenuStrip
            // 
            this.ContactMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ContactMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContactMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.ContactMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ContactMenuStrip.Name = "ContactMenuStrip";
            this.ContactMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.ContactMenuStrip.Size = new System.Drawing.Size(126, 24);
            this.ContactMenuStrip.TabIndex = 38;
            this.ContactMenuStrip.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.aboutToolStripMenuItem1.Text = "File";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.helpToolStripMenuItem1.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeContactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // removeContactToolStripMenuItem
            // 
            this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            this.removeContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.removeContactToolStripMenuItem.Text = "Remove Contact";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(9, 28);
            this.FindLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 25;
            this.FindLabel.Text = "Find:";
            this.FindLabel.Click += new System.EventHandler(this.FindLabel_Click);
            // 
            // VkComLable
            // 
            this.VkComLable.Location = new System.Drawing.Point(243, 147);
            this.VkComLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VkComLable.Name = "VkComLable";
            this.VkComLable.Size = new System.Drawing.Size(45, 14);
            this.VkComLable.TabIndex = 31;
            this.VkComLable.Text = "vk.com:";
            // 
            // EmailLable
            // 
            this.EmailLable.Location = new System.Drawing.Point(250, 123);
            this.EmailLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLable.Name = "EmailLable";
            this.EmailLable.Size = new System.Drawing.Size(38, 14);
            this.EmailLable.TabIndex = 30;
            this.EmailLable.Text = "E-mail:";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(292, 25);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.ReadOnly = true;
            this.SurnameTextBox.Size = new System.Drawing.Size(347, 20);
            this.SurnameTextBox.TabIndex = 39;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(292, 72);
            this.BirthdayDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.BirthdayDateTimePicker.TabIndex = 33;
            // 
            // PhoneLable
            // 
            this.PhoneLable.Location = new System.Drawing.Point(247, 99);
            this.PhoneLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneLable.Name = "PhoneLable";
            this.PhoneLable.Size = new System.Drawing.Size(41, 14);
            this.PhoneLable.TabIndex = 29;
            this.PhoneLable.Text = "Phone:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(292, 48);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(347, 20);
            this.NameTextBox.TabIndex = 40;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Location = new System.Drawing.Point(220, 75);
            this.BirthdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(68, 14);
            this.BirthdayLabel.TabIndex = 28;
            this.BirthdayLabel.Text = "Date of birth:";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Location = new System.Drawing.Point(291, 96);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.ReadOnly = true;
            this.PhoneTextBox.Size = new System.Drawing.Size(346, 20);
            this.PhoneTextBox.TabIndex = 41;
            // 
            // NameLable
            // 
            this.NameLable.Location = new System.Drawing.Point(250, 51);
            this.NameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(38, 14);
            this.NameLable.TabIndex = 27;
            this.NameLable.Text = "Name:";
            this.NameLable.Click += new System.EventHandler(this.NameLable_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(292, 120);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(347, 20);
            this.EmailTextBox.TabIndex = 42;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SurnameLabel.Location = new System.Drawing.Point(236, 28);
            this.SurnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 14);
            this.SurnameLabel.TabIndex = 26;
            this.SurnameLabel.Text = "Surname:";
            this.SurnameLabel.Click += new System.EventHandler(this.SurnameLabel_Click);
            // 
            // VkComTextBox
            // 
            this.VkComTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VkComTextBox.Location = new System.Drawing.Point(292, 144);
            this.VkComTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VkComTextBox.Name = "VkComTextBox";
            this.VkComTextBox.ReadOnly = true;
            this.VkComTextBox.Size = new System.Drawing.Size(347, 20);
            this.VkComTextBox.TabIndex = 43;
            this.VkComTextBox.TextChanged += new System.EventHandler(this.VkComTextBox_TextChanged);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(43, 25);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(168, 20);
            this.FindTextBox.TabIndex = 32;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.Location = new System.Drawing.Point(9, 48);
            this.ContactsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(201, 321);
            this.ContactsListBox.TabIndex = 34;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.BackgroundImage = global::ContactsApp.View.Properties.Resources.Add;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(9, 373);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(30, 32);
            this.AddButton.TabIndex = 35;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.BackgroundImage = global::ContactsApp.View.Properties.Resources.Delete;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(78, 373);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(30, 32);
            this.DeleteButton.TabIndex = 37;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.BackgroundImage = global::ContactsApp.View.Properties.Resources.Edit1;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(44, 373);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(30, 32);
            this.EditButton.TabIndex = 36;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 415);
            this.Controls.Add(this.ContactsListBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.FindLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EmailLable);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ContactMenuStrip);
            this.Controls.Add(this.VkComTextBox);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.PhoneLable);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.VkComLable);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ContactsApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ContactMenuStrip.ResumeLayout(false);
            this.ContactMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip ContactMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Label VkComLable;
        private System.Windows.Forms.Label EmailLable;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.Label PhoneLable;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox VkComTextBox;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Button AddButton;
    }
}

