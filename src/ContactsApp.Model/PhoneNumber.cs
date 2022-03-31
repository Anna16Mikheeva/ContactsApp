using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает номер телефона.
    /// </summary> 
    class PhoneNumber
    {
        /// <summary>
        /// Номер телефона.
        /// </summary> 
        private int _number;

        /// <summary>
        /// Возвращает или задает номер телефона.
        /// </summary> 
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                int sum=0, v=value;
                while (v / 10 != 0)
                {
                    sum++;
                    v = v / 10;
                }
                if ((value/10!=7)&&(sum+1!=11))
                {
                    throw new ArgumentException($"The number must start with 7 and has 11 digits." + $"But was {value}");
                }
                _number = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="PhoneNumber">.
        /// </summary>
        public PhoneNumber(int number)
        {
            Number = number;
        }
    }

}