Console.WriteLine("Введите строку из случайных символов");
string text = Console.ReadLine();
char[] stopSymbols = { '?', '!', '.' };
string[] sentencies = text.Split(stopSymbols);