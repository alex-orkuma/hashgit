using System;
using Packt.Shared;
using static System.Console;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var mary = new Person { Name = "Mary" };
            var alex = new Person { Name = "Alex" };
            var jill = new Person { Name = "Jill" };

            // call baby methode
            var baby1 = mary.ProCreateWith(alex);
            baby1.Name = "Gary";

            var baby2 = Person.Procreate(mary, jill);
            var baby3 = mary * alex;

            WriteLine($"{alex.Name} has {alex.Children.Count} number of children");
            WriteLine($"{mary.Name} has {mary.Children.Count} number of children");
            WriteLine($"{jill.Name} has {jill.Children.Count} number of children");
            WriteLine(format: "{0}'s firt child is named \"{1}\".",
                arg0: alex.Name,
                arg1: alex.Children[0].Name);

            WriteLine($"5! is {Person.Factorial(5)}");

            Person[] people =
            {
                new Person {Name = "Simon"},
                new Person {Name = "Jenny"},
                new Person {Name = "Adams"},
                new Person {Name = "Shiaondo"},
            };

            foreach (var person in people)
            {
                WriteLine($" {person.Name}");
            }

            Array.Sort(people);

            foreach(var person in people)
            {
                WriteLine($" {person.Name}");
            }

            var t1 = new Thing();
            t1.Data = 42;
            WriteLine($"The thing with integer: {t1.Process(42)}");

            var t2 = new Thing();

            t2.Data = "apple";
            WriteLine($"The thing with string: {t2.Process("apple")}");


            var gt1 = new GenericThing<int>();
            gt1.Data = 42;
            WriteLine($"GenericThing with integer : {gt1.Process(42)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";

            WriteLine($"Genericthing with string: {gt2.Process("apple")}");


            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);

            var dv3 = dv1 + dv2;

            WriteLine($"({dv1.X }, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");


            Employee Alex = new Employee
            {
                Name = "Alex",
                DateOfBirth = new DateTime(1992, 6, 1),
                EmployeeCode = "HDSE001",
                HireDate = new DateTime(2021, 3, 3)
        
            };

            Alex.WritToConsole();
            WriteLine($"{Alex.Name} was hired on {Alex.HireDate:dd/MM/yy}");


            try
            {
                Alex.Timetravel(new DateTime( 1997, 3, 4));
                Alex.Timetravel(new DateTime(1990, 5, 6));
            }
            catch (PersonException ex)
            {

                WriteLine(ex.Message);
            }

        }

    }
}