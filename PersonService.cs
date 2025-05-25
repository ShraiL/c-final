using MyFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Services;

public class PersonService
{
    private readonly List<Person> _people;

    public PersonService()
    {
        _people = new List<Person>();
    }

    public void AddPerson(Person person)
    {
        _people.Add(person);
    }

    public void DeletePerson(int index)
    {
        _people.RemoveAt(index);
    }

    public void UpdatePerson(int index, Person updatedPerson)
    {
        if (index >= 0 && index < _people.Count)
        {
            _people[index] = updatedPerson;
        }
    }

    public IEnumerable<Person> GetPeople()
    {
        return _people;
    }
}
