using Task1;

Pet[] pets =
{
    new Pet("Петя", "Кот", 18),
    new Pet("Барсик", "Собака", 5),
    new Pet("Иван", "Собака", 1),
    new Pet("Коля", "Кот", 13),
    new Pet("Жора", "Кот", 10)
};

Console.WriteLine("Массив до сортировки\n");
foreach (Pet pet in pets)
{
    pet.Print();
}

Console.WriteLine("===============Task1===============");
Array.Sort(pets);

Console.WriteLine("Массив после сортировки\n");
foreach (Pet pet in pets)
{
    pet.Print();
}



