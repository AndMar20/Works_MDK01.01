int row, column, x, y;

do
{
    Console.WriteLine("Введите количество строк массива (от 2):");
    row = Convert.ToInt32(Console.ReadLine());
    if (row < 2)
        Console.WriteLine("Введите корректное значение количества строк массива(от 2)!");
} while (row < 2);

do
{
    Console.WriteLine("Введите количество столбцов массива (от 2):");
    column = Convert.ToInt32(Console.ReadLine());
    if (column < 2)
        Console.WriteLine("Введите корректное значение количества столбцов массива(от 2)!");
} while (column < 2);

Random random = new Random();
int[,] map = new int[row, column];
int finishX = 0;
int finishY = 0;
int lengthOfWay = 0;
int[,] heuristicDestination = new int[row, column];
for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        map[i, j] = -1;
    }
}

do
{
    Console.WriteLine("Введите x-координату ячейки");
    x = Convert.ToInt32(Console.ReadLine());
    if (x > row - 1 || x < 0)
        Console.WriteLine("Координата выходит за пределы массива, введите корректное значение!");
} while (x > row - 1 || x < 0);

do
{
    Console.WriteLine("Введите y-координату ячейки");
    y = Convert.ToInt32(Console.ReadLine());
    if (y > column - 1 || y < 0)
        Console.WriteLine("Координата выходит за пределы массива, введите корректное значение!");
} while (y > column - 1 || y < 0);

map[x, y] = 0;

for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        if (random.Next(10) < 2)
        {
            map[i, j] = -2;
        }
    }
}

do
{
    finishX = random.Next(row);
    finishY = random.Next(column);
}
while (finishX == x && finishY == y);

map[finishX, finishY] = 99;

Console.WriteLine("\nМассив:");
for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        Console.Write($"{map[i, j]}\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        heuristicDestination[i, j] = Math.Abs(i - finishX) + Math.Abs(j - finishY);
    }
}

Console.WriteLine("\nМассив со значениями эвристик:");
for (int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        Console.Write($"{heuristicDestination[i, j]}\t");
    }
    Console.WriteLine();
}

do
{
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            if (map[i, j] == lengthOfWay)
            {
                if (i + 1 <= row - 1)
                {
                    if (map[i + 1, j] != -2)
                        map[i + 1, j] = lengthOfWay + 1;
                }
                if (i - 1 >= 0)
                {
                    if (map[i - 1, j] != -2)
                        map[i - 1, j] = lengthOfWay + 1;
                }
                if (j + 1 <= column - 1)
                {
                    if (map[i, j + 1] != -2)
                        map[i, j + 1] = lengthOfWay + 1;
                }
                if (j - 1 >= 0)
                {
                    if (map[i, j - 1] != -2)
                        map[i, j - 1] = lengthOfWay + 1;
                }
            }
        }
    }
    lengthOfWay = lengthOfWay + 1;

}
while (map[finishX, finishY] != lengthOfWay);

Console.WriteLine($"\nДлина пути с учетом препятствий: {lengthOfWay}");