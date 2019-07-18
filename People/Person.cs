using System;
using basicfunctions.Calc;

//.people tells that we are in the folder "people" located
//in basic functions
namespace basicfunctions.People{
    public class Person{
        public string Name;
        public int Age;
        public bool HasPet;
        public string[] homes = new string[4];
        public void Greeting()

        {
            Console.WriteLine("Hey gal! My name is " + Name + " and my age is " + Age);
            int result = Calculator.Adding(1,2);
            Console.WriteLine(result);
        }
    }
}
