Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("🌈");


#region Méthodes 

// fonction = ensemble d'instructions encapsulées dans un espace mémoire, avec un nom et le type de retour de ladite fonction

// appel de la fonction Speak()
Person p;
p.Speak();
p.Speak();
p.Speak();
p.Speak();
p.Speak();

// appel de la fonction Test()
Test();
Test();
Test();
Test();
Test();
Test();

// appel de la fonction FactorielDeNb() qui retourne n!
int value = FactorielDeNb(5);
Console.WriteLine(value);

// définition de la fonction Test() qui ne retourne rien
void Test()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Ceci est un test");
    Console.ResetColor();
}

// définition de la fonction FactorielDe5() qui retourne un int
int FactorielDeNb(int nb)
{
    int result = 1;
    for (int i = 2; i <= nb; i++)
    {
        result *= i;
    }
    return result;
}

Console.WriteLine(Divide(1, 3));
Console.WriteLine(Divide(42)); //on remplace le param a
Console.WriteLine(Divide(b: 42)); // on remplace le param b

double Divide(double a = 1, double b = 1) // avec params par défaut
{
    return a / b;
}

// un param précdé du mot-clé in n'est plus modifiable au sein de la fonction
void Test44(in string s = "", int nb = 55)
{
    // on ne peut plus modifier un paramètre précédé du mot clé in
    //s = "dswdfsq";
}

// Lorsque nous ignorons le nombre de paramètres à passer, on peut passer un ensemble de params (ici de type array de doubles)
double Sum(params double[] values)   
{
    double result = 0;

    foreach (var item in values)
    {
        result += item;
    }

    return result;
}

Console.WriteLine("--------------");
Console.WriteLine(Sum(42, 7, 8, 9, 11, 33, 99));
// ||     ||       ||
Console.WriteLine(Sum([42, 7, 8, 9, 11, 33, 99]));


int v = 42;

// passer la reference plutot que la valeur
void UpdateValue(int v2)
{
    v2 = 45;
}

UpdateValue(v);
Console.WriteLine(v); // 42 car on modifie v2 et non v


// ref : on passe en param l'adresse mémoire de l'élément passé en param, et on peut ensuite modifier sa valeur
void UpdateValueWithRef(ref int v2)
{
    v2 = 45;
}

UpdateValueWithRef(ref v);
Console.WriteLine(v); // 45


List<int> list = [1, 2, 3];
List<int> list2 = [1, 2, 3];

UpdateList(list);
Console.WriteLine(list.Last());  // 4

void UpdateList(List<int> l)
{
    l.Add(4);
}

void UpdateListWithRef(ref List<int> l)
{
    l = [.. l, 4];
}

UpdateListWithRef(ref list2);
Console.WriteLine(list2.Last()); // 4 car on modifie la ref list2

// --- ou == ref
void UpdateValueWithRef2(out int v2)
{
    v2 = 45;
}

UpdateValueWithRef2(out v);
Console.WriteLine(v); // 45

// on peut retourner plusieurs valeurs // un tuple
(int, bool, string, char) Test55555()
{
    return (42, true, "", '\n');
}

(int nb, bool flag, string s, char c) = Test55555();
(int, bool i, string, char) tuple = Test55555();
Console.WriteLine(nb);
Console.WriteLine(tuple.Item1); // 42
Console.WriteLine(tuple.i); // true

// ancienne syntaxe :
Tuple<int, bool> t = new Tuple<int, bool>(42, true);
int bbb = t.Item1;
bool fff = t.Item2;


// Surcharge de méthode : un seul nom de méthode, mais en fonction du param appelé, la bonne méthode sera appelée
/*
public void MyMethod()
{
    //
}
public void MyMethod(int i)
{
    //
}
public void MyMethod(string s)
{
    //
}

*/

//---------------//

struct Person
{
    // définition de la fonction ----> ne pas oublier de documenter la fonction avec un summary, plus qu'avec des commentaires
    /// <summary>
    /// Ecrit dans la console qqch
    /// </summary>
    public void Speak()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Bonjour, je m'appelle Khun");
        Console.ResetColor();
    }
}


#endregion