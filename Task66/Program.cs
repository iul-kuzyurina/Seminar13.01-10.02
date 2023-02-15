//Задайте значения M и number2. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до number2. Выполнить с помощью рекурсии.
//M = 1; number2 = 15 -> 120
//M = 4; number2 = 8. -> 30

Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма равна {SumNaturalNumbers(number1, number2)}");
Console.ReadLine();

//SumNaturalNumbers(number1, number2);

static int SumNaturalNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    else if (num1 > num2) return num2 + SumNaturalNumbers(num1, num2++);
    else if (num1 < num2) return num2 + SumNaturalNumbers(num1, num2--);
}

    /*
    else (num1 < num2)
    {
        //num2+SumNaturalNumbers(num1, num2-1, 0);
        sum = sum + (num2--);
        Console.Write($"Сумма равно: {sum}");
        return;
    }*/
    
    //sum = sum + (num1++);
    //SumNaturalNumbers(num1, num2, sum);


//Console.Write($"{sum}");
