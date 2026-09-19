using system;
namespace Monprojet 
{
    class Program
    {
        // exception = errors that during execution that can be caught with try and catch blocks.
        //          try = try some code that is considered "dangerous"
        //          catch = catches and handles exception when they occur 
        //          finally = always executes redardless if exception is caught or not (used for cleanup code)
        
        static void Main (string [] args)
        {
              int x ;
              int y ;
            try{
                  Console.WriteLine("Entre number 1 :");
                  x = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter number 2 :");
                  y = Convert.ToInt32(Console.ReadLine());
                  int result = x / y ;
                  Console.WriteLine("The result is : " + result);
            }
            catch (FormatException ) {
                  Console.WriteLine("You must enter a number !");
            }
            catch (DivideByZeroException ) {
                  Console.WriteLine("You can't divide by zero !");
            }
            catch (Exception ex) {
                  Console.WriteLine("Something wrong !");
            }
            finally {
                  Console.WriteLine("Thanks for using our program !");
            }
       }
    }
}
