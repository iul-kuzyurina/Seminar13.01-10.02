Console.WriteLine("Введите число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1>number2 && number1>number3)
{
    Console.WriteLine($"число {number1} является максимальным" );
}

else if (number2>number3)
{
    Console.WriteLine($"число {number2} является максимальным" );
}

else
{
    Console.WriteLine($"число {number3} является максимальным" );
}