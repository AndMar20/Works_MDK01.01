using System.Text.RegularExpressions;

string input = "zxc_GOGO-2007@gmail.asu.com";
string pattern = @"^[a-zA-Z0-9_\-]+@([a-z0-9]+\.)+[a-zA-Z]+$";

Regex regex = new(pattern);
if (regex.IsMatch(input))
    Console.WriteLine("Почта корректная");
else
    Console.WriteLine("Почта не корректная");

input = "Криперdcdc@gmail12.f";
if (regex.IsMatch(input))
    Console.WriteLine("Почта корректная");
else
    Console.WriteLine("Почта не корректная");