Console.WriteLine("Введите число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1>number2)
{
    Console.WriteLine($"Число {number1} является наибольшим,а число {number2} наименьшее");
}
else 
{
    Console.WriteLine($"Число {number2} является наибольшим,а число {number1} наименьшим");
}  
