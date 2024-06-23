//Task3
//Сложность O(sqrt(n))
//Алгоритм поиска прыжками

int[] numbers = { 0, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 700 };//Элементы массива 16шт
int n = numbers.Length-1; //Длина массива
int value = 55; //Число которое ищем в массиве

//Вывод массива
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}\t");
}
Console.WriteLine();

int previousStep = 0;
for (int jumpStep = (int)Math.Sqrt(n); numbers[jumpStep] < value; jumpStep += (int)Math.Sqrt(n))
{
    previousStep = jumpStep;
}

while (numbers[previousStep] < value)
{
    previousStep++;
}
Console.WriteLine($"Индекс элемента: {previousStep}");