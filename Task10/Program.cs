Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 && number > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine($"число в середине - {InCenter(number)}");
}

return Convert.ToInt32(Console.ReadLine());

int InCenter(int number)
{
    int result = ((number / 10) % 10);
    return result;
}

