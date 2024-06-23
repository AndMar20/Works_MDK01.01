Console.WriteLine("=================Task1=================");

List<string> seas = new List<string>()
{
    new string("Каспийское"),
    new string("Баренцево"),
    new string("Белое")
};

Console.WriteLine("Cписок морей");
for (int i = 0; i < seas.Count; i++)
    Console.WriteLine($"{i + 1} - {seas[i]}");
Console.WriteLine();

Console.Write("Количество добавляемых морей: ");
int seasCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < seasCount; i++)
{
    Console.Write($"Море {seasCount + i+1}: ");
    seas.Add(Console.ReadLine());
}
Console.WriteLine();

Console.WriteLine("Cписок морей");
for (int i = 0; i < seas.Count; i++)
    Console.WriteLine($"{i + 1} - {seas[i]}");
Console.WriteLine();



