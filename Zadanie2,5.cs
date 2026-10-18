
Console.Write("Podaj ilość punktów życia: ");
int HP = int.Parse(Console.ReadLine()!);

Console.Write("Podaj liczbę mikstur życia: ");
int Mikstury = int.Parse(Console.ReadLine()!);

Console.Write("Masz te klucz? (true/false): ");
bool MaKlucz = bool.Parse(Console.ReadLine()!);

Console.Write("Czy masz mapę? (true/false): ");
bool MaMape = bool.Parse(Console.ReadLine()!);

Thread.Sleep(1000); // Dodanie opóźnienia 1 sekundy

bool zyje = HP > 0;
bool MaPełneZdrowie = HP == 100;
bool PotrzebujeLeczenia = !MaPełneZdrowie;
bool MaZaopatrzenie = Mikstury >= 1;
bool MaKluczDoSkarbu = MaKlucz;
bool MaMapeDoSkarbu = MaMape;
bool CzyGraczJestGotowyDoWyprawy = zyje && MaZaopatrzenie && (MaKluczDoSkarbu || MaMapeDoSkarbu);

 
Console.WriteLine("\n==== STATYSTYKI NA WYPRAWĘ ====");
Console.WriteLine($"Żyje: {zyje}");
Console.WriteLine($"Pełne zdrowie: {MaPełneZdrowie}");
Console.WriteLine($"Potrzebuje leczenia: {PotrzebujeLeczenia}");
Console.WriteLine($"Zaopatrzenie: {MaZaopatrzenie}");
Console.WriteLine($"Klucz do skarbu: {MaKluczDoSkarbu}");
Console.WriteLine($"Mapa do skarbu: {MaMapeDoSkarbu}");
Console.WriteLine($"Czy gracz jest gotowy do wyprawy: {CzyGraczJestGotowyDoWyprawy}");