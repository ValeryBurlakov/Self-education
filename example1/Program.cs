// пишем программу для нахождения площади круга Pi*r^2
const double pi = 3.14;
double radius;
Console.Write("Введите радиус круга: ");
radius = Convert.ToDouble(Console.ReadLine());
Console.Write("Площадь круга равна: ");
Console.WriteLine(pi * (radius * radius));
