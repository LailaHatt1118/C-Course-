 using System;
 namespace MyFirstProgram
 {
 // ********************************************** Classes *********************************************************************************************************
    
    // class program {
        // static void Main (string [] args )
        // {
            // Console.WriteLine("Hello World!");
        // }
    // }

    public static class Messages {
        public static void Hello ()
        {
            Console.WriteLine("Hello Welcome to my program ");
        }
        public static void Waiting ()
        {
            Console.WriteLine("I'm waiting for something");
        }
        public static void Bye ()
        {
            Console.WriteLine("Bye Bye !");
        }
    }
     
    /**  NB : lancer le programme avec la commande dotnet run dans le terminal, ou bien dotnet fichier.cs pour un seul fichier .cs
    
    cmd :                   _ dotnet fichier.cs	            _ dotnet run
    Fichiers compilés	    Un seul, celui indiqué	        Tous les .cs du projet
    Besoin d'un .csproj	    Non	                            Oui
    Cas d'usage	            Script rapide, 1 fichier	    Vrai programme, plusieurs fichiers/classes
    
    **/
     
     
     
 }
