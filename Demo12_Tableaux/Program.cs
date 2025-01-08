#region Tableaux

// type de valeur[]
// derrière les [] se cache la class Array --> type référence (struct en C# : type valeur)

// créer un tableau contenant 4 entiers
// par défaut [0,0,0,0]
int[] tableau = new int[4];
Console.WriteLine();

string[] tableauDeString = new string[4];
// par défaut [null,null,null,null]

// initialisation d'un tableau avec plusieurs valeurs
string[] noms = ["Khun", "Mike", "Thierry"];
string[] autresNoms = { "Khun", "Mike", "Thierry" };

// comparer 2 tableaux
Console.WriteLine(noms == autresNoms); // false car tableau = type référence, == : compare les adresses mémoires
Console.WriteLine(noms.SequenceEqual(autresNoms)); // true, SequenceEqual() : compare les valeurs des 2 tableaux

// récupérer un élément du tableau
Console.WriteLine(noms[2]); ; // Thierry

// modifier un élément du tableau
Console.WriteLine(noms[2] = "Simon");
Console.WriteLine(noms[2]); // Simon

// slice
string[] nomsDeMesCollegues = autresNoms[^2..]; // ["Mike", "Thierry"] --> récupère un tableau contenant les 2 derniers éléments

// longueur d'un tableau
int l = nomsDeMesCollegues.Length;
int l2 = nomsDeMesCollegues.Count(); // récupère la taille de n'importe quelle collection mais plus lent

// attention à ne pas sortir des index d'un tableau
// les tableaux ont une taille FIXE
// string n = noms[42]; // erreur

// inverser les valeurs du tableau
noms = noms.Reverse().ToArray();
Console.WriteLine(string.Join(",", noms)); // Simon, Mike, Khun

// copier l'adresse mémoire du tableau
string[] t = noms;
t[0] = "Caroline";
Console.WriteLine(noms[0]); // Caroline

// copie des valeurs du tableau
// string[] t2 = noms.ToArray();
string[] t2 = [..noms];
t2[0] = "John";
Console.WriteLine(noms[0]); // Caroline

string[] t3 = ["Ringo", .. noms, "Steve"]; // ["Ringo", "Caroline", "Mike", "Khun", "Steve"]


// Any() : mieux d'utiliser Length pour des questions de performances
// if(!ints.Any()) 
int[] ints = new int[0];
if (ints.Length == 0)
{
    Console.WriteLine("Le tableau est vide");
}


// multidimension

// tableau de tableaux ou orthogonaux
int[][] tableauDeTableaux = new int[5][];
tableauDeTableaux[0] = [1, 2, 3];
tableauDeTableaux[1] = [5, 2, 42];

// les tailles des tableaux internes peuvent être différentes
tableauDeTableaux[2] = [5, 2, 44, 33, 66];


// tableau matriciel : chaque dimension contient le même nb d'éléments
// les dimensions sont séparées par une virgule
int[,] matrice = new int[4, 6];
matrice[0, 5] = 42;

int[,,,,] matrice5Dimensions = new int[4, 5, 3, 2, 6];
Console.WriteLine();

object[] objects = [1, "", 555F, true];
object[][] tabtab = new object[5][];
tabtab[0] = [1, 2, 3];
tabtab[2] = ["", "", ""];

#endregion
