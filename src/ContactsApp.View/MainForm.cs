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

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Очищает ContsctsListBox и добавляет данные из коллекции.
        /// </summary> 
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            for(int i=0;i < _project.Contacts.Count;i++)
            {
               ContactsListBox.Items.Add(_project.Contacts[i].Surname);
            }
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
                _project.Contacts.RemoveAt(index);
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
                var contact = _project.Contacts[index];
                SurnameTextBox.Text = contact.Surname;
                NameTextBox.Text = contact.Name;
                DateOfBirthTimePicker.Value = contact.DateOfBirth;
                PhoneTextBox.Text = Convert.ToString(contact.PhoneNumber.Number);
                EmailTextBox.Text = contact.Email;
                VkComTextBox.Text = contact.IdVk;
            }
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
            if(result == DialogResult.Yes)
            {
                Close();
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
            contactForm.Contact = _project.Contacts[index];
            contactForm.ShowDialog();
            if (contactForm.Contact != null)
            {
                _project.Contacts[index] = contactForm.Contact;
                UpdateListBox();
            }
            ContactsListBox.SelectedIndex = index;
        }

        /// <summary>
        /// Вызов информации о приложении.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        /// <summary>
        /// Заполнение рандомными данными.
        /// </summary>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Создаем генератор случайных чисел.
            Random rand = new Random();
            //Создаем массивы данных.
            string[] arraySurname = { "ivanov", "petrova", "Pereversev", "Osmanova", "Afanasev",
                                      "Merkulov", "volkov", "Savchina", "Drey", "Simakov"};
            string[] arrayName = {"Kirill", "Anastasia", "Mikhail", "Lilya", "Dmitriy",
                                  "Andrey", "Evgeniy", "Julia", "Ekaterina", "Yuri"};
            long[] arrayNumber = { 79521581576, 75963214585,
                                   76964368906, 79876543212,
                                   78765679007, 71209657438,
                                   79521589876, 77654321234,
                                   70000000001, 75454455667};
            DateTime date = new DateTime(rand.Next(1900, DateTime.Now.Year), rand.Next(1, 12),
                                         rand.Next(1, 31));
            string[] arrayEmail = {"kivbic@gmail.com", "ejjf18mf@yandex.ru", "hy6k89@mail.ru",
                                   "ouy90.qr@gmail.com", "jfhfhj.78@yandex.ru", "op90tur@tusur.ru",
                                   "anas89sia@yandex.ru", "olga12orlova@gmail.com",
                                   "yup.rty@mail.ru", "yrjhnf.67.tyutu@gmail.com"};
            string[] arrayIdVk = { "193179578", "fgth2145", "589632100", "op4578963", "745896320",
                                 "afrt12458", "458963215", "457896301", "521003699", "458796320"};

            _project.Contacts.Add(new Contact(arraySurname[rand.Next(0, arraySurname.Length - 1)],
                                  arrayName[rand.Next(0, arraySurname.Length - 1)],
                                  arrayNumber[rand.Next(0, arraySurname.Length - 1)],
                                  date, arrayEmail[rand.Next(0, arraySurname.Length - 1)],
                                  arrayIdVk[rand.Next(0, arraySurname.Length - 1)]));
        }
    }
}