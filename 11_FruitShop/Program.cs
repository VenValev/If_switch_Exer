string fruit = Console.ReadLine();
string day = Console.ReadLine();
double br = double.Parse(Console.ReadLine());
switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        switch (fruit)
        {
            case "banana":
                Console.WriteLine($"{br * 2.5:f2}");
                break;
            case "apple":
                Console.WriteLine($"{br * 1.2:f2}");
                break;
            case "orange":
                Console.WriteLine($"{br * 0.85:f2}");
                break;
            case "grapefruit":
                Console.WriteLine($"{br * 1.45:f2}");
                break;
            case "kiwi":
                Console.WriteLine($"{br * 2.7:f2}");
                break;
            case "pineapple":
                Console.WriteLine($"{br * 5.50:f2}");
                break;
            case "grapes":
                Console.WriteLine($"{br * 3.85:f2}");
                break;
            default:
                Console.WriteLine("error");
                break;

        }
        break;
    case "Saturday":
    case "Sunday":
        switch (fruit)
        {
            case "banana":
                Console.WriteLine($"{br * 2.7:f2}");
                break;
            case "apple":
                Console.WriteLine($"{br * 1.25:f2}");
                break;
            case "orange":
                Console.WriteLine($"{br * 0.9:f2}");
                break;
            case "grapefruit":
                Console.WriteLine($"{br * 1.6:f2}");
                break;
            case "kiwi":
                Console.WriteLine($"{br * 3.00:f2}");
                break;
            case "pineapple":
                Console.WriteLine($"{br * 5.60:f2}");
                break;
            case "grapes":
                Console.WriteLine($"{br * 4.2:f2}");
                break;
            default:
                Console.WriteLine("error");
                break;

        }
        break;
    default:
        Console.WriteLine("error");
        break;


}