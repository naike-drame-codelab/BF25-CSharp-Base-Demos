using System.Text;


#region Structures conditionnelles

Console.WriteLine("Test");
int age = 8;
Console.OutputEncoding = Encoding.UTF8;

// if : on teste des conditions
if (age >= 18)
{
    // instructions
    Console.WriteLine("🙈🙈🙈");
}
else if (age >= 12)
{
    Console.WriteLine("🐼🐼🐼");
}
else
{
    // autres instructions
    Console.WriteLine("🦄🦄🦄");
}

string temps = "Soleil";
// switch : on teste généralement des égalités, pour tester dans un switch des conditions on utilise when
// case "Soleil" when temps.Length > 5:
switch (temps)
{
    case "Soleil":
    case "Sunny":
        //instructions
        Console.WriteLine("🌞");
        break;
    case "Nuage":
    case "Cloudy":
        Console.WriteLine("☁☁☁");
        break;
    default:
        Console.WriteLine("🌈🌈🌈");
        break;
}


#endregion