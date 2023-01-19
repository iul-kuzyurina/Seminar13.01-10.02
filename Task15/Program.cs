Console.WriteLine("Введите число от 1 до 7: ");
int Daynumber = Convert.ToInt32(Console.ReadLine());

if (Daynumber>0 && Daynumber<8)
{
    if (Daynumber == 7 || Daynumber == 6)
{
    Console.WriteLine("этот день выходной");
}
else Console.WriteLine("не выходной");
}
