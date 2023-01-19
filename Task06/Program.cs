Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"число {number} является четным");
}
else
{
    Console.WriteLine($"число {number} является нечетным");
}