using System.Text.RegularExpressions;

string input = "+7(900)555-35-35";
string pattern = @"(8|\+7)\(9\d{2}\)\d{3}(-\d{2}){2}";

Regex regex = new(pattern);
if (regex.IsMatch(input))
    Console.WriteLine("Номер корректный");
else
    Console.WriteLine("Номер некорректный");

input = "8(dcd)DH5-35-3в";
if (regex.IsMatch(input))
    Console.WriteLine("Номер корректный");
else
    Console.WriteLine("Номер некорректный");


