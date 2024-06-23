using Task1;


//Task1
Pet pet1 = new();
Console.WriteLine($"Кличка: {pet1.Name} \nПорода: {pet1.Breed} \nВозраст: {pet1.Age}\n");

Pet pet2 = new("Васька", "Капибара", 18);
pet2.Print();

//Task 4
Pet[] pets = new Pet[5];
{
    pets[0] = new Pet("Петя", "Кот", 18);
    pets[1] = new Pet("Коля", "Кот", 13);
    pets[2] = new Pet("Жора", "Собака", 10);
    pets[3] = new Pet("Барсик", "Собака", 5);
    pets[4] = new Pet("Иван", "Собака", 1);
}

string searchBreed = "Кот";
Console.WriteLine($"------------Поиск по кличке {searchBreed} ------------ \n\n");

foreach (Pet pet in pets)
{
    if (pet.Breed == searchBreed)
    {
        pet.Print();
    }
}

string searchName = "Иван";
Console.WriteLine($"------------Поиск по кличке {searchName} ------------ \n") ;

foreach (Pet pet in pets)
{
    if (pet.Name == searchName)
    {
        pet.Print();
    }
}