using System;
namespace Variables2
{
    class Program 
    {
        static void Main(string [] args)
        {    
           int a = 5; // integer 
           int b = 10;
           int c = b / a;
           int age = 19;
           double d = 5.5; // decimal number
           double height = 160.5;
           bool alive = true; // boolean
           char symbol = '@'; // character
           string name = "Lily"; // string
           String userName = symbol + name; // string
           Console.WriteLine(d * a + b);
           Console.WriteLine("My age is " + age);
           Console.WriteLine("My height is " + height + " cm");
           Console.WriteLine("Are you alive? " + alive);
           Console.WriteLine("The symbol is: " + symbol);
           Console.WriteLine("My name is: " + name);
           Console.WriteLine("My username is: " + userName);
        }
    } 
  }