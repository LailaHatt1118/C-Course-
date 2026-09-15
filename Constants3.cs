using system;
namespace Constants3
{
    class Program
    {
        static void Main(string [] args)
        {
            const double pi = 3.14; // constant variable
            const int maxValue = 100; // constant variable
            Console.WriteLine("The value of pi is: " + pi);
            Console.WriteLine("The maximum value is: " + maxValue);
        }
// ***************************************************** Type casting ***********************************************************************************************
    static void Main(string [] args)
    {         
        //   type casting = converting a value to a different data type Useful when we accept user input (sting)
        //                  different data types can do diffrerent things 
        
        double a = 3.14 ;
        int b = Convert.ToInt32(a) ;
        int c = 123 ;
        double d = Convert.ToDouble(c);
        int e = 123 ;
        string f = Convert.ToString(e);
        string g = "$";
        char h = Convert.ToChar(g);
        string i = "false";
        bool j = Convert.ToBoolean(i);
        Console.WriteLine(j.GetType());  // GetType : give the variable type
        Console.WriteLine(j);
    }

    }
}