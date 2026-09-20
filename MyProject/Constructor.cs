using system;
namespace MyProject
{
    class Program
    {
        // Ex 1 :
        static void Main (String [] args ){
              Human human1 = new Human("Lily", 20);
              Human human2 = new Human("Ghaith", 2);
              human1.person();
              human1.Eat();
              human1.Sleep();
              human2.person();
              human2.Eat();
              human2.Sleep();
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
        public void Eat () {
              Console.WriteLine(name + " is eating ");
        }
        public void Sleep () {
              Console.WriteLine(name + " is sleeping ");
        }
        }
        // Ex 2 :

        static void Main (string [] args ){
              car car1 = new car ("ford" , "Mustang" , "red" , 2023);
              car1.Carinfo();
        }
        public class car {
              string make = "";
              string model = "";
              string color = "";
              int year = 0;
              public car (string make , string model , string color , int year ){
                    this.make = make ; 
                    this.model = model ;
                    this.color = color ; 
                    this.year = year ;
              }
              public void Carinfo (){
                    Console.WriteLine("Car make is : "+make);
                    Console.WriteLine("Car model is : "+model);
                    Console.WriteLine("Car color is : "+color);
                    Console.WriteLine("Car year is : "+year);
              }
        }
// ********************************************** overloaded constructors  *********************************************************************************************************

      // overloaded constructors = technique of having more than one constructor with different parameters lists

      // L'idée : une même classe peut avoir PLUSIEURS constructeurs,
      // avec des listes de paramètres différentes (nombre ou type différent).
      // Ça permet de créer un objet de plusieurs façons, selon les infos
      // qu'on a au moment de la création.

      static void Main (string [] args)
      {
            Pizza pizza1 = new Pizza("thick" , "tomato");
            Pizza pizza2 = new Pizza("thin" , "tomato" , "mozzarella");
            Pizza pizza3 = new Pizza("thin" , "tomato" , "mozzarella" , "pepperoni");
      }
      public class Pizza (){
            string bread = "";
            string sauce = "";

            public pizza (string bread , string sauce  ){
                  this.bread = bread ;
                  this.sauce = sauce ;
            }
      }
      public class Pizza (){
            string bread = "";
            string sauce = "";
            string cheese = "";

            public pizza (string bread , string sauce , string cheese ){
                  this.bread = bread ;
                  this.sauce = sauce ;
                  this.cheese = cheese ;
            }
      }
      public class Pizza (){
            string bread = "";
            string sauce = "";
            string cheese = "";
            string topping = "";

            public pizza (string bread , string sauce , string cheese , string topping ){
                  this.bread = bread ;
                  this.sauce = sauce ;
                  this.cheese = cheese ;
                  this.topping = topping ;
            }
      }


    }
}