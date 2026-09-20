using system; 
namespace MyProject 
{
    class Program
    {
        static void Main (string [] args )
        {
            Human human1 = new Human();
            human1.name = "Lily";
            human1.age = 20 ;

            human1.person();
            human1.Eat();
            human1.Sleep();
      
        }
        public class Human {

              public string name = "";
              public int age = 0;

              public void person (){
                    Console.WriteLine("Hello "+name +" you are "+age+" years old");
              }
              public void Eat () {
                    Console.WriteLine(name + " is eating ");
              }
              public void Sleep () {
                    Console.WriteLine(name + " is sleeping ");
              }

        }
// ********************************************** array of objects   *********************************************************************************************************
      static void Main (string [] args )
      {
            // array of objects = an array that holds objects of a class

            Human[] humans = new Human[3];  //// create an array of 3 humans
            humans[0] = new Human("Lily" , 20);
            humans[1] = new Human("Ghaith" , 2);
            humans[2] = new Human("Maya" , 5);

            Human[] humans = { new Human("Lily" , 20) , new Human("Ghaith", 2) , new Human("Maya" , 5) };  //// create an array of 3 humans

            foreach (Human human in humans)
            {
                  human.person();
            }
      }
      public class Human {
            public string name = "";
            public int age = 0;

            public Human (string name , int age ){
                  this.name = name ;
                  this.age = age ;
            }
            public void person (){
                  Console.WriteLine("Hello "+name +" you are "+age+" years old");
            }
      }
// ********************************************** objects as arguments *********************************************************************************************************
    static void Main (string [] args ){
          Car car1 = new Car ("Toyota", "red") ;
          ChangeColor(car1, "black");
          Console.WriteLine("Car number 1 is a " + car1.model + " and it's color is " + car1.color);
          
          Car car2 = Copy("BMW", "blue");
          Console.WriteLine("Car number 2 is a " + car2.model + " and it's color is " + car2.color);
    }
    public static Car Copy (string model, string color){
          return new Car (model , color);
    }
    public static void ChangeColor (Car car , string color){
          car.color = color ;
    }
    public class Car {
          
          public string model = "";
          public string color = "";

          public Car (string model , string color){
                this.model = model ;
                this.color = color ;
          }
    }

    }
}