using System.Collections;
using System.Dynamic;

#region Collections - ArrayList & List

// ArrayList - Besoin d'ajouter using System.Collections;
// on peut mettre ce que l'on veut

ArrayList list = new();
list.Add(42);
list.Add(39);

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine(list.Count);

list.Add("Coucou");

foreach (var item in list)
{
    Console.WriteLine(item);
}

// List : typé

List<double> numbers = new();
numbers.Add(42);
// ints.Add("Hello"); --> error
numbers.Add(4.13);
numbers.Add(42);

// numbers.Remove(42); // retire la 1ère occurence trouvée --> [4.13, 42]
// numbers.RemoveAt(2);
// numbers.RemoveAll(n => n == 42);

numbers.AddRange([12, 66, 55]); // [4.13, 42, 12, 66, 55]

// vider une liste
numbers.Clear();

Console.WriteLine("--------");
foreach (var item in numbers)
{
    Console.WriteLine(item);
}


#endregion


#region Collections - Hashtable - A éviter car manque de typage cohérent

Hashtable hashtable = new();

// on détermine nous-mêmes les indices au départ (pas auto-incrémentés) --> key/value pair
// comme on définit nous-mêmes, cela peut amener à des inconvénients : 
hashtable.Add("one", "Maison");
hashtable.Add("two", "Appartement");
hashtable.Add("toto", "Chateau");
hashtable.Add(false, true);

hashtable.Add("test", "khun");
hashtable.Add("machin", "mike");

/*
foreach (var item in hashtable)
{
    Console.WriteLine(item.GetType());
    Console.WriteLine(((DictionaryEntry)item).Value);
}
*/


#endregion


#region Collections - Dictionary<Tk, Tv>

Dictionary<string, string> dico = new();
dico.Add("test", "khun");
dico.Add("machin", "mike");


foreach (var item in dico.Values)
{
    Console.WriteLine(item);
}
foreach (var item in dico.Keys)
{
    Console.WriteLine("clé: ");
    Console.WriteLine(item);
    Console.WriteLine("valeur: ");
    Console.WriteLine(dico[item]);
}

// foreach (KeyValuePair<string, string> item in dico)
foreach (var item in dico)
{
    Console.WriteLine("clé: ");
    Console.WriteLine(item.Key);
    Console.WriteLine("valeur: ");
    Console.WriteLine(item.Value);
}


Console.WriteLine("test");
numbers.Select((val, key) => (val, key)).ToList().ForEach(v =>
{
    Console.WriteLine(v.key);
    Console.WriteLine(v.val);
});

int i = 0;

foreach (var item in numbers)
{
    Console.WriteLine(item);
    Console.WriteLine(i++);
}


#endregion


#region Collections  - Queue  - FIFO (// file d'attente)

#endregion


#region Collections  - Stack  - LIFO (// pile d'assiettes)

#endregion


#region Collections  - Objet anonyme
Dictionary<string, int> trad = new(); //dictionary = similaire à objet anonyme
trad.Add("One", 1);
trad.Add("Two", 2);

var trad2 = new { One = 1, Two = 2 };
Console.WriteLine(trad["One"]);
Console.WriteLine(trad2.One);

#endregion


#region Collections  - Objet dynamique
dynamic d = new ExpandoObject();
d.One = 1;
d.Two = 2;
d.Three = 3;

Console.WriteLine(d.One);


//long value = long.Parse(Console.ReadLine());


#endregion