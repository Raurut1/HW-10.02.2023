Console.WriteLine("Ведите число");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 1)
{
    Console.WriteLine("Число " + a + " Нечётное");
}
else
{
    Console.WriteLine("Число " + a + " Чётное");
}