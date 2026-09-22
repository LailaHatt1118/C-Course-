using System;
namespace MyProject 
{
    class Program
    {
        // polymorphism = the ability of an object to take on many forms. 
        //                in OOP, polymorphism means that a parent class reference can refer to a child class o

        static void Main (String [] args ){
              Vehicle vehicle = new Vehicle();
              Car car1 = new Car();
              Truck truck1 = new Truck();
              Vehicle vehicle1 = new Car(); // Polymorphism in action
              Vehicle vehicle2 = new Truck(); // Polymorphism in action         
              Vehicle[] vehicles = {vehicle , car1, truck1, vehicle1, vehicle2}; // Array of vehicles
              foreach (Vehicle v in vehicles)
              {
                    v.go(); // Calls the appropriate go() method based on the actual object type
              }
        }
        class Vehicle {
              public virtual void go (){
                    Console.WriteLine("The vehicle is moving  ");
              }
        }
        class Car : Vehicle {
              public override void go (){
                    Console.WriteLine("The car is moving  ");
              }
        }
        class Truck : Vehicle {
              public override void go (){
                    Console.WriteLine("The truck is moving  ");
              }
        }
    }
}