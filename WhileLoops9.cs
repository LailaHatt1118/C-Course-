using System;
namespace MonProjet
{
    class Program
    {
        static void Main(string [] args)
        {
            // While loops = execute a block of code as long as a specified condition is true 
            // fr : exécuter un bloc de code tant qu’une condition spécifiée est vraie
            // while (condition) { code block }

            Console.WriteLine("Entre your name : ");
            string name = Console.ReadLine();            

            while (name == " "){
                  Console.WriteLine("Entre your name : ");
                  name = Console.ReadLine();
            }
            Console.WriteLine("Hello "+ name);


          //  infinite loops   :

            while (1 == 1){
                  Console.WriteLine("HELP! i'm stuck in infinite loop ! ");
            }

            double a = 33.5 ; 
            double b = 44.5 ; 
            double c = Math.Floor(a*b);

            while (a == 33.5){
                  Console.WriteLine("While a * b is :" +c);
            }
      }
    }
}