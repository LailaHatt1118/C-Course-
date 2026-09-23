using System;
namespace MyProject
{
    class Program
    {
        // Auto implemented properties = shortcut when no additional logic is required in the property you do not have 
        //                                define a field for a property , you only have to write get ; and/or set ; inside the property
        
        static void Main (String [] args )
        {
              Car car = new Car ("Ferrari");
              Console.WriteLine(car.Model);
        }
        class Car {
              public string Model {get ; set ;}
              public Car (string model){
                    this.Model = model ;
              }
        }
    }
}