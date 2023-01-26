int [] nums=new int[8];
Random r=new Random();
nums[0]=r.Next(9);

for (int i=1; i<nums.Length;i++)
{
    nums[i] = r.Next(9);
    int a = nums[i];
}

void PrintArray(int[] arr)
{    
    Console.WriteLine(" {0} -> [ {0} ]", string.Join(", ", arr));
}

PrintArray(nums);
