using System;
namespace MonProjet
{
    class stringMethods6
    {
        static void Main(string [] args)
        {
            string fullName = "lilly Hatt" ;
            fullName = fullName.ToUpper();  // il va mettre tout en majuscule  / he's going to put everything in uppercase
            fullName = fullName.ToLower();  // il va mettre tout en minuscule  / he's going to put everything in lowercase
            Console.WriteLine(fullName);

            string phoneNumber = "0638-3927-38";
            phoneNumber = phoneNumber.Replace("-",".");   // il va remplacer le tiret par un point  / he's going to replace the dash with a dot
            Console.WriteLine(phoneNumber);

            string userName = fullName.Insert(0,"Mlle "); // Ajouter Mlle au debut == Mlle lilly  / Add Mlle at the beginning == Mlle lilly
            Console.WriteLine(userName);
            Console.WriteLine(fullName.Length);

            string FirstName = fullName.Substring(0, 2);  // il donne juste deux lettres de mon prenom / he gives just two letters of my first name
            string LastName = fullName.Substring(6, 4);  // index est 6 , nbr des lettres est 4   / index is 6, number of letters is 4
            Console.WriteLine( LastName);
        }
    }
}