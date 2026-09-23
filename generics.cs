using System;
namespace MyProject
{
    class Program
    {
        // generics = not specific to a particuler data type . add <T> to : classes , methods , fields  ...
        //            allows for code reusability for different data types 

        static void Main (String [] args )
        {
              int[] IntArray = { 1 , 2 , 3};
              double[] doubleArray =  {1.0 , 2.0 , 3.0} ;
              string[] stringArray = {"1" , "2" , "3"};
              displayElements(IntArray);
              displayElements(doubleArray);
              displayElements(stringArray);
        }
        public static void displayElements<Thing>(Thing[] array)
        {
              foreach (Thing item in array )
              {
                    Console.Write(item);
              }
              Console.WriteLine();
        }
    }
}
