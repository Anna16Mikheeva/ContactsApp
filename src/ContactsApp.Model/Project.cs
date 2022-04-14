using System;
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
        /// Возвращает или задает контакт.
        /// </summary>
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
