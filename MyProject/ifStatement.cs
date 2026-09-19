using System;
namespace MonProjet
{
    class Program
    {
        static void Main(string[] args)
        {
    //1
            Console.WriteLine("Please entre your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
   
            if  (age > 100){
                  Console.WriteLine("You are too old !");
            }else if (age >= 18){
                  Console.WriteLine("your age is great than 18 years old");
            }
            else if(age < 0){
                  Console.WriteLine("You haven't been born yet !");
            }
            else {
                  Console.WriteLine("Your age must be great than 18 years old ");
            }
    //2
            Console.WriteLine("Please entre your name : ");
            string name = Console.ReadLine();

            if (name == " "){
                  Console.WriteLine("You must entre your name");
            }else {
                  Console.WriteLine("Your name is "+ name);
            }
            Console.ReadKey();
    //3
            Console.WriteLine("Please entre your name : ");
            string name = Console.ReadLine();
            
            if (name != " "){
                  Console.WriteLine("Your name is "+ name);
            }else {
                  Console.WriteLine("You must entre your name");
            }
            Console.ReadKey();
        }
// ********************************************** Logical operators ***********************************************************************************************
      static void Main(string [] args)
      {
            // Logical operators = && (AND) , || (OR)   

            Console.WriteLine("What's the tomperature outside : (c) ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp < 25 ){
                  Console.WriteLine("It's warm outside");
            } else if (temp > 25 && temp < 50){
                  Console.WriteLine("It's hat outside");
            }else if ( temp < 10 || temp < 0 ){
                  Console.WriteLine("It's coold outside");
            }else {
                  Console.WriteLine("It's not in program");
            }
      }
// ********************************************** Conditional operator *********************************************************************************************************
     // conditional operator = a shortcut to evaluate a boolean expression. 
     //                          3 operands (value if true , value if false)
     //         ======>         (condition) ? (value if true) : (value if false)

      static void Main (string [] args )
      {
            Console.WriteLine("Entre your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            string message = (age >= 18) ? "You are an adult" : "You are not an adult";
            Console.WriteLine(message);
      }
  }
}
    
