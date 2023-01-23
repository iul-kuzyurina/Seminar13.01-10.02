Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Некорректный ввод");
else Table(number);

void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}   {count*count*count}");
        count++;
    }
}
