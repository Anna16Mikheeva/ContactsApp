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

        /// <summary>
        /// Создание экземпляра класса Contact и заполнение данными.
        /// </summary> 
        private Contact _contact = new Contact("Ivanov", "Petr", 78965412300, 
                                   new DateTime(1999, 2, 12), "fdvdf169fgfgfg@gmail.com",
                                   "158963578");
        private string _surnameError, _nameError, _phoneNumberError, _birthOfDateError,
                       _emailError, _idVkError;

        /// <summary>
        /// Заполнение окна данными нового контакта.
        /// </summary> 
        private void UpdateForm()
        {
            SurnameTextBox.Text = _contact.Surname;
            NameTextBox.Text = _contact.Name;
            DateOfBirthTimePicker.Value = _contact.DateOfBirth;
            PhoneTextBox.Text = Convert.ToString(_contact.PhoneNumber.Number);
            EmailTextBox.Text = _contact.Email;
            VkComTextBox.Text = _contact.IdVk;
        }

        /// <summary>
        /// Проверка правильности введенной фамилии.
        /// </summary> 
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Surname = SurnameTextBox.Text;
                _surnameError = "";
                if (_contact.Surname.Length < 50)
                {
                    SurnameTextBox.BackColor = Color.White;
                }
            }
            catch(ArgumentException exception)
            {
                SurnameTextBox.BackColor = Color.LightPink;
                _surnameError = exception.Message;
            }
        }

        /// <summary>
        /// Вызов сообщения для пользователя о неправильно введенных данных.
        /// </summary> 
        private bool CheckFromOnErrors()
        {
            if ((_surnameError == "") && (_nameError == "") && (_phoneNumberError == "")
                && (_birthOfDateError == "") && (_emailError == "") && (_idVkError == ""))
            {
                return true;
            }
            else
            {
                if (_surnameError != "")
                {
                    MessageBox.Show(_surnameError);
                }
                if (_nameError != "")
                {
                    MessageBox.Show(_nameError);
                }
                if (_phoneNumberError != "")
                {
                    MessageBox.Show(_phoneNumberError);
                }
                if (_birthOfDateError != "")
                {
                    MessageBox.Show(_birthOfDateError);
                }
                if (_emailError != "")
                {
                    MessageBox.Show(_emailError);
                }
                if (_idVkError != "")
                {
                    MessageBox.Show(_idVkError);
                }
                return false;
            }
        }

        /// <summary>
        /// Проверка правильности выбранной даты.
        /// </summary> 
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateOfBirthTimePicker.CalendarTitleBackColor = Color.Red;
            try
            {
                _contact.DateOfBirth = DateOfBirthTimePicker.Value;
                _birthOfDateError = "";
                if (_contact.DateOfBirth.Year > 1900)
                {
                    DateOfBirthTimePicker.BackColor = Color.White;
                }
            }
            catch (ArgumentException exception)
            {
                DateOfBirthTimePicker.CalendarTitleBackColor = Color.LightPink;
                _birthOfDateError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка правильности введенной электронной почты.
        /// </summary> 
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                _emailError = "";
                if (_contact.Email.Length < 50)
                {
                    EmailTextBox.BackColor = Color.White;
                }
            }
            catch (ArgumentException exception)
            {
                EmailTextBox.BackColor = Color.LightPink;
                _emailError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка правильности введенного номера телефона.
        /// </summary> 
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.PhoneNumber.Number = long.Parse(PhoneTextBox.Text);
                _phoneNumberError = "";
                if ((_contact.PhoneNumber.Number >= 70000000000) && 
                    (_contact.PhoneNumber.Number <= 79999999999))
                { 
                    PhoneTextBox.BackColor = Color.White;
                }
            }
            catch (ArgumentException exception)
            {
                PhoneTextBox.BackColor = Color.LightPink;
                _phoneNumberError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка правильности введенного имени.
        /// </summary> 
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Name = NameTextBox.Text;
                _nameError = "";
                if (_contact.Name.Length < 50)
                {
                    NameTextBox.BackColor = Color.White;
                }
            }
            catch (ArgumentException exception)
            {
                NameTextBox.BackColor = Color.LightPink;
                _nameError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка правильности введенного id vk.
        /// </summary> 
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.IdVk = VkComTextBox.Text;
                _idVkError = "";
                if (_contact.IdVk.Length < 15)
                {
                    VkComTextBox.BackColor = Color.White;
                }
            }
            catch (ArgumentException exception)
            {
                VkComTextBox.BackColor = Color.LightPink;
                _idVkError = exception.Message;
            }
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
            if (CheckFromOnErrors() == true)
            {
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
