using System;
namespace Output1
{
    class Program
    {
    static void Main(string [] args)
    {
          Console.Write("Hey Lily!");
          Console.WriteLine("Hello World");
          Console.Beep();                       // fr: faire un bip sonore  en : make a beep sound
               /*
                   this is a
                    multi-line comment
               */
           Console.WriteLine("\tHello World");   // fr: espace au debut  . en : space at the beginning
           Console.WriteLine("Hello \bWorld");   // fr: supprimer le caractère précédent  . en: delete the previous character
           Console.WriteLine("Hello\nWorld");    // fr: chaque mot sur une ligne différente  . en: each word on a different line
           Console.ReadKey();                    // fr: attendre que l'utilisateur appuie sur une touche pour fermer la console .en : wait for the user to press a key to close the console
        
        //fr: N.B : Write = reste sur la même ligne, WriteLine = passe à la ligne suivante après l'affichage. 
        //en: N.B : Write = stays on the same line, WriteLine = moves to the next line after displaying.
    }
    }
}