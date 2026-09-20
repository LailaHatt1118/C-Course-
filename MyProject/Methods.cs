using system;
namespace Monprojet
{
    class Program
    {
        static void Main(string [] args)
        {
              mathod = performs a section of code , whenever it's called "invoked" .
                       benefit = Let's us reuse code writing it multiple times
        string name = "Lily";
        int age = 19 ;
              sinHappyBirthday(name, age);
              sinHappyBirthday(name, age);
        }
        static void sinHappyBirthday(string bname , int bage)  // i can give them same param like static main or not ,two methods it's work
        {
              Console.WriteLine("Happy birthday to you "+bname);
              Console.WriteLine("Happy birthday to you "+bname);
              Console.WriteLine("You are " + bage +" years old");
              Console.WriteLine("Happy birthday to you !");
        }
// ********************************************** return keyword *********************************************************************************************************
        static void Main(string [] args)
        {
              double x ;
              double y ;
              Console.WriteLine("Entre number 1 :");
              x = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Entre number 2 :");
              y = Convert.ToDouble(Console.ReadLine());
              double result = Multiply (x , y);
              Console.WriteLine("The result is : " + result);
        }

        static double Multiply (double x, double y)
        {
              return  x * y ;

        }
// ********************************************** method overloading *********************************************************************************************************
        static void Main(string [] args)
        {
              double result = Multiply (10 , 30 );
              Console.WriteLine("The result is : " + result);
        }
        
        static double Multiply (double a, double b)
        {
              return  a * b ;
              
        }
        static double Multiply (double a, double b, double c)
        {
              return a * b * c ;
        }
// ********************************************** params keyword *********************************************************************************************************
      // params keyword = allows a method to accept a variable number of arguments

     static void Main(string [] args)
     {
           double total = checkout(11.88 , 99.8 , 14.09);
           Console.WriteLine("total is :" + total);
     }
     static double checkout (params double [] prices)
     {
           double total = 0 ;
           foreach ( double price in prices)
           {
                 total += price ;
           }
           return total ;
     }
// ********************************************** String interpolation  *********************************************************************************************************
      // String interpolation = a way to format strings that is more readable and easier to write with ${} 
      static void Main (String [] args )
      {
            int age = 19 ;
            string firstName = "Lily";
            string lastName = "Hatt";
            Console.Write($"Your First Name is {firstName} and your Last Name is {lastName}");
            Console.Write($" and your age is {age , -10} years old");
      }
    }
}