//Task3

int[] numbers = { 7, 0, -4, 3, 1, -2, 5 };

for (int t = 0; t < numbers.Length; t++)
{
    Console.Write($"{numbers[t]}\t");
}
Console.WriteLine(); ;

for (int i = 1; i < numbers.Length; i++)
{
    int j =  i - 1;
    while (j >= 0 && numbers[j] > numbers[j+1])
    {
        int temp = numbers[j];
        numbers[j] = numbers[j+1];
        numbers[j+1] = temp;
        j--;    
    }
    
  
    for (int t = 0; t < numbers.Length; t++)
    {
        Console.Write($"{numbers[t]}\t");
    }
    Console.WriteLine();
}