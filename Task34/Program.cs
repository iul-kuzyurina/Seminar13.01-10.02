//int[] GreatArrayRnd(int size, int min, int max)
//{
    //int[] arr = new int[size];
    //Random rnd = new Random();
    //for (int i = 0; i < arr.Length; i++)
   // {
       //arr[i] = rnd.Next(min, max + 1);
   // }
   // return arr;
//}

//void PrintArray(int[] array)
//{
    //Console.WriteLine("[");
    //for (int i = 0; i < array.Length; i++)
    //{
        //if (i < array.Length - 1) Console.WriteLine($"{array[i]}, ");
        //else Console.WriteLine($"{array[i]}");
    //}
//}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

