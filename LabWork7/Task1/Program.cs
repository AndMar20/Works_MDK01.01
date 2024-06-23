using System.ComponentModel.Design;
using Task1;

Pet pet1= new("Васька", "Капибара", 18);
Pet pet2 = new("Петя", "Кот", 20);
Pet pet4 = new("Петя", "Кот", 20);
Pet pet5 = new("Жора", "Собака", -10);

#region Task1
Console.WriteLine("----------------Task 1----------------");

pet1.Print();

pet1++;
pet1.Print();
#endregion

#region Task2
Console.WriteLine("----------------Task 2----------------");

Console.WriteLine("pet1");
pet1.Print();
Console.WriteLine("pet2");
pet2.Print();

Pet pet3 = pet1 + pet2;
Console.WriteLine("pet3");
pet3.Print();
#endregion

#region Task3
Console.WriteLine("----------------Task 3----------------");

Console.WriteLine("pet1");
pet1.Print();
Console.WriteLine("pet2");
pet2.Print();
Console.WriteLine("pet4");
pet4.Print();

if (pet1 == pet2)
    Console.WriteLine("pet1 и pet2 одинаковые");
else
    Console.WriteLine("pet1 и pet2 разные");

if (pet2 == pet4)
    Console.WriteLine("pet2 и pet4 одинаковые");
else
    Console.WriteLine("pet2 и pet4 разные");
#endregion

#region Task4
Console.WriteLine("----------------Task 4----------------");

Console.WriteLine("pet1");
pet1.Print();
Console.WriteLine("pet5");
pet5.Print();

if (pet1)
    Console.WriteLine("Возраст pet1 >= 0 ");
else
    Console.WriteLine("Возраст pet1 < 0 ");

if (pet5)
    Console.WriteLine("Возраст pet5 >= 0 ");
else
    Console.WriteLine("Возраст pet5 < 0");
#endregion