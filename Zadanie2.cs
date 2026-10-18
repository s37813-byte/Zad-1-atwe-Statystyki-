Console.Write("Podaj ile racji przeznaczysz dla plepsu: ");
int Racje = int.Parse(Console.ReadLine()!);

Console.Write("Ilość plepsów w twojej dróżynie: ");
int Pleps = int.Parse(Console.ReadLine()!);

Console.Write("Podaj liczbę dni wyprawy: ");
int Dni = int.Parse(Console.ReadLine()!);

// Obliczenia
int RacjeNaOsobe = Racje / Pleps;
int PozostaleRacje = Racje % Pleps;

double RacjeDziennie = (double)Racje / Dni;
double RacjeNaOsobeDziennie = (double)Racje / Pleps / Dni;

// Raport
Console.WriteLine("\n==== PODZIAŁ ZAPASÓW ====");
Console.WriteLine($"Racje na osobę: {RacjeNaOsobe}");
Console.WriteLine($"Pozostałe racje: {PozostaleRacje}");
Console.WriteLine($"Racje dziennie dla drużyny: {RacjeDziennie:F2}");
Console.WriteLine($"Racje dziennie na osobę: {RacjeNaOsobeDziennie:F2}");