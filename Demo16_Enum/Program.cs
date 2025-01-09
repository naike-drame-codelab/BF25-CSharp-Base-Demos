#region Enumération

// différence entre une string et un enum
// dans une string, il n'y a pas de restriction
string fuel = "hjgshgjhgr";

// un enum est un type créé qui va restreindre les variables déclarées à des valeurs définies au départ
// exemple d'enum dans le System: ConsoleColor, DaysOfWeek, ConsoleKey
// un enum est définie à la compilation et ne peut plus être modifiée au runtime/quand ça tourne
FuelType fuelType = FuelType.Diesel;
Console.WriteLine(fuelType); // Diesel

// un enum peut être casté
// par défaut l'enum commence à 1
// mais on peut modifier le premier élément de la liste (les valeurs suivants seront incrémentées en fonction du 1er élément)
Console.WriteLine((int)fuelType); // 42

// utilisation de l'addition binaire pour définir plusieurs valeurs
Role r = Role.Vendeur | Role.Reassortisseur | Role.Rh;
Console.WriteLine((int)r); // 7

if (r.HasFlag(Role.Directeur) && r.HasFlag(Role.Vendeur))
{
    Console.WriteLine("Bonjour M. le Directeur");
}


// transformer un enum en tableau d'enum
FuelType[] types = Enum.GetValues<FuelType>(); // [Diesel, Essence, Gaz, Electricite]


// transformer un enum en tableau de string
string[] types2 = Enum.GetNames<FuelType>(); // [Diesel, Essence, Gaz, Electricite]


// transformer un string en enum
FuelType type1 = Enum.Parse<FuelType>("Diesel"); // Diesel


// transformer un enum en string
string s = FuelType.Essence.ToString();


// transformer un int en enum
FuelType f = (FuelType)43; // Essence


// transformer un enum en int
int value = (int)FuelType.Electricite; // 45



// création de type
// utile quand on sait que l'on est fixe
enum FuelType
{
    Diesel = 42,
    Essence,
    Gaz,
    Electricite
}

// pour définir des coombinaisons d'enum complexes, on utilise des [Flags]
[Flags]
enum Role
{
    // None = 0,
    Vendeur = 1, // 0b001
    Reassortisseur = 2,// 0b010
    Rh = 4, // 0b100 pour que les combinaisons soient cohérentes au niveau des différentes valeurs, on passe directement à 4
    Directeur = 8     // on peut aussi faire en sorte que l'addition des 3 roles = role directeur = 7
}

/*
En binaire :
8 => 1000
4 =>  100 --> true, false, false
2 =>  010 --> false, true, false
1 =>  001 --> false, false, true

col1 = Rh | col2 = Reassortisseur | col3 = Vendeur

Si j'écris 110 => Rh et Reassortisseur
*/

#endregion
