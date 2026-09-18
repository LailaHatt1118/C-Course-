using System;
namespace Monprojt
{
    class Program
    {
      static void Main(string [] args)
      {
        do 
        {
            
            Console.WriteLine("Calculater program");

            double res ;
            Console.Write("Enter a Number 1 :");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a Number 2 :");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a option :");
            Console.WriteLine("\t + :");
            Console.WriteLine("\t - :");
            Console.WriteLine("\t * :");
            Console.WriteLine("\t / :");
            Console.WriteLine("\t % :");
            Console.Write("Enter a option :");

            switch (Console.ReadLine())
            {
                  case "+": 
                        res = num1 + num2 ;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + res);
                        break;

                  case "-": 
                        res = num1 - num2 ;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + res);
                        break ;

                  case "*": 
                        res = num1 * num2 ;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + res);
                        break;

                  case "/": 
                        res = num1 / num2 ;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + res);
                        break;

                  case "%": 
                        res = num1 % num2 ;
                        Console.WriteLine($"Your result: {num1} % {num2} = " + res);
                        break;
                  default:
                        Console.WriteLine("That was not a valid option");
                        break;
            }
            Console.WriteLine("Thanks for using our calculor proram");
            Console.Write("Would you like to continue ? (Y = yes , N = No) : ");
      } while (Console.ReadLine().ToUpper() == "Y");
      Console.WriteLine("Bye");
      }
    }
}