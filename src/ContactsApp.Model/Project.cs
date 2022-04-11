﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Описание проекта.
/// </summary> 
namespace ContactsApp.Model
{
    /// <summary>
    /// Проект.
    /// </summary> 
    public class Project
    {
        /// <summary>
        /// Список.
        /// </summary> 
        private string _list;

        /// <summary>
        /// Возвращает или задает проект.
        /// </summary>
        //public string List 
        //{
        //    get
        //    {
        //        return _list;
        //    }
        //    set
        //    {
        //        _list = value;
        //    }
        //}
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        /// <summary>
        /// Создает экземпляр <see cref="Contact">.
        /// </summary>
        public Project()
        {

        }

    }
}