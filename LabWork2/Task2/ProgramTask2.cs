//Task2
//Логорифмическая сложность
//Двоичный поиск 

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int value = 1; // Число которое ищем в массиве 
int position = -1;
int left = 0;
int right = numbers.Length - 1;

//Вывод массива
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}\t");
}
Console.WriteLine();

while (left <= right)
{
    int middle = left + (right - left) / 2;

    if (numbers[middle] == value)
    {
        position = middle;
        break;
    }

    if (numbers[middle] < value)
    {
        left = middle + 1;
    }
    else
    {
        right = middle - 1;
    }
}

Console.WriteLine($"Позиция элемента: {position}");