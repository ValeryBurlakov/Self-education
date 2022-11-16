// пишем программу для нахождения площади круга Pi*r^2
const double pi = 3.14;
double number;
Console.Write("Введите число: ");
number = Convert.ToDouble(Console.ReadLine());
Console.Write("Диаметр круга равен: ");
Console.WriteLine(number * number); // радиус = 2r
Console.Write("Площадь круга равна: ");
Console.WriteLine(pi * (number * number)); // Pi*r^2
Console.Write("Длина окружности: ");
Console.WriteLine(2 * pi * number); // длина окружности 2 * Pi * r(number, радиус)
Console.Write("Периметр квадрата равен: ");
Console.WriteLine(number * 4); // сторона * 4
Console.Write("объем куба: ");
Console.WriteLine(number * number * number); // объем куба V = abc, abc длины ребер
Console.Write("площадь боковой поверхности куба: ");
Console.WriteLine(number * number);

