﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает номер телефона.
    /// </summary> 
    public class PhoneNumber
    {
        /// <summary>
        /// Номер телефона.
        /// </summary> 
        private long _number;

        /// <summary>
        /// Возвращает или задает номер телефона.
        /// </summary> 
        public long Number
        {
            get
            {
                return _number;
            }
            set
            {
                if ((value < 70000000000) || (value > 79999999999))
                {
                    throw new ArgumentException(
                        $"The number must start with 7 and has 11 digits." 
                        + $"But was {value}");
                }
                _number = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="PhoneNumber">.
        /// </summary> 
        public PhoneNumber(long number)
        {
            Number = number;
        }

        public PhoneNumber()
        {

        }
    }
}