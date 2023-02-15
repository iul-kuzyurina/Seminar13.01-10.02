//Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма равна {SumNaturalNumbers(number1, number2)}");
Console.ReadLine();

int SumNaturalNumbers(int num1, int num2)
{
    if (num1 > num2) return num2 + SumNaturalNumbers(num1, num2+1);
    else if (num1 < num2) return num2 + SumNaturalNumbers(num1, num2-1);
    else return num1;
}