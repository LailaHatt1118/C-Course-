using System;
namespace MonProjet
{
    class Program 
    {
        static void Main(string [] args)
        {
            // for loop = repeats some code a finite amount of times 
            // fr : répète un certain code un nombre fini de fois

            for (int i = 1 ; i<66 ; i++) {
                  Console.WriteLine(i);
            }
            Console.WriteLine("Happy birthday !");
            Console.Readkey();
        }
        
// ********************************************** Nested loops ***********************************************************************************************
      static void Main(string [] args)
      {
        // Nested loops = loops insidz of other loops uses vary. Used a lot in sorting altgorithme 
        // fr : des boucles à l'intérieur d'autres boucles sont utilisées de différentes manières. Elles sont beaucoup utilisées dans les algorithmes de tri.

        Console.Write("How many rows ? :");                
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many columns ? :");
        int columns = Convert.ToInt32(Console.ReadLine());

        Console.Write("What symbol: ");
        string symbol = Console.ReadLine();

        for (int i = 0; i < rows; i++){
              for ( int j = 0; j < columns; j++){
                    Console.Write(symbol);
              }
              Console.WriteLine();
        }
      }
    }
}