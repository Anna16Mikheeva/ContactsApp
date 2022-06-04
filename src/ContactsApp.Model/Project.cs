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

        /// <summary>
        /// Сортировка контакта по алфавиту.
        /// </summary>
        public List<Contact> SortContacts(List<Contact> contacts)
        {
            contacts = contacts.OrderBy(contact => contact.Surname).ToList();
            return contacts;
        }


        /// <summary>
        /// Поиск контакта по дате рождения.
        /// </summary>
        public List<Contact> SearchByDateOfirth(List<Contact> contacts)
        {
            contacts = contacts.Where(contact => contact.DateOfBirth.Date == DateTime.Now.Date).ToList();
            return contacts;
        }
    }
}
