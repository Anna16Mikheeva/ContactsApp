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
            for(int i=0;i<_project.Contacts.Count;i++)
            {
               ContactsListBox.Items.Add(_project.Contacts[i].Surname);
            }
            
        }

        /// <summary>
        /// Добавление нового объекта в _project.
        /// </summary> 
        private void AddContact()
        {
            // Создаем генератор случайных чисел.
            Random rand = new Random();
            string[] arraySurname = { "Ivanov", "Petrova", "Pereversev", "Osmanova", "Afanasev", 
                                      "Merkulov", "Volkov", "Savchina", "Drey", "Simakov"};
            string[] arrayName = {"Kirill", "Anastasia", "Mikhail", "Lilya", "Dmitriy",
                                  "Andrey", "Evgeniy", "Julia", "Ekaterina", "Yuri"};
            PhoneNumber[] arrayNumber = { new PhoneNumber(79521581576), new PhoneNumber(79234485215),
                                          new PhoneNumber(78925601475), new PhoneNumber(78513694258), 
                                          new PhoneNumber(71504698720), new PhoneNumber(78415620748),
                                          new PhoneNumber(79521581045), new PhoneNumber(79501432289), 
                                          new PhoneNumber(778955142001), new PhoneNumber(74120036555)};
            DateTime date = new DateTime(rand.Next(1900, DateTime.Now.Year), rand.Next(1, 12), 
                                         rand.Next(1, 31));
            string[] arrayEmail = {"kivbic@gmail.com", "ejjf18mf@yandex.ru", "hy6k89@mail.ru", 
                                   "ouy90.qr@gmail.com", "jfhfhj.78@yandex.ru", "op90tur@tusur.ru", 
                                   "anas89sia@yandex.ru", "olga12orlova@gmail.com",
                                   "yup.rty@mail.ru", "yrjhnf.67.tyutu@gmail.com"};
            string[] arrayIdVk = { "193179578", "fgth2145", "589632100", "op4578963", "745896320",
                                   "afrt12458", "458963215", "457896301", "521003699", "458796320"};
            
            Console.WriteLine(arraySurname[rand.Next(0, arraySurname.Length - 1)]); 
            _project.Contacts.Add(new Contact(arraySurname[rand.Next(0, arraySurname.Length - 1)], 
                                  arrayName[rand.Next(0, arraySurname.Length - 1)], 
                                  arrayNumber[rand.Next(0, arraySurname.Length - 1)], 
                                  date, arrayEmail[rand.Next(0, arraySurname.Length - 1)], 
                                  arrayIdVk[rand.Next(0, arraySurname.Length - 1)]));

        }

        /// <summary>
        /// Удаление контакта из коллекции и ContactsListBox.
        /// </summary> 
        private void RemoveContact(int index)
        {
            //Удаление контакта из ContactsListBox.
            ContactsListBox.Items.RemoveAt(index);
            //Удаление контакта из коллекции.
            _project.Contacts.RemoveAt(index);
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Resources.ContactForm contactForm = new Resources.ContactForm();
            //contactForm.Show();
            AddContact();
            UpdateListBox();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
            AddContact();
            UpdateListBox();
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
        }

        private void SurnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FindLabel_Click(object sender, EventArgs e)
        {

        }

        private void VkComTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameLable_Click(object sender, EventArgs e)
        {

        }
    }
}