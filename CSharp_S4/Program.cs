int[] array = { 12, 2, 6, 11, 18, 45, 32, 9, 14, 64, 76, 33, 16, 5 };

int target = 185;



for (int i = 0; i < array.Length; i++)
{
    var h = new HashSet<int>();

    for (int j = i + 1; j < array.Length; j++)
    {
        if (h.Contains(target - array[i] - array[j]))
        {
            Console.WriteLine($"{array[i]} + {target - array[i] - array[j]} +  {array[j]} = {target - array[i] - array[j] + array[i] + array[j]}");
        }
        else
        {
            h.Add(array[j]);
        }
    }
}
