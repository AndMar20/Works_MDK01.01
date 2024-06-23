//Task2

int[] numbers = { 7, 0, -4, 3, 1, -2, 5 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}\t");
}
Console.WriteLine();

for (int i = numbers.Length - 1; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        if (numbers[j] > numbers[j + 1])
        {
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }

    for (int j = 0; j < numbers.Length; j++)
    {
        Console.Write($"{numbers[j]}\t");
    }
    Console.WriteLine();
}
