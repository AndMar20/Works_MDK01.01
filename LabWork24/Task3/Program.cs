internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(GetDaysCount(1, 2024));
        Console.WriteLine(GetDaysCount(2, 2000));
        Console.WriteLine(GetDaysCount(2, 2001));
        Console.WriteLine(GetDaysCount(12, 2005));

    }

    private static int GetDaysCount(int month, int year)
    {
        if (month < 1 || month > 12 || year < 0)
            throw new ArgumentException("Данные указаны неверно");

        int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        bool isLeapYear = year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
        if ( month == 2 && isLeapYear)
            return daysInMonths[month - 1]+1;
        return daysInMonths[month - 1];
    }
}