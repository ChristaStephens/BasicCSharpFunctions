using System;

//namespace is the main folder.
//use dot notation to go into that folder.
namespace basicfunctions.Calc
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Friend! Welcome to Calcutron 5000.");
            Console.WriteLine("Please enter your name?");
            string name= Console.ReadLine();
            Console.WriteLine("Thank you for that information "+ name + "!");
            Console.WriteLine("What type of calculation would you like to do today "+ name +  "?");
            Console.WriteLine("Here are your options: +, -, *, /");
            string operation = Console.ReadLine();
            Console.WriteLine("Please enter your first number: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("Please enter your second number: ");
            string num2 = Console.ReadLine();
            //need two numbers

            do{

                if (operation == "+"){
                int a = Int32.Parse(num1);
                int b = Int32.Parse(num2);
                int result1 = a + b;
                Console.WriteLine("Your sum is " + result1 + "." + " Thank you for using Calcutron 5000 " + name + "!");

            } else if (operation == "-"){
                int a = Int32.Parse(num1);
                int b = Int32.Parse(num2);
                int result2 = a - b;
                Console.WriteLine("Your result is " + result2 + "." + " Thank you for using Calcutron 5000 " + name + "!");

            } else if(operation == "*"){
                int a = Int32.Parse(num1);
                int b = Int32.Parse(num2);
                int result3 = a * b;
                Console.WriteLine("Your sum is " + result3 + "." + " Thank you for using Calcutron 5000 " + name + "!");
            }else if (operation == "/"){
                int a = Int32.Parse(num1);
                int b = Int32.Parse(num2);
                int result4 = a / b;
                Console.WriteLine("Your sum is " + result4 + "." + " Thank you for using Calcutron 5000 " + name + "!");
            }
                Console.WriteLine("Would you like to use Calcutron again " + name + "?"+ "Type Yes to continue.");
                string answer = Console.ReadLine();
            } while ();




            // take in Calc type
            // if /  then do calc for division
            //if + then calc for +

        }

    }

}
