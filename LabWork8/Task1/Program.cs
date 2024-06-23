using Task1;

Pet pet1 = new("Вадим", "Попугай", 3);
Pet pet2 = new("Кузя", "Медведь", 14);
Pet pet3 = new("Кузя", "Медведь", 14);

#region Task1
Console.WriteLine("===============Task1===============");

Console.WriteLine($"Питомец1 \n{pet1.ToString()}");
Console.WriteLine($"Питомец1 \n{pet1}");
#endregion

#region Task2
Console.WriteLine("===============Task2===============");

Console.WriteLine($"Питомец1 \n{pet1}");
Console.WriteLine($"Питомец2 \n{pet2}");
Console.WriteLine($"Питомец3 \n{pet3}");

Console.WriteLine($"pet1 и pet2 \nОбъекты одинаковые: {pet1.Equals(pet2)}");
Console.WriteLine($"pet2 и pet3 \nОбъекты одинаковые: {pet2.Equals(pet3)}");
#endregion

#region Task3
Console.WriteLine("===============Task3===============");
Rectangle rectangle1 = new(2, 3.5);

rectangle1.PrintInfo();
Console.WriteLine();

Console.WriteLine($"Площадь: {rectangle1.GetSquare()}");
Console.WriteLine($"Периметр: {rectangle1.GetPerimeter()}");

#endregion

#region Task4
Console.WriteLine("===============Task4===============");

ExtendedRandom random = new();
string randomString = random.GetRandomScaredText(15);
Console.WriteLine(randomString);
#endregion
