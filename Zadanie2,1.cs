Console.Write("Podaj swój wiek: ");
int wiek = int.Parse(Console.ReadLine()!);

switch (wiek)
{
    case < 12:
        Console.WriteLine("Jestś dzieckiem.");
        break;
    case >= 13 and <= 17:
        Console.WriteLine("Jestś nastolatkiem.");
        break;
    case >= 18 and <= 64:
        Console.WriteLine("Jestś dorosłym.");
        break;
    case >= 65:
        Console.WriteLine("Jestś seniorem.");
        break;
    default:
        Console.WriteLine("Nieprawidłowy wiek.");
        break;
}