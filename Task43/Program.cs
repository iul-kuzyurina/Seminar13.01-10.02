Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = (k1*(b2-b1))/(k1-k2)+b1;

Console.WriteLine($"Точка пересечения двух прямых - {x}, {y}");

void Proverka(double b1, double k1, double b2, double k2)
{
    if ((k1 == k2) && (b1 == b2))

Console.WriteLine("Прямые совпадают.");

    else if (k1==k2)  Console.WriteLine("Прямые параллельны.");

}
Proverka(b1, k1, b2, k2);