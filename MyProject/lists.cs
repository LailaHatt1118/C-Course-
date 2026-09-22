using System;
namespace MyProgram
{
    class Program 
    {
        static void Main (String [] args)
        {
            // list = a collection of objects that can be accessed by index. 
            //        similar to array, but more flexible (can grow and shrink dynamically)

            List<string> food = new List<string>();
            food.Add("Pizza");
            food.Add("Hamburger");
            food.Add("Tagine");
            food.Remove("Pizza");
            food.Insert(0, "Sushi");
            food.Sort();               // Sort the list in alphabetical order
            food.Reverse();            // Reverse the order of the list
            food.Clear();              // Clear the list
            Console.WriteLine("The list has " + food.Count + " items");
            String[] FoodArray = food.ToArray();  // Convert the list to an array.
            foreach (string foodItem in food)
            {
                  Console.WriteLine(foodItem);
            }
            Console.WriteLine("The first food is : " + food[1]);
            Console.WriteLine("The list has " + food.Count + " items");
            Console.WriteLine("The list has " + food.Capacity + " capacity");
            Console.WriteLine(food.IndexOf("Tagine"));
            Console.WriteLine(food.LastIndexOf("Pizza"));
            Console.WriteLine(food.Contains("couscouss"));
        }
// ********************************************** List of objects *********************************************************************************************************
        
        static void Main (string[] args)
        {
              List<Human> humans = new List<Human>();
              Human human1 = new Human("Ghaith" , 2);
              humans.Add(human1);
              humans.Add(new Human("Lily" , 20));
              foreach (Human human in humans)
              {
                    human.person();
              }
              Console.WriteLine("The list has " + humans.Count + " Humans");
        }
        class Human {
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
    }
}