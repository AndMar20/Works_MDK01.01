Console.WriteLine("=================Task4=================");

List<string> seas = new List<string>()
{
    new string("Каспийское"),
    new string("Баренцево"),
    new string("Белое"),
    new string("Черное"),
    new string("Красное ")
};

Console.WriteLine("Cписок морей");
for (int i = 0; i < seas.Count; i++)
    Console.WriteLine($"{i + 1} - {seas[i]}");
Console.WriteLine();


seas.Insert(0, seas[seas.Count - 1]);
seas.RemoveAt(seas.Count - 1);

Console.WriteLine("Cписок морей");
for (int j = 0; j < seas.Count; j++)
    Console.WriteLine($"{j + 1} - {seas[j]}");
Console.WriteLine();

