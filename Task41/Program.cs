Console.Write("Введите элементы(через пробел): ");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine("Массив:");
PrintArray(numbers);

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");