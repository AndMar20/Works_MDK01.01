Console.WriteLine("=================Task3=================");

var contacts = new Dictionary<string, string>
{
    { "88005553535", "Игорь"},
    { "89115456723", "Кирилл"},
    { "89118707141", "Иван"},
    { "80000000000", "Игорь"},
    { "81234567890", "Илья"},
    { "80987654321", "Денис"}
};

Console.WriteLine("Список контактов");
foreach (var contact in contacts)
    Console.WriteLine($"{contact.Key} - {contact.Value}");
Console.WriteLine($"Количество контактов: {contacts.Count}");
Console.WriteLine();

Console.Write("Ключ поиска: ");
string searchKey = Console.ReadLine();

if (contacts.ContainsKey(searchKey))
    Console.WriteLine($"\nКонтакт найден. \n{searchKey} - {contacts[searchKey]}");
else Console.WriteLine($"Контакт по ключу {searchKey} не найден.");
Console.WriteLine();

Console.Write("Имя для поиска совпадений: ");
string searchName = Console.ReadLine();

int replay = 0;
foreach (var contact in contacts)
{
    if (contact.Value == searchName)
        replay++;
}
Console.WriteLine($"Количество контактов с именем {searchName}: {replay}\n");

Console.Write("Ключ удаления: ");
searchKey = Console.ReadLine();

if (contacts.ContainsKey(searchKey))
{
    contacts.Remove(searchKey);
    Console.WriteLine($"Контакт удалён.");
}
else Console.WriteLine($"Контакт по ключу {searchKey} не найден.");
Console.WriteLine();

Console.WriteLine("Список контактов");
foreach (var contact in contacts)
    Console.WriteLine($"{contact.Key} - {contact.Value}");
Console.WriteLine($"Количество контактов: {contacts.Count}");
Console.WriteLine();

