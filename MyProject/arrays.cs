using system ;
namespace Monprojet 
{
    class Progrem 
    {
      static void Main(string [] args)
      {
      arrays = a variable that can store multiple value. fixed size 


      string[] cars = {"BMW" , "Toyota" , "Mustang"};  // declarer array and write some elements


      string[] cars = new string[4];      // ==> declarer array and fixed size , ex : 4 elements
      cars[0] = "Tesla";                  // write elements
      cars[1] = "BMW";
      cars[2] = "Toyota";
      cars[3] = "Mustang";

      Console.WriteLine(cars[0]);
      Console.WriteLine(cars[1]);
      Console.WriteLine(cars[2]);


      for ( int i = 0; i < cars.Length; i++)
      {
            Console.WriteLine(cars[i]);
      }
      }
// ********************************************** Multidimensional arrays  *********************************************************************************************************


      static void Main (String [] args )
      {
            // multidimensional arrays = an array of arrays. 
            //                          each element in the main array can hold another array
            //                          each array can hold multiple values


            int[] Numbers1 = {1, 2}; //// one-dimensional array
            int[] Numbers2 = {3, 4}; //// one-dimensional array
            int[] Numbers3 = {5, 6}; //// one-dimensional array


            int[,] numberGrid = {      //// three-dimensional array
                  {1, 2},
                  {3, 4},
                  {5, 6}
            };
            numberGrid[0, 0] = 99;   //// change the value of the first element in the first array to 99


            foreach (int Num in numberGrid)
            {
                  Console.WriteLine(Num);
            }


            for (int i = 0 ; i < numberGrid.GetLength(0); i++)  //// GetLength(0) = get the number of rows
            {
                  for (int j = 0 ; j < numberGrid.GetLength(1); j++)  //// GetLength(1) = get the number of columns
                  {
                        Console.Write(numberGrid[i, j]);
                  }
                  Console.WriteLine();
            }


            Console.WriteLine(numberGrid[1, 1]);
        //    
      }

    }
}