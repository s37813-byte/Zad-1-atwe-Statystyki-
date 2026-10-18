Console.Write($"Jak masz na imię? ");
string imie = Console.ReadLine()!;
Console.WriteLine($"Zanim zaczniemy zobacz swoje statystyki, {imie}!");

char SymbolGracza = '&'; // Symbol gracza na mapie
int Poziom = 7; // Poziom gracza
int Złoto = 187; // Ilość złota gracza
double Waga = 4; // Waga plecaka gracza
bool Mapa = true; // Czy gracz posiada mapę

Console.WriteLine($"====STATYSTYKI GRACZA====");
Console.WriteLine($"Imię: {imie}");
Console.WriteLine($"Symbol gracza: {SymbolGracza}");
Console.WriteLine($"Poziom: {Poziom}");
Console.WriteLine($"Złoto: {Złoto}");
Console.WriteLine($"Waga plecaka: {Waga}");
Console.WriteLine($"Mapa: {Mapa}");

Poziom = 8; // Zwiększenie poziomu gracza
Złoto += 50; // Dodanie złota do gracza

Console.WriteLine($"====AKTUALIZACJA STATYSTYK GRACZA====");
Console.WriteLine($"Imię: {imie}");
Console.WriteLine($"Poziom: {Poziom}");
Console.WriteLine($"Złoto: {Złoto}");
Console.WriteLine($"Waga plecaka: {Waga}");
Console.WriteLine($"Mapa: {Mapa}");
