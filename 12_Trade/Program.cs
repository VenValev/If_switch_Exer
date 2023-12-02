string grad = Console.ReadLine();
double pr = double.Parse(Console.ReadLine());
switch (grad)
{
    case "Sofia":
        if (pr > 10000)
        {
            Console.WriteLine($"{pr * 0.12:f2}");
        }
        else if (pr > 1000)
        {
            Console.WriteLine($"{pr * 0.08:f2}");
        }
        else if (pr > 500)
        {
            Console.WriteLine($"{pr * 0.07:f2}");
        }
        else if (pr >= 0)
        {
            Console.WriteLine($"{pr * 0.05:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
        break;
    case "Varna":
        if (pr > 10000)
        {
            Console.WriteLine($"{pr * 0.13:f2}");
        }
        else if (pr > 1000)
        {
            Console.WriteLine($"{pr * 0.10:f2}");
        }
        else if (pr > 500)
        {
            Console.WriteLine($"{pr * 0.075:f2}");
        }
        else if (pr >= 0)
        {
            Console.WriteLine($"{pr * 0.045:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
        break;
    case "Plovdiv":
        if (pr > 10000)
        {
            Console.WriteLine($"{pr * 0.145:f2}");
        }
        else if (pr > 1000)
        {
            Console.WriteLine($"{pr * 0.12:f2}");
        }
        else if (pr > 500)
        {
            Console.WriteLine($"{pr * 0.08:f2}");
        }
        else if (pr >= 0)
        {
            Console.WriteLine($"{pr * 0.055:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
        break;
    default:
        Console.WriteLine("error");
        break;
}