using System; 
namespace MyProject
{
    class Program
    {
        // static = modifier that makes a member belong to the type itself rather than to a specific object. 
        //          static members are shared by all instances of the class and can be accessed without creating an instance of the class

        static void Main (string [] args )
        {
              Car car1 = new Car ("ford" , "Mustang" , "red" , 2023);
              Car car2 = new Car ("chevrolet" , "Camaro" , "blue" , 2024);
              Car car3 = new Car (" Dodge" , "Charger" , "black" , 2025);
              car1.Carinfo();
              car2.Carinfo();
              Console.WriteLine(Car.wheels);
        }
        public class Car {
              string make = "";
              string model = "";
              string color = "";
              int year = 0;
              public static int wheels = 0 ;   //// static member

              public Car (string make , string model , string color , int year ){
                    this.make = make ; 
                    this.model = model ;
                    this.color = color ; 
                    this.year = year ;
                    wheels += 4 ;  //// increment the static member
              }
              public void Carinfo (){
                    Console.WriteLine("Car make is : "+make);
                    Console.WriteLine("Car model is : "+model);
                    Console.WriteLine("Car color is : "+color);
                    Console.WriteLine("Car year is : "+year);
              }
        }
    }
}