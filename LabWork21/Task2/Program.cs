double outerRadius = 2;
double innerRadius = 5;
double s = Math.PI * (outerRadius - innerRadius) * (outerRadius + innerRadius);
if (s < 0)
    s = -s;
Console.WriteLine($"Площадь кольца = {s}");


int n = 100;
int sum = n * (n + 1) / 2;
Console.WriteLine($"Сумма чисел от 1 до {n} = {sum}");