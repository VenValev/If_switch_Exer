string product = Console.ReadLine();
string city = Console.ReadLine();
double num = double.Parse(Console.ReadLine());
if (city == "Sofia")
{
    switch (product)
    {
        case "coffee":
            Console.WriteLine(num * 0.5);
            break;
        case "water":
            Console.WriteLine(num * 0.8);
            break;
        case "beer":
            Console.WriteLine(num * 1.20);
            break;
        case "sweets":
            Console.WriteLine(num * 1.45);
            break;
        case "peanuts":
            Console.WriteLine(num * 1.6);
            break;
        default:
            break;
    }
}
if (city == "Plovdiv")
{
    switch (product)
    {
        case "coffee":
            Console.WriteLine(num * 0.4);
            break;
        case "water":
            Console.WriteLine(num * 0.7);
            break;
        case "beer":
            Console.WriteLine(num * 1.15);
            break;
        case "sweets":
            Console.WriteLine(num * 1.3);
            break;
        case "peanuts":
            Console.WriteLine(num * 1.5);
            break;
        default:
            break;
    }
}
if (city == "Varna")
{
    switch (product)
    {
        case "coffee":
            Console.WriteLine(num * 0.45);
            break;
        case "water":
            Console.WriteLine(num * 0.7);
            break;
        case "beer":
            Console.WriteLine(num * 1.10);
            break;
        case "sweets":
            Console.WriteLine(num * 1.35);
            break;
        case "peanuts":
            Console.WriteLine(num * 1.55);
            break;
        default:
            break;
    }
}