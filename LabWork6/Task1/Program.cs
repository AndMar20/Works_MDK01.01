using Task1;

#region Task1
Pet pet1 = new();
Console.WriteLine($"Кличка: {pet1.Name} \nПорода: {pet1.Breed} \nВозраст: {pet1.Age}\n");

Pet pet2 = new("Васька", "Капибара", 18);
pet2.Print();
#endregion

#region Task2
Console.WriteLine($"Кличка pet1: {pet1["Кличка"]}"); //Неизвестно
Console.WriteLine($"Порода pet2: {pet2["Порода"]}"); //Капибара
Console.WriteLine($"Некоректоное значение pet2:{pet2["ПАРОДА"]}"); //null
Console.WriteLine($"Символ имени pet2 с индексом 5: {pet2[5]}"); //а
Console.WriteLine($"Символ имени pet2 с индексом 10: {pet2[10]}"); //null

#endregion

Console.WriteLine();

#region Task3
double result = Functions.GetSquare(2);
Console.WriteLine($"Площадь квадрата: {result} ");

result = Functions.GetSquare(2, 6.5);
Console.WriteLine($"Площадь прямоугольника: {result}");
#endregion 

Console.WriteLine();

#region Task4
result = Functions.GetRational(5);
Console.WriteLine($"Ответ: {result} ");

result = Functions.GetRational(2, 3);
Console.WriteLine($"Ответ: {result}");
#endregion
