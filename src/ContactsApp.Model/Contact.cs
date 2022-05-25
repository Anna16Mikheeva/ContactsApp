using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


/// <summary>
/// Описание контакта.
/// </summary> 
namespace ContactsApp.Model
{
    /// <summary>
    /// Контакт.
    /// </summary> 
    public class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private PhoneNumber _phoneNumber;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// E-mail контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Id Вконтакте.
        /// </summary>
        private string _idVk;

        /// <summary>
        /// Возвращает или задает фамилию.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException($"Surname must be no longer than 50 letters."
                                                + $"But was {value.Length}. ");
                }
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                _surname = textInfo.ToTitleCase(value);
            }
        }

        /// <summary>
        /// Возвращает или задает имя.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException($"Name must be no longer than 50 letters." 
                                                + $"But was {value.Length}. ");
                }
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                _name = textInfo.ToTitleCase(value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает номер телефона.
        /// </summary>
        public PhoneNumber @PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает или задает дату.
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentException($"Year of birth cannot be less than 1900." 
                                                + $"But was {value}. ");
                }
                if(value.Date >= DateTime.Now)
                {
                    throw new ArgumentException($"Date of birth cannot be later than today." 
                                                + $"But was {value}. ");
                }
                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// Возвращает или задает e-mail.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length > 50   )
                {
                    throw new ArgumentException($"Email must be no longer than 50 letters." 
                                                + $"But was {value.Length}. ");
                }
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает или задает id Вконтакте.
        /// </summary>
        public string IdVk
        {
            get
            {
                return _idVk;
            }
            set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException($"Id must be no longer than 15 letters." 
                                                + $"But was {value.Length}. ");
                }
                _idVk = value;
            }
        }

        public Contact()
        {

        }

        /// <summary>
        /// Создает экземпляр <see cref="Contact">.
        /// </summary> 
        public Contact(string surname, string name, long phoneNumber, DateTime dateOfBirth,
                       string email, string idVk)
        {
            Surname = surname;
            Name = name;
            PhoneNumber phone = new PhoneNumber(phoneNumber);
            @PhoneNumber = phone;
            DateOfBirth = dateOfBirth;
            Email = email;
            IdVk = idVk;
        }

        public object Clone()
        {
            return new Contact(Surname, Name, _phoneNumber.Number, DateOfBirth, Email, IdVk);
        }
    }
}
