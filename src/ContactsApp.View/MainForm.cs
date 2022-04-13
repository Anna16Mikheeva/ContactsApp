﻿using ContactsApp.View.Resources;
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
       private Project _project=new Project();
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
            for(int i=0;i< 10;i++)
            {
                ContactsListBox.Items.Add(_project.Contacts[i].Surname);
            }
        }

        /// <summary>
        /// Добавление нового объекта в _project.
        /// </summary> 
        private void AddContact()
        {
            // Создаем массив букв, которые мы будем использовать.
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            // Создаем генератор случайных чисел.
            Random rand = new Random();

            // Делаем слова.
            for (int i = 1; i <= 10; i++)
            {
                // Сделайте слово.
                string word = "";
                for (int j = 1; j <= 10; j++)
                {
                    // Выбор случайного числа от 0 до 25
                    // для выбора буквы из массива букв.
                    int letter_num = rand.Next(0, letters.Length - 1);

                    // Добавить письмо.
                    word += letters[letter_num];
                }

                // Добавьте слово в список.
                _project.Contacts[i].Surname=word;
            }

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
            //listBox1.Items.Add("Anna");
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
            Resources.ContactForm contactForm = new Resources.ContactForm();
            contactForm.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //ContactsListBox.Items.Add("Anna");
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            

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
    }
}