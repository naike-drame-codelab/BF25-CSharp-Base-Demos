using System.Globalization;

#region Transtypage (cast)

int nb = 42;
double nb2 = nb;

// transtypage (cast) explicite
double nb3 = 42.5;
int nb4 = (int)nb3;
// Equivalent CTS 
Int32 nbInt32 = 42;


string s = "42";
// un string ne peut pat être casté en int car pas de relation entre eux cf. principe héritage
// int nbEntier = (int)s;

int nbEntier = int.Parse(s);
Console.WriteLine(nbEntier * 25);

double floatNb = double.Parse("42.5");
bool flag = bool.Parse("False");
DateTime date = DateTime.Parse("1982-05-06T12:46:42");

string v = 42.ToString();
string v2 = DateTime.Now.ToString(
    "dd MM yyyy",
    CultureInfo.GetCultureInfo("fr-BE")
    );
Console.WriteLine(v2);

//ne fonctionne pas
//int myNumber = int.Parse("42.3"); 

int.TryParse("42.3", out int myNumber);
Console.WriteLine(myNumber); // va afficher valeur 0 car le system n'aura pas réussi à convertir mais le programme ne plante pas avec un TryParse()

int a = default;
Console.WriteLine(a); // O
string b = default;
string empty = string.Empty;
Console.WriteLine(b); // ""
Console.WriteLine(empty); // ""
bool c = default;
Console.WriteLine(c); // False


Console.WriteLine("Entrez un nombre: ");
int inputNb;
while (!int.TryParse(Console.ReadLine(), out inputNb))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valeur incorrecte");
    Console.ResetColor();
}
Console.WriteLine(inputNb);


#endregion
