using System;
namespace MyProject
{
    class Program
    {
        // getters & setters = add security fo fields by encapsulation they're accessors found within properties
        // properties = combine aspects of both fields and method (share name with field)
        // Get accessor = Used to return the property value 
        // Set accessor = Used to assign a new value 
        // value keyword = defines the value being assigned by the set (parameter)


        static void Main (string[] args)
        {
              Car car = new Car(100);
              Car car1 = new Car(-200);
              car.Speed = -150;
              car1.Speed = 150;
              Console.WriteLine("The car speed is : " + car.Speed);
              Console.WriteLine("The car speed is : " + car1.Speed);
        }
        class Car {
              public int speed ;
              public Car (int speed ){
                    Speed = speed ;
              }
              public int Speed {
                    get { return speed; }
                    set { 
                          if (value < 0) {
                                speed = 0;
                          } else {
                                speed = value;
                          }
                    }
              }
        }
    }
}