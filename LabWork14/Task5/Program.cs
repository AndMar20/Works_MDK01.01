using System.Text.RegularExpressions;

string text = "Пример даты: 25.12.2021, еще одна дата: 01/01/22";
string input = "";
string pattern = @"(?P<day>\d{1,2})[./](?P<month>\d{1,2})[./](?P<year>\d{2,4})";

string replacement = "$<year>-$<month>-$<day>";
Regex regex = new(pattern);
string result = regex.Replace(input, replacement);
Console.WriteLine(result);