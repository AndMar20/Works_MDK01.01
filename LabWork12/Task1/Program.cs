using Task1;

Pet pet1 = new("Васька", "Кот", 4);
pet1.Print();

//Pet pet2 = new("", "кличка", 3);

//Task4
Pet[] pets = new Pet[5];
{
    pets[0] = new Pet("Петя", "Кот", 18);
    pets[1] = new Pet("Коля", "Кот", 13);
    pets[2] = new Pet("Жора", "Собака", 10);
    pets[3] = new Pet("Барсик", "Собака", 5);
    pets[4] = new Pet("Иван", "Птица", 1);
}
pets[0].animalType = AnimalType.Cat;
pets[1].animalType = AnimalType.Cat;
pets[2].animalType = AnimalType.Cat;
pets[3].animalType = AnimalType.Dog;
pets[4].animalType = AnimalType.Bird;

foreach (Pet pet in pets)
{
    if (pet.animalType == AnimalType.Bird)
    {
        pet.Print();
    }
}

//Task5
Console.WriteLine("\n-------------------------------Task5-------------------------------");
var orderer1 = new Orderer("Петр Васильевич Кукушкин","ул. Пушкина",5000.1);
var orderer2 = new Orderer("Иван Иванович Иванов","ул. Мира",1000.99);
var orderer3 = new Orderer("Иван Иванович Иванов","ул. Мира",1000.99);

Console.WriteLine(orderer1);
Console.WriteLine(orderer2);
Console.WriteLine(orderer3);

Console.WriteLine(orderer1.Equals(orderer2)); //false
Console.WriteLine(orderer1 != orderer2); //true
Console.WriteLine(orderer2 == orderer3); // true


