Console.Write($"Jak masz na imię? ");
string imie = Console.ReadLine()!;

Thread.Sleep(1000); // Dodanie opóźnienia 1 sekundy

Console.WriteLine($"Zanim zaczniemy zobacz swoje statystyki, {imie}!");

char SymbolGracza = '&'; // Symbol gracza na mapie
int Poziom = 7; // Poziom gracza
int EXP = 0;   // Doświadczenie gracza
int Złoto = 187; // Ilość złota gracza
int NumerTreningu = 1; // Numer treningu gracza
double Waga = 4; // Waga plecaka gracza
bool Mapa = true; // Czy gracz posiada mapę

Thread.Sleep(1000); // Dodanie opóźnienia 1 sekundy

Console.WriteLine($"====STATYSTYKI GRACZA====");
Console.WriteLine($"Imię: {imie}");
Console.WriteLine($"Symbol gracza: {SymbolGracza}");
Console.WriteLine($"Poziom: {Poziom}");
Console.WriteLine($"EXP: {EXP}");
Console.WriteLine($"Złoto: {Złoto}");
Console.WriteLine($"Waga plecaka: {Waga}");
Console.WriteLine($"Mapa: {Mapa}");
Console.WriteLine($"Numer treningu: {NumerTreningu}");
Console.WriteLine("Czas na trening! Wykonaj 3 rundy treningu, aby zwiększyć swoje statystyki.");

Thread.Sleep(1000); // Dodanie opóźnienia 1 sekundy

EXP += 25; // Dodanie doświadczenia do gracza
EXP *= 2; // Podwojenie doświadczenia gracza
Złoto -= 8; // Odjęcie złota od gracza za wejście na arenę treningową
Złoto += 15; // Dodanie złota do gracza po wygranej w treningu
NumerTreningu += 1; // Zwiększenie numeru treningu gracza

Console.WriteLine($"====AKTUALIZACJA STATYSTYK GRACZA====");
Console.WriteLine($"Imię: {imie}");
Console.WriteLine($"Symbol gracza: {SymbolGracza}");
Console.WriteLine($"Poziom: {Poziom}");
Console.WriteLine($"EXP: {EXP}");
Console.WriteLine($"Złoto: {Złoto}");
Console.WriteLine($"Waga plecaka: {Waga}");
Console.WriteLine($"Mapa: {Mapa}");
Console.WriteLine($"Numer treningu: {NumerTreningu}");