Console.Write("Podaj ilość punktów życia: ");
int HP = int.Parse(Console.ReadLine()!);

Console.Write("Czy Masz Klucz do skarbu? (true/false): ");
bool MaKlucz = bool.Parse(Console.ReadLine()!);

Console.Write("Czy Znasz sekretne Hasło? (true/false): ");
bool ZnaHaslo = bool.Parse(Console.ReadLine()!);

if (HP > 0 && MaKlucz && ZnaHaslo)
{
    Console.WriteLine("Gracz jest gotowy do wyprawy.");
}
else
{
    Console.WriteLine("Gracz nie jest gotowy do wyprawy.");
}
