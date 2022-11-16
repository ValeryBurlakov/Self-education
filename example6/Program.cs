// дан прямоугольник с определенныи размерами, 
// сколько квадратов со стороной 13 влезет в прямоугольник
Console.WriteLine("Введите певую сторону прямоугольника:");
int side = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону прямоугольника:");
int side2 = Convert.ToInt32(Console.ReadLine());
int square = side * side2;// сравниваем площади фигур
int squarearea = 13 * 13;
Console.WriteLine($"Площадь прямоугольника равна: {square}, площадь квадрата: {squarearea}");
int result = square/squarearea;
Console.WriteLine($"Сколько квадратов поместиться в треугольнике: {result}");
