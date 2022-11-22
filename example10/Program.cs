//https://c-sharp.pro/a2-%d1%86%d0%b5%d0%bb%d0%be%d1%87%d0%b8%d1%81%d0%bb%d0%b5%d0%bd%d0%bd%d0%b0%d1%8f-%d0%b0%d1%80%d0%b8%d1%84%d0%bc%d0%b5%d1%82%d0%b8%d0%ba%d0%b0-%d0%b2%d1%8b%d0%b4%d0%b5%d0%bb%d0%b5%d0%bd%d0%b8%d0%b5/
//A2.3. Дано трехзначное число. Найти:
// а) число единиц в нем;
// б) число десятков в нем;
// в) сумму его цифр;
// г) произведение его цифр.

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number / 100;
Console.WriteLine(number2);
if (number2 > 0 && number2 < 10)
{
    Console.WriteLine($"Всё ок, ваше число: {number}");
    int desiyatki = (number / 10) % 10;
    Console.WriteLine($"число десятков: {desiyatki}");
    int edinizi = number % 10;
    Console.WriteLine($"число единиц: {edinizi}");
    int sum = number2 + desiyatki + edinizi;
    Console.WriteLine($"сумма цифр числа: {sum}");
    int proizved = number2 * desiyatki * edinizi;
    Console.WriteLine($"произведение цифр числа: {proizved}");
}
else
{
    Console.WriteLine("вы ввели не трёхзначное число");
}
