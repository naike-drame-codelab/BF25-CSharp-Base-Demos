#region Types caractères

// simple caractère
char c = 'N'; // toujours utiliser les simple quotes pour les char
string fname = "Naïké";
string lname = "Dramé";
double price = 0.1D * 3;

string s = "Bonjour \n les\t \"AMIS\"";
string s2 = @"Bonjour
les        ""amis""
";

string directory = "c:\\Users\\Desktop\\";
string directory2 = @"c:\Users\Desktop\";


Console.WriteLine(s);
Console.WriteLine(s2);
Console.WriteLine(directory);
Console.WriteLine(directory2);

// concaténation
Console.WriteLine("Bonjour " + fname + " " + lname + " !!!");

// string format
Console.WriteLine("Bonjour {0} {1} !!!", fname, lname);

// string interpolation
Console.WriteLine($"Bonjour {fname} {lname} !!!");

// formater les chiffres
Console.WriteLine($"Prix : {price:F2}"); //limite à 2 décimales

int month = 1;
int day = 5;
int year = 2000;

Console.WriteLine($"{day:D2}/{month:D2}/{year}");

string alphabet = "abcdefghijklmnopqrstuvwxyz";
char letter = alphabet[4];
Console.WriteLine(letter); //e
Console.WriteLine(alphabet[..5]); //abcde
Console.WriteLine(alphabet[23..]); //xyz
Console.WriteLine(alphabet[^3..]); //xyz
Console.WriteLine(alphabet[5..10]); //fghij : àpd 5e non inclus jusqu'au 10e
Console.WriteLine(alphabet[5..10] + alphabet[15..20] + "test"); //fghijpqrsttest


#endregion
