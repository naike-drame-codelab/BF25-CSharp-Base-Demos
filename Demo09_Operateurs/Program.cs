#region Opérateurs

// string

// concaténation 
Console.WriteLine("42" + 42); // 4242

// nombre
// addition +
Console.WriteLine(42 + 42); // 84

// soustraction - 
// division /
// multiplication *
// modulo %

Console.WriteLine(5 % 3); // 2 car 5 = 3 * 1 + (2)

// affectation
int a = 42; //42
a += 6; // a = a + 6 // 48
a %= 9; // a = a % 9 // 3
a <<= 2; // 12 // 11 => 1100 // 12 - déplacement binaire
// post-incrémentation
a++; // 4 // a = a + 1
// pré-incrémentation
++a; // 5 // a = a + 1 
//a--;
//--a;

Console.WriteLine(++a); // 6
Console.WriteLine(a); // 6

//opérateur ternaire
int age = 17;
string categorie = age >= 18 ? "Adulte" : "Enfant";
Console.WriteLine(categorie);

//opérateur switch
int jour = 5;
string j = jour switch
{
    1 => "Lundi",
    2 => "Mardi",
    3 => "Mercredi",
    _ => "Je ne sais pas"
};

Console.WriteLine(j);

// ? si on veut initialiser à null une variable/rendre une variable nullable
int? promo = null; 
int prix = 42;

Console.WriteLine(42 - ((promo == null ? 0 : promo) * prix / 100)); // 32

//coalesce = ternaire qui donne une valeur par défaut si la variable est nulle
Console.WriteLine(prix - ((promo ?? 0) * prix / 100));

string enter = Console.ReadLine() ?? string.Empty;

#endregion