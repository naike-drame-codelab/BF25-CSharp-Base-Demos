#region Types DateTime

// créer une date
DateTime date = new DateTime();
Console.WriteLine(date);

// créer une date basée sur la date du jour
DateTime today = DateTime.Now;

// formater une date
Console.WriteLine(today.ToString("dd/MM/yyyy"));
Console.WriteLine($"{today:dd/MM/yyyy}");

// créer une date précise
// DateTime startTraining = new DateTime(2024, 12, 9);
DateTime startTraining = DateTime.Parse("2024-12-09");
Console.WriteLine(startTraining);

Console.WriteLine(startTraining.Year);
Console.WriteLine(startTraining.DayOfWeek);

// calculer la différence entre 2 dates
DateTime birthday = new DateTime(1990, 9, 20);
Console.WriteLine((today - birthday).TotalDays);

Console.ReadKey();


#endregion
