using ContactsApp.Model;
using ContactsApp.View.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View.Resources
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }
        private Contact _contact = new Contact("Ivanov", "Petr", 78965412300, new DateTime(1999, 2, 12), "fdvdf169fgfgfg@gmail.com", "158963578");
        
        
        private void UpdateForm()
        {
            SurnameTextBox.Text = _contact.Surname;
            NameTextBox.Text = _contact.Name;
            DateOfBirthTimePicker.Value = _contact.DateOfBirth;
            PhoneTextBox.Text = Convert.ToString(_contact.PhoneNumber);
            EmailTextBox.Text = _contact.Email;
            VkComTextBox.Text = _contact.IdVk;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Surname = SurnameTextBox.Text;
                SurnameTextBox.BackColor = Color.White;
            }
            catch
            {
                if (_contact.Surname.Length > 2)
                {
                    SurnameTextBox.BackColor = Color.Red;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    _contact.PhoneNumber = Convert.ToInt64(PhoneTextBox.Text);
            //    PhoneTextBox.ForeColor = Color.White;
            //}
            //catch
            //{
            //    if (Convert.ToInt64(PhoneTextBox.Text) > 15)
            //    {
            //        PhoneTextBox.ForeColor = Color.LightPink;
            //    }
            //}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
