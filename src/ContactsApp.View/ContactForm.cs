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
        }
        
        /// <summary>
        /// Создание экземпляра класса Contact.
        /// </summary>                         
        private Contact _contact;

        /// <summary>
        /// Создание экземпляра копии класса Contact. 
        /// </summary>  
        private Contact _contactCopy;

        /// <summary>
        /// Содержит текст ошибки введенной фамилии. 
        /// </summary>  
        private string _surnameError;

        /// <summary>
        /// Содержит текст ошибки введенного имени. 
        /// </summary>  
        private string _nameError;

        /// <summary>
        /// Содержит текст ошибки введенного номера телефона. 
        /// </summary>  
        private string _phoneNumberError;

        /// <summary>
        /// Содержит текст ошибки введенной даты рождения. 
        /// </summary>  
        private string _birthOfDateError;

        /// <summary>
        /// Содержит текст ошибки введенной электронной почты. 
        /// </summary>  
        private string _emailError;

        /// <summary>
        /// Содержит текст ошибки введенного id VK. 
        /// </summary>  
        private string _idVkError;

        /// <summary>
        /// Переменнаая белого цвета. 
        /// </summary>  
        private Color _colorWhite = Color.White;

        /// <summary>
        /// Переменнаая розового цвета. 
        /// </summary>  
        private Color _colorLightPink = Color.LightPink;

        /// <summary>
        /// Возвращает или залает значение контакта
        /// </summary>  
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
            if (SurnameTextBox.Text == "")
            {
                PhoneTextBox.Text = "";
            }
            else
            {
                PhoneTextBox.Text = Convert.ToString(_contactCopy.PhoneNumber.Number);
            }
            EmailTextBox.Text = _contactCopy.Email;
            VkComTextBox.Text = _contactCopy.IdVk;
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
        /// Проверка правильности введенной фамилии.
        /// </summary> 
        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contactCopy.Surname = SurnameTextBox.Text;
                _surnameError = "";
                SurnameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                SurnameTextBox.BackColor = Color.LightPink;
                _surnameError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка правильности введенного имени.
        /// </summary> 
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contactCopy.Name = NameTextBox.Text;
                _nameError = "";
                NameTextBox.BackColor = _colorWhite;
            }
            catch (ArgumentException exception)
            {
                NameTextBox.BackColor = _colorLightPink;
                _nameError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка правильности выбранной даты.
        /// </summary> 
        private void BirthOfDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contactCopy.DateOfBirth = DateOfBirthTimePicker.Value;
                _birthOfDateError = "";
                DateOfBirthTimePicker.BackColor = _colorWhite;
            }
            catch (ArgumentException exception)
            {
                DateOfBirthTimePicker.CalendarTitleBackColor = _colorLightPink;
                _birthOfDateError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка правильности введенного номера телефона.
        /// </summary> 
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PhoneTextBox.Text == "")
            {
                PhoneTextBox.BackColor = _colorLightPink;
                return;
            }
            try
            {
                _contactCopy.PhoneNumber.Number = long.Parse(PhoneTextBox.Text);
                _phoneNumberError = "";
                PhoneTextBox.BackColor = _colorWhite;
            }
            catch (ArgumentException exception)
            {
                PhoneTextBox.BackColor = _colorLightPink;
                _phoneNumberError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка правильности введенной электронной почты.
        /// </summary> 
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contactCopy.Email = EmailTextBox.Text;
                _emailError = "";
                EmailTextBox.BackColor = _colorWhite;
            }
            catch (ArgumentException exception)
            {
                EmailTextBox.BackColor = _colorLightPink;
                _emailError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка правильности введенного id vk.
        /// </summary> 
        private void IdVkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contactCopy.IdVk = VkComTextBox.Text;
                _idVkError = "";
                VkComTextBox.BackColor = _colorWhite;
            }
            catch (ArgumentException exception)
            {
                VkComTextBox.BackColor = _colorLightPink;
                _idVkError = exception.Message;
            }
        }

        /// <summary>
        /// Передает данные из формы в копию класса Contact
        /// </summary>  
        private void UpdateContact()
        {
            _contactCopy.Surname = SurnameTextBox.Text;
            _contactCopy.Name = NameTextBox.Text;
            _contactCopy.DateOfBirth = DateOfBirthTimePicker.Value;
            _contactCopy.PhoneNumber.Number = long.Parse(PhoneTextBox.Text);
            _contactCopy.Email = EmailTextBox.Text;
            _contactCopy.IdVk = VkComTextBox.Text;
        }

        /// <summary>
        /// Кнопка Ok
        /// </summary>  
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckFromOnErrors())
            {
                UpdateContact();
                _contact = _contactCopy;
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Кнопка Cancel
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void PhoneTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
