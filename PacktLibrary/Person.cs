using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared;
public class Person : IComparable<Person>
{
    public string Name;
    public DateTime DateOfBirth;
    public List<Person> Children = new List<Person>();

    public void WritToConsole()
    {
        WriteLine($"{Name}, was born  on a {DateOfBirth:dddd}");
    }
    
    public static Person Procreate(Person p1, Person p2)
    {
        var baby = new Person
        {
            Name = $"Baby of {p1.Name} and {p2.Name}"
        };

        p1.Children.Add(baby);
        p2.Children.Add(baby);

        return baby;
    }

    public Person ProCreateWith(Person Partner)
    {
        return Procreate(this, Partner);
    }

    public static Person operator *(Person P1, Person P2)
    {
        return Person.Procreate(P1, P2);
    }

    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException($"{nameof(number)} cannot be less than zero");
        }

        return localFactorial(number);
        int localFactorial(int localNumber)
        {
            if (localNumber < 1) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }


    }

    public int CompareTo(Person other)
    {
        return Name.CompareTo(other.Name);
    }

    public void Timetravel(DateTime when)
    {
        if (when <= DateOfBirth)
        {
            throw new PersonException("If you travel back in time to a date ealier than your birth, then the universe will explode");

        }
        else
        {
            WriteLine($"Welcome to {when:yyyy}!");
        }
    }
}
