using System;
namespace MyProject
{
    class Program
    {
        // inheritance (héritage) = the process by which one class takes on the attributes and methods of another class.

        static void Main (string [] arggs )
        {
              Car car1 = new Car();
              car1.go();
              car1.honk();
              Console.WriteLine("Car has " + car1.speed + " speed");
              Console.WriteLine("Car has " + car1.wheels + " wheels");

              Truck truck1 = new Truck();
              truck1.go();
              truck1.honk();
              Console.WriteLine("Car has " + truck1.speed + " speed");
              Console.WriteLine("Truck has " + truck1.wheels + " wheels");
        }
        class Vehicle {
              public int speed = 100;
              public void go (){
                    Console.WriteLine("The vehicle is moving  ");
              }
        }
        class Car : Vehicle {
              public int wheels = 4 ;
              public void honk (){
                    Console.WriteLine("The car is honking ");
              }
        }
        class Truck : Vehicle {
              public int wheels = 6 ;
              public void honk (){
                    Console.WriteLine("The truck is honking ");
              }
        }
// ********************************************** method overriding *********************************************************************************************************
        // method overriding = a child class redefines a method inherited from the parent class.
        //                      inherited method must be : abstract , virtual or already overridden
        //                      Used with ToString() , polyorphism

        static void Main (String [] args){
              Animal MyAnimal = new Animal();
              Dog MakeDog = new Dog();
              Cat MakeCat = new Cat();
              MyAnimal.MakeSound();
              MakeDog.MakeSound();
              MakeCat.MakeSound();
        }
        class Animal {
              public virtual void MakeSound (){  //// virtual = allows a method to be overridden in a derived class
                    Console.WriteLine("The animal makes a sound");
              }
        }
        class Dog : Animal {
              public override void MakeSound (){  //// override = overrides a virtual method in a derived class
                    Console.WriteLine("The dog barks");
              }
        }
        class Cat : Animal {
              public override void MakeSound (){  //// override = overrides a virtual method in a derived class
                    Console.WriteLine("The cat meows");
              }
        }
        
        /** 
            En résumé simple :
            static = appartient à la classe, pas à un objet.
            virtual = "tu peux redéfinir cette méthode si tu veux."
            abstract = "tu DOIS redéfinir cette méthode, je ne donne aucune implémentation."
            override = "je redéfinis effectivement cette méthode héritée."              
        **/
    }
}