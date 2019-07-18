using System;
using basicfunctions.People;

namespace basicfunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            //referrs to the person.cs file, need to inject
            //basicfunctions.people so that we can use the below info
            person.Name = "Christa";
            person.Age = 31;
            person.HasPet = false;

            person.Greeting();

            // Console.WriteLine("Hello World!");
            // string firstName = "christa";
            // string lastName = "STEPHENS";
            // firstName = firstName.ToUpper();
            // Console.WriteLine(firstName);

            var v = new { Amount = 108, Message = " Hello" };

            // Rest the mouse pointer over v.Amount and v.Message in the following
            // statement to verify that their inferred types are int and string.
            Console.WriteLine(v.Amount + v.Message);


            var example = new { Greeting = "Hello", Name = "World" };
            Console.WriteLine($"{example.Greeting}, {example.Name}!");
        }
    }
}
