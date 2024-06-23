//Task1 

int[] numbers = { 7, 0, -4, 3, 1, -2, 5 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}\t");
}
Console.WriteLine();

for (int i = 0; i < numbers.Length - 1; i++)
{
    int min = i;
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[j] < numbers[min])
        {
            min = j;
        }
    }

    if (min != i)
    {
        int temp = numbers[i];
        numbers[i] = numbers[min];
        numbers[min] = temp;
    }

    for (int j = 0; j < numbers.Length; j++)
    {
        Console.Write($"{numbers[j]}\t");
    }
    Console.WriteLine( );
}

