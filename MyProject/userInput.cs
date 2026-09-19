using system ;
namespace UserInput4
{
    class Program
    {
        static void Main(string [] args)
        {
            // user input = data that is provided by the user of a program
            //              allows a program to accept data from the user while the program is running
            //              can be used to make decisions in a program or customize it for each user

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old.");

            Console.Write("Enter your height in cm: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You are " + height + " cm tall.");
        }
// ***************************************************** Arithmatic operators ***********************************************************************************************

        static void Main(string [] args)
        {
            int friends = 10 ;

            friends = friends + 1 ;     
            friends += 2 ;
            friends ++ ;

            friends = friends - 1 ;
            friends -= 2 ;
            friends -- ;

            friends = friends * 2 ;
            friends *= 2 ;

            friends = friends / 2 ;
            friends /= 2 ;

            int reminder = friends % 2;

            Console.WriteLine(reminder);
         }
    }
}