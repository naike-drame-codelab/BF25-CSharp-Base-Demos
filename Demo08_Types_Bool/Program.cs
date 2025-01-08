#region Types booléens

bool flag = false;
bool flag2 = true;

int age = 42;

bool majeur = age > 1;
Console.WriteLine(majeur);

// > plus grand
// >= plus grand ou égal
// < plus petit
// <= plus petit ou égale
// == égal
// != différent
// ! négation

Console.WriteLine(42 == age);
Console.WriteLine(42.Equals(age));

string name = "    Cocoa   ".Trim();
Console.WriteLine(name.Equals("Cocoa"));
Console.WriteLine(name == "Cocoa");

Console.WriteLine(name == "coCoA"); // false
Console.WriteLine(name.Equals("cocoa", StringComparison.InvariantCultureIgnoreCase)); // true

// OU inclusif, ET, XOR (OU exclusif)
bool youngAdult = age > 18 && age < 30;
Console.WriteLine(youngAdult);
Console.WriteLine(age == 42 || name == "Cocoa"); // OR
Console.WriteLine(age == 42 ^ name == "Cocoa"); // XOR

// changer OU en ET
Console.WriteLine(age != 42 && name != "Cocoa");
Console.WriteLine(!(!(age == 42) && !(name == "Cocoa")));

// inverser un booléen
bool test = true; // true
bool test2 = !test; // false

// loi de Morgan
// !(cond1 && cond2) <=> !cond1 || !cond2
// !(cond1 || cond2) <=> !cond1 && !cond2

Console.WriteLine(true | true); // OU binaire
Console.WriteLine(true & true); // ET binaire
Console.WriteLine(true || true);

#endregion