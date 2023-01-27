//Console.WriteLine(" ");
//double a =2;
//double b=3;
//double c=Math.Pow(a,b);
//Console.WriteLine($"{c}");
Console.WriteLine("Введите первое число: ");
long a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
long b = Convert.ToInt32(Console.ReadLine());

 void naturalNumber(long b)
{
    if (b >= 1 )
    Console.WriteLine($"результат возведения числа a в натуральную степень b = {IntPow(a,b)}");
    
    else Console.WriteLine("число не натуральное");
}

static long IntPow(long a, long b)
{
  long result = 1;
  for (long i = 0; i < b; i++)
    result *= a;
  return result;
}
naturalNumber(b);
