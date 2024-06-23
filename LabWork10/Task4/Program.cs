using Task4;

Console.WriteLine("===============Task4===============");

Pet pet1 = new("Коля", "Кот", 13);
Pet pet2 = (Pet)pet1.Clone();

pet1.Print();
pet2.Print();
