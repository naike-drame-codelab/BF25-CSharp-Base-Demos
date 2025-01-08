using System.Globalization;
using System.Text;

#region Console.WriteLine(), Console.ReadLine()

// écrire dans la console
Console.WriteLine("Bonjour!");
Console.WriteLine("Comment vous appelez-vous ?");

// lire dans la console
string input = Console.ReadLine();

ConsoleKey key = Console.ReadKey(true).Key;

if (key == ConsoleKey.Enter)
{
    Console.WriteLine("Fais qqch");
}
else
{
    Console.WriteLine("Fais autre chose");
}


Console.WriteLine("Bienvenue " + input + " ! ♥");


#endregion
