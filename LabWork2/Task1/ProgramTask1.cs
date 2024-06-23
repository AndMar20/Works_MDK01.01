//Task1
//Линейная сложность 
//Линейный поиск

int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Вывод массива
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}\t");
}
Console.WriteLine();

int value = 5; // Число которое ищем в массиве 
int position = -1;

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] == value)
    {
        position = i;
        break;
    }
}

Console.WriteLine($"Индекс элемента: {position}");