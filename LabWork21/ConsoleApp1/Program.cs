int mounth = 2;
int year = 2000;
int GetDaysCount(int month, int year)
{
    if (month < 1 || month > 12 || year < 0)
        throw new ArgumentException("Данные указаны неверно");

    int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    bool isLeapYear = year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
    if (month == 2 && isLeapYear)
        return daysInMonths[month - 1] + 1;
    return daysInMonths[month - 1];
}
Console.WriteLine($"Количество дней {mounth}.{year} : {GetDaysCount(mounth, year)}") ;