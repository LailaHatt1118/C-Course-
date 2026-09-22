using System;
namespace MyPrgram
{
    class pROGRAM 
    {
        // Interface = a contract. defines a set of methods and properties that the class must implement.
        //             interface = a completely "abstract class" that contains only abstract members.
         
        static void Main ( String [] args ){
              Rabbit rabbit = new Rabbit();
              Hawk hawk = new Hawk();
              Fish fish = new Fish();
              rabbit.Flee();
              hawk.Hunt();
              fish.Flee();
              fish.Hunt();
        }
        interface IPrey {   
              void Flee();
        }
        interface IPredator {
              void Hunt();
        }
        class Rabbit : IPrey {
              public void Flee() {
                    Console.WriteLine("The rabbit is fleeing");
              }
        }
        class Hawk : IPredator {
              public void Hunt() {
                    Console.WriteLine("The hawk is hunting");
              }
        }
        class Fish : IPrey , IPredator {
              public void Flee() {
                    Console.WriteLine("The fish is fleeing");
              }
              public void Hunt() {
                    Console.WriteLine("The fish is hunting");
              }
        }
    }
}