#region Boucles
//for (itérateur; condition d'arrêt de la boucle; évolution de l'itérateur à chaque boucle)
// quand on sait le nb de fois que l'on veut itérer
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    Console.WriteLine("Hello");
}


// multiple itérateur
for (int i = 0, j = 25; i < 10 || j > 5; i++, j -= 2)
{
    Console.WriteLine(i);
    Console.WriteLine(j);
    Console.WriteLine("_______");
}


//while
//quand on ne sait pas le nb de fois que l'on veut itérer
bool condition = true;
/*
 * while (condition)
{
    Console.WriteLine("Entrez un nombre : ");
    int nb = int.Parse(Console.ReadLine());
    if (nb > 5)
    {
        condition = false;
    }
}
*/

int nb = 0;
while (nb <= 5)
{
    Console.WriteLine("Entrez un nombre : ");
    nb = int.Parse(Console.ReadLine());
}


// do while
// pour être certain que les instructions soient exécutées au moins une fois
do
{
    Console.WriteLine("Entrez un nombre : ");
    nb = int.Parse(Console.ReadLine());
} while (nb <= 5);


// foreach
int[] tab = [42, 73, 12, 53, 4, 15, 66, 87];
foreach (int value in tab)
{
    Console.WriteLine(value);
}

// le foreach équivaut à un while caché :
var enumerator = tab.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}
enumerator.Reset();

#endregion
