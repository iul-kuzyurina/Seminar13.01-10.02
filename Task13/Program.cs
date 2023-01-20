Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
Console.WriteLine("Третьей цифры нет");
}

int ThirdDigit = Separate(number);
Console.WriteLine($"Третья цифра - {ThirdDigit}");

int Separate(int number)
{if (number >= 100)

    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}





