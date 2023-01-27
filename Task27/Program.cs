Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int SumDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        int value = num % 10;
        sum += value;
        num /= 10;
    }
    return sum;
}

int summa = SumDigits(number);
Console.WriteLine("Сумма цифр в числе: " + summa);