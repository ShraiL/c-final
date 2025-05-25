using LashaMurgvaLominadzeShraieri.Final.Models;
using LashaMurgvaLominadzeShraieri.Final.Services;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace LashaMurgvaLominadzeShraieri.Final
{
    public partial class Form1 : Form
    {
        private readonly PersonService _personService;
        private readonly BindingList<Person> _bindingList;
        private int _currentEditIndex = -1;

        public Form1()
        {
            InitializeComponent();
            _personService = new PersonService();
            _bindingList = new BindingList<Person>();
            listBox.DataSource = _bindingList;
            listBox.MouseDoubleClick += EditUser;
        }

        private void addUser(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;

            
            if (!ValidateNames(firstName, lastName))
            {
                return; 
            }

            Person person = new Person { Name = firstName, Lastname = lastName };
            _personService.AddPerson(person);

            firstNameBox.Clear();
            lastNameBox.Clear();
            Sync();
        }

        private void deleteUser(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Please select a user", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _personService.DeletePerson(index);
            Sync();
        }

        private void EditUser(object sender, MouseEventArgs e)
        {
            int index = listBox.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Please select a user to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = _personService.GetPeople().ToList()[index];
            firstNameBox.Text = selected.Name;
            lastNameBox.Text = selected.Lastname;

            _currentEditIndex = index;

            updateBtn.Click -= UpdateUser;
            updateBtn.Click += UpdateUser;
        }

        private void UpdateUser(object? s, EventArgs args)
        {
            if (_currentEditIndex == -1)
                return;

            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;

            
            if (!ValidateNames(firstName, lastName))
            {
                return; 
            }

            Person updated = new Person
            {
                Name = firstName,
                Lastname = lastName
            };

            _personService.UpdatePerson(_currentEditIndex, updated);
            _currentEditIndex = -1;

            firstNameBox.Clear();
            lastNameBox.Clear();
            Sync();

            updateBtn.Click -= UpdateUser;
        }

        private void Sync()
        {
            _bindingList.Clear();
            var people = _personService.GetPeople();

            foreach (var person in people)
                _bindingList.Add(person);
        }

        private bool ValidateNames(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Firstname and Lastname cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit))
            {
                MessageBox.Show("Names cannot contain numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; 
        }
    }
}
