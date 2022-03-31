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
    class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Фамилия
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private PhoneNumber _phoneNumber;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _dateBirth;

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
                    throw new ArgumentException($"Surname must be no longer than 50 letters." + $"But was {value}");
                }
                //TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                //Console.WriteLine("\"{0}\" to titlecase: {1}", value, myTI.ToTitleCase(value));
                _surname = value;
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
                    throw new ArgumentException($"Name must be no longer than 50 letters." + $"But was {value}");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает номер телефона.
        /// </summary>
        public PhoneNumber PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
        }

        /// <summary>
        /// Возвращает или задает дату.
        /// </summary>
        public DateTime dateBirth
        {
            get
            {
                return _dateBirth;
            }
            set
            {
                //if (value < 1900.01.01)
                //{
                //    throw new ArgumentException($"Name must be no longer than 50 letters." + $"But was {value}");
                //}
                _dateBirth = value;
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
                    throw new ArgumentException($"Name must be no longer than 50 letters." + $"But was {value}");
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
                    throw new ArgumentException($"Id must be no longer than 15 letters." + $"But was {value}");
                }
                _idVk = value;
            }
        }
    }
}
