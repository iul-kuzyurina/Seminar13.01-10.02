//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа number2 и number1.

Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int Akkerman(int number1, int number2)
{
  if (number1 == 0)
    return number2 + 1;
  else
    if ((number1 != 0) && (number2 == 0))
      return Akkerman(number1 - 1, 1);
    else
      return Akkerman(number1 - 1, Akkerman(number1, number2 - 1));
}

    Console.Write($"итог вычисления {Akkerman(number1, number2)}"); 

