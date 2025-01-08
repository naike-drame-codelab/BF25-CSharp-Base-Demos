#region Structures
//-------------- Grosse différence entre struct & une class & un record: ----------------
// struct =  de type valeur ---> n'est pas un élément null
// class =  de type référence ---> peut être nullable
// record = constante, on ne peut plus modifier les infos venant de l'extérieur = info de base fixe (// ajouter readonly)


PersonStruct p = new PersonStruct();
p.age = 42;
p.fname = "Khun";
p.name = "Ly";

PersonStruct pbis = p;
Console.WriteLine(pbis.age); // 42

PersonStruct.Test t = new();


PersonClass p2 = new();
p2.age = 42;
p2.fname = "Khun";
p2.name = "Ly";
PersonClass p3 = p2;
p3.age = 43;
Console.WriteLine(p3.age); // 43

PersonClass p4 = new();
p4.age = 42;
p4.fname = "Mike";
p4.name = "Person";


PersonRecord record1 = new PersonRecord("Ly", "Khun", 42);
// record1.name = "test"; // error : on ne peut pas modifier
Console.WriteLine(record1.age);


// création d'un type
// on peut créer des struct imbriquées (slide 167) 
struct PersonStruct
{
    // !!! on ne peut pas définir de valeur par défaut sauf si déclarée avec const ou static
    public string name; // ""
    public string fname; // ""
    public int age; //0
    const int test = 42;

    // peut avoir des méthodes
    public void Speak() { }

    // peut avoir des struct internes
    public struct Test
    {

    }
}

class PersonClass
{
    public string name;
    public string fname;
    public int age;
}


record PersonRecord(string name, string fname, int age)
{
    public void Speak() { }
}


#endregion