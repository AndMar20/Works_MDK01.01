using Task3;

Console.WriteLine("===============Task3===============");

Pet pet1 = new("Коля", "Кот", 13);
Pet pet2 = new("Коля", "Кот", 13);
Pet pet3 = new("Вася", "Собака", 10);

if (pet1.Equals(pet2))
    Console.WriteLine("Равны");
else Console.WriteLine("Не равны");

if (pet1.Equals(pet3))
    Console.WriteLine("Равны");
else Console.WriteLine("Не равны"); 
