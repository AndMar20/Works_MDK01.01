using Task5;

Pet[] pets =
{
    new Pet("Петя", "Кот", 18),
    new Pet("Барсик", "Собака", 5),
    new Pet("Вячеслав", "Собака", 1),
    new Pet("Игорь", "Кот", 13),
    new Pet("Гас", "Кот", 10)
};

Console.WriteLine("Массив до сортировки\n");
foreach (Pet pet in pets)
{
    pet.Print();
}


Console.WriteLine("===============Task5===============");

Array.Sort(pets, new DescendingComparer());
Console.WriteLine("Массив после сортировки по убыванию возраста\n");
foreach (Pet pet in pets)
{
    pet.Print();
}

Array.Sort(pets, new Task5.StringComparer());
Console.WriteLine("Массив после сортировки по возрастанию имени\n");
foreach (Pet pet in pets)
{
    pet.Print();
}
