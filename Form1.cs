using LashaMurgvaLominadzeShraieri.Final.Models;
using LashaMurgvaLominadzeShraieri.Final.Services;
using System.ComponentModel;

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
            string firstname = firstNameBox.Text;
            string lastname = lastNameBox.Text;

            if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("Firstname and Lastname cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Person person = new Person { Name = firstname, Lastname = lastname };
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

            Person updated = new Person
            {
                Name = firstNameBox.Text,
                Lastname = lastNameBox.Text
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
    }
}
