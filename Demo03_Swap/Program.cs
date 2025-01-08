#region Swap de variables

int v1 = 42;
int v2 = 0;

/*// inverser la valeur de 2 variables via une variable temporaire
int t = v1;
v1 = v2;
v2 = t;
*/

// inverser 2 variables via un tuple
(v1, v2) = (v2, v1);

Console.WriteLine("V1:" + v1);
Console.WriteLine("V2:" + v2);


#endregion