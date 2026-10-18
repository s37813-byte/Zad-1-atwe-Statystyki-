Console.Write("Wybierz kierunek Wyprawy (Wschód, Zachód, Północ, Południe): ");
string kierunek = Console.ReadLine()!;

switch (kierunek.ToLower())
{
    case "wschód":
        Console.WriteLine("Wyruszasz na wschód!");
        break;
    case "zachód":
        Console.WriteLine("Wyruszasz na zachód!");
        break;
    case "północ":
        Console.WriteLine("Wyruszasz na północ!");
        break;
    case "południe":
        Console.WriteLine("Wyruszasz na południe!");
        break;
    default:
        Console.WriteLine("Nieznany kierunek. Wybierz Wschód, Zachód, Północ lub Południe.");
        break;
}
