int a = int.Parse(Console.ReadLine());
if ((a < 100 || a > 200) && a != 0)
{
    Console.WriteLine("invalid");
}
//Console.WriteLine((a<100 || a>200) && a!=0 ? $"invalid" : $"" ); Същото като горното т.н. Тернарен оператор ternari