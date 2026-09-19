using systeme ;
namespace MathClass5
{
    class Program
    {
        static void Main(string [] args)
        {
            // math class = a class that contains methods for performing mathematical operations
            //              useful for performing calculations and working with numbers

            double a = 3.14 ;
            double b = -7 ;
            double c = 4.8 ;

            Console.WriteLine(Math.Abs(b));       // ex : x = -7 it gives 7 the positive number
            Console.WriteLine(Math.Pow(a, 2));    // "Power" = puissance x² 
            Console.WriteLine(Math.Sqrt(c));      // Sqrt = "Square Root" (racine carrée)
            Console.WriteLine(Math.Max(a, c));    // Max = "maximum" , ex : 3.14 and 4.8 it gives 4.8
            Console.WriteLine(Math.Min(a, c));    // Min = "minimum" , ex : 3.14 and 4.8 it gives 3.14
            Console.WriteLine(Math.Round(c));     // Round = "arrondi" (round) , ex : 4.8 it gives 5
            Console.WriteLine(Math.Floor(c));     // Floor = "arrondi inférieur" (round down) , ex : 4.8 it gives 4
            Console.WriteLine(Math.Ceiling(c));   // Ceiling = "arrondi supérieur" (round up) , ex : 4.8 it gives 5
        }
// ***************************************************** Random Numbers ***********************************************************************************************
        static void Main(string [] args)
        {
            Random random = new Random();
            int num1 = random.Next(1, 70000);    // min 1 et max 70000 ==> random integer number 
            int num2 = random.Next(1, 70000);
            int num3 = random.Next(1, 70000);
            double num1 = random.NextDouble();    // random double number 
            double num2 = random.NextDouble(); 
            double num3 = random.NextDouble(); 
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
// ********************************************** Hypotenuse calculator program ***********************************************************************************************
        static void Main(string [] args)
        {
         Console.WriteLine("Enter side A: ");
         double a = Convert.ToDouble(Console.ReadLine()); 

         Console.WriteLine("Enter side B: ");
         double b = Convert.ToDouble(Console.ReadLine());

         double c = Math.Sqrt((a*a) + (b*b));
            // //  double c = Math.Round((a*a) + (b*b));

         Console.WriteLine("The hypotenuse is: " +c);
        }
    }
}