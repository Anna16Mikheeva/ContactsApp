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
        //private Contact _contact = new Contact("Ivanov", "Petr", 78965412300,
        //                           new DateTime(1999, 2, 12), "fdvdf169fgfgfg@gmail.com",
        //                           "158963578");
        private Contact _contact = new Contact();
        Contact _contactCopy = new Contact();

        //Объявление переменных
        private string _surnameError, _nameError, _phoneNumberError, _birthOfDateError,
                       _emailError, _idVkError;
        private Color colorWhite = Color.White, colorLightPink = Color.LightPink;

        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                if(_contact != null)
                {
                    _contactCopy = (Contact)_contact.Clone();
                }
                else
                {
                    _contactCopy = new Contact();
                }
                UpdateForm();
            }
        }

        /// <summary>
        /// Заполнение окна данными нового контакта.
        /// </summary> 
        private void UpdateForm()
        {
            SurnameTextBox.Text = _contactCopy.Surname;
            NameTextBox.Text = _contactCopy.Name;
            DateOfBirthTimePicker.Value = _contactCopy.DateOfBirth;
            PhoneTextBox.Text = Convert.ToString(_contactCopy.PhoneNumber.Number);
            EmailTextBox.Text = _contactCopy.Email;
            VkComTextBox.Text = _contactCopy.IdVk;
        }

        /// <summary>
        /// Проверка правильности введенной фамилии.
        /// </summary> 
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contactCopy.Surname = SurnameTextBox.Text;
                _surnameError = "";
                SurnameTextBox.BackColor = Color.White;
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
            string Error = "";
            if ((_surnameError == "") && (_nameError == "") && (_birthOfDateError == "") &&
            (_phoneNumberError == "") && (_emailError == "") && (_idVkError == ""))
            {
                return true;
            }
            else
            {
                if (_surnameError != "")
                {
                    Error += _surnameError;
                }
                if (_nameError != "")
                {
                    Error += _nameError;
                }
                if (_birthOfDateError != "")
                {
                    Error += _birthOfDateError;
                }
                if (_phoneNumberError != "")
                {
                    Error += _phoneNumberError;
                }
                if (_emailError != "")
                {
                    Error += _emailError;
                }
                if (_idVkError != "")
                {
                    Error += _idVkError;
                }
                MessageBox.Show(Error, "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                Error = "";
                return false;
            }
        }

        /// <summary>
        /// Проверка правильности выбранной даты.
        /// </summary> 
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contactCopy.DateOfBirth = DateOfBirthTimePicker.Value;
                _birthOfDateError = "";
                DateOfBirthTimePicker.BackColor = colorWhite;
            }
            catch (ArgumentException exception)
            {
                DateOfBirthTimePicker.CalendarTitleBackColor = colorLightPink;
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
                _contactCopy.Email = EmailTextBox.Text;
                _emailError = "";
                EmailTextBox.BackColor = colorWhite;
            }
            catch (ArgumentException exception)
            {
                EmailTextBox.BackColor = colorLightPink;
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
                _contactCopy.PhoneNumber.Number = long.Parse(PhoneTextBox.Text);
                _phoneNumberError = "";
                PhoneTextBox.BackColor = colorWhite;
            }
            catch (ArgumentException exception)
            {
                PhoneTextBox.BackColor = colorLightPink;
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
                _contactCopy.Name = NameTextBox.Text;
                _nameError = "";
                NameTextBox.BackColor = colorWhite;
            }
            catch (ArgumentException exception)
            {
                NameTextBox.BackColor = colorLightPink;
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
                _contactCopy.IdVk = VkComTextBox.Text;
                _idVkError = "";
                VkComTextBox.BackColor = colorWhite;
            }
            catch (ArgumentException exception)
            {
                VkComTextBox.BackColor = colorLightPink;
                _idVkError = exception.Message;
            }
        }

        private void UpdateContact()
        {
            _contactCopy.Surname = SurnameTextBox.Text;
            _contactCopy.Name = NameTextBox.Text;
            _contactCopy.DateOfBirth = DateOfBirthTimePicker.Value;
            _contactCopy.PhoneNumber.Number = long.Parse(PhoneTextBox.Text);
            _contactCopy.Email = EmailTextBox.Text;
            _contactCopy.IdVk = VkComTextBox.Text;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckFromOnErrors())
            {
                UpdateContact();
                _contact = _contactCopy;
                DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
