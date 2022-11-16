// с начала суток прошло n секунд, определить:
// сколько часов прошло
// сколько минут прошло
// сколько прошло секунд с начала очередной минуты
Console.Write("Введите сколько секунд прошло с начала суток: ");
int second = Convert.ToInt32(Console.ReadLine());
int minute = second/60;
int hour = minute/60;
double second2 = second % 60;
Console.WriteLine($"прошло часов: {hour}, прошло минут: {minute}, секунд с очередной минуты: {second2}");

