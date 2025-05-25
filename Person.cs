using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Models;

public class Person
{
    public string? Name { get; set; }
    public string? Lastname { get; set; }

    public override string ToString()
    {
        return $"{Name} {Lastname}";
    }
}
