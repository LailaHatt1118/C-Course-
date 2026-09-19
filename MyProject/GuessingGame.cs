using System;
namespace MonProjet
{
    class Program 
    {
      static void Main(string [] args)
      {
      Random random = new Random();
      bool playAgain = true;
      int min = 1;
      int max =100;
      int guess;
      int number;
      int guesses;
      string response ;
       
       while (playAgain){
            guess = 0;
            guesses= 0;
            response = " ";
            number = random.Next(min, max +1);
 
 
            while ( guess != number){
                  Console.WriteLine("Guss a number between " + min + " And " + max + ":");
                  guess = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Guess: " + guess);


                  if ( guess > number){
                        Console.WriteLine(guess + " is to  high !");
                  }else {
                        Console.WriteLine(guess + " is to low !");
                  }
                  guesses ++;
            }
            Console.WriteLine("Number: "+ number);
            Console.WriteLine("You Win !");
            Console.WriteLine("Guesses: "+ guesses);


            Console.WriteLine("Would you like to play again (Y/N)");
            response = Console.ReadLine();
            response = response.ToUpper();


            if (response == "Y"){
                  playAgain = true;
            }else if (response == "N") {
                  playAgain = false;
            }else{
                  Console.WriteLine("You should write Y or N");
                  Console.WriteLine("Play Again !");
            }


       }
       Console.WriteLine("Thanks for playing ! ... I guess");
      }


    }
}