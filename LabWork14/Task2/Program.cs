using System.Text.RegularExpressions;

string input = "Написать         регулярное выражение,      заменяющее в исходной строке два и более подряд    идущих     пробельных символа на пробел.";
string pattern = @" {2,}";
string replacement = " ";

Regex regex = new(pattern);
string result  = regex.Replace(input, replacement);
Console.WriteLine(result);