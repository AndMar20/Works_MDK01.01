Console.WriteLine("=================Task2=================");

var contacts = new Dictionary<string, string>
{
    { "88005553535", "Игорь"},
    { "89115456723", "Кирилл" },
    { "89118707141", "Иван" }
};

Console.WriteLine("Список контактов");
foreach (var contact in contacts)
    Console.WriteLine($"{contact.Key} - {contact.Value}");
Console.WriteLine($"Количество контактов: {contacts.Count}");
Console.WriteLine();

Console.Write("Количество добавляемых контактов: ");
int contactsCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < contactsCount; i++)
{
    Console.WriteLine($"Новый контакт ");
    Console.Write("Имя: ");
    string contactName = Console.ReadLine();
    Console.Write("Номер: ");
    string contactNumber = Console.ReadLine();

    contacts.Add(contactNumber, contactName);
}
Console.WriteLine();

Console.WriteLine("Список контактов");
foreach (var contact in contacts)
    Console.WriteLine($"{contact.Key} - {contact.Value}");
Console.WriteLine($"Количество контактов: {contacts.Count}");

