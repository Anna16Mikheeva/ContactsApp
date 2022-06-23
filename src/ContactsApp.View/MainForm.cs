using ContactsApp.View.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp.Model;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Создание экземпляра класса Project.
        /// </summary> 
        private Project _project = new Project();

        /// <summary>
        /// Создание списка контактов.
        /// </summary> 
        private List<Contact> _currentContact;

        /// <summary>
        /// Создание списка контактов.
        /// </summary> 
        private List<Contact> _currentContactDateOfBirth;

        /// <summary>
        /// Экземпляр класс ProjectSerializer для сереализации.
        /// </summary>
        private ProjectSerializer _projectSerializer = new ProjectSerializer();

        public MainForm()
        {
            InitializeComponent();
            //Выгружает из файла userdata.json.
            _project = _projectSerializer.LoadFromFile();
            _currentContact = _project.SortContacts(_project.Contacts);
            BirthdaysLabel.Text = "";
            for (int i = 0; i < _currentContact.Count; i++)
            {
                ContactsListBox.Items.Add(_currentContact[i].Surname);
            }
            DateOfBirthPanel.Visible = false;
            BirthdayPeople();
        }

        /// <summary>
        /// Очищает ContsctsListBox и добавляет данные из коллекции.
        /// </summary> 
        private void UpdateListBox()
        {
            _currentContact = _project.SortContacts(_project.Contacts);
            ContactsListBox.Items.Clear();
            BirthdaysLabel.Text = "";
            for (int i = 0; i < _currentContact.Count; i++)
            {
                ContactsListBox.Items.Add(_currentContact[i].Surname);
            }
            BirthdayPeople();
        }

        /// <summary>
        /// Выводит именниников.
        /// </summary> 
        private void BirthdayPeople()
        {
            _currentContactDateOfBirth = _project.SearchByDateOfBirth(_currentContact);
            DateOfBirthPanel.Visible = _currentContactDateOfBirth.Count > 0;
            var surnames = _currentContactDateOfBirth.Select(contact => contact.Surname).ToArray();
            BirthdaysLabel.Text = string.Join("\n", surnames);
        }

        /// <summary>
        /// Добавление нового объекта в _project.
        /// </summary> 
        private void AddContact()
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Contact = null;
            contactForm.ShowDialog();
            if (contactForm.Contact != null)
            {
                _project.Contacts.Add(contactForm.Contact);
                UpdateListBox();
                _projectSerializer.SaveToFile(_project);
            }
        }

        /// <summary>
        /// Удаление контакта из коллекции и ContactsListBox.
        /// </summary> 
        private void RemoveContact(int index)
        {
            //Если не выбран никакой контакт, то удаления не происходит,
            //иначе выодит диалоговое окно.
            if (index == -1)
            {
                return;
            }

            //Вывод диалогового окна при удалении контакта.
            DialogResult result = MessageBox.Show(
            "Do you really want to remove " + $"{_project.Contacts[index].Surname}?",
            "Message",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                //Удаление контакта из ContactsListBox.
                ContactsListBox.Items.RemoveAt(index);

                //Удаление контакта из коллекции.
                _currentContact.RemoveAt(index);

                _project.Contacts = _currentContact;
                UpdateListBox();
                _projectSerializer.SaveToFile(_project);
            }
        }

        /// <summary>
        /// Заполнение правой панели правого окна данными выбранного контакта.
        /// </summary> 
        private void UpdateSelectedContact(int index)
        {
            //Если не выбран контакт, то правая панель становится пустой
            //иначе панель заполняется данными выбранного контакта.
            if (index == -1)
            {
                SurnameTextBox.Text = "";
                NameTextBox.Text = "";
                DateOfBirthTimePicker.Value = DateTime.Now;
                PhoneTextBox.Text = "";
                EmailTextBox.Text = "";
                VkComTextBox.Text = "";
            }
            else
            {
                var contact = _currentContact[index];
                SurnameTextBox.Text = contact.Surname;
                NameTextBox.Text = contact.Name;
                DateOfBirthTimePicker.Value = contact.DateOfBirth;
                PhoneTextBox.Text = Convert.ToString(contact.PhoneNumber.Number);
                EmailTextBox.Text = contact.Email;
                VkComTextBox.Text = contact.IdVk;
            }
        }

        /// <summary>
        /// Редактирование контакта в верхнем меню.
        private void EditContact(int index)
        {
            if (index == -1)
            {
                return;
            }
            ContactForm contactForm = new ContactForm();
            contactForm.Contact = _currentContact[index];
            //contactForm.Contact = _project.Contacts[index];
            contactForm.ShowDialog();
            if (contactForm.Contact != null)
            {
                _currentContact[index] = contactForm.Contact;
                _project.Contacts = _currentContact;
                UpdateListBox();
                _projectSerializer.SaveToFile(_project);
            }
            ContactsListBox.SelectedIndex = index;
        }

        /// <summary>
        /// Кнопка добавления контакта.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        /// <summary>
        /// Кнопка редактирования контакта.
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Кнопка удаления контакта.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Кнопка добавления контакта в верхнем меню.
        /// Заполнение рандомными данными.
        /// </summary>
        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        /// <summary>
        /// Кнопка удаление контакта в верхнем меню.
        /// </summary>
        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Кнопка редактирования контакта в верхнем меню.
        /// </summary>
        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Событие при изменении выбранного контакта.
        /// </summary>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Выход из приложения.
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to exit the app?",
            "Message",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                _projectSerializer.SaveToFile(_project);
                Close();
            }
        }

        /// <summary>
        /// Вызов информации о приложении.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}