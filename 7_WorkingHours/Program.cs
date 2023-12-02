int a = int.Parse(Console.ReadLine());
string b = Console.ReadLine();
if (b == "Sunday")
{
    Console.WriteLine("closed");
}
else if (a > 9 && a < 19)
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}