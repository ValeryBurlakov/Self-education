// A1.9. С начала 2020 года по некоторый день прошло n месяцев и 2 дня. 
// Присвоить целочисленной величине x значение 1, 2, …, 11 или 12 
// в зависимости от того, каким месяцем (январем, февралем и т.п.) 
// является месяц этого дня. Например, при n=3 значение х равно 4.
// https://c-sharp.pro/%d1%86%d0%b5%d0%bb%d0%be%d1%87%d0%b8%d1%81%d0%bb%d0%b5%d0%bd%d0%bd%d0%b0%d1%8f-%d0%b0%d1%80%d0%b8%d1%84%d0%bc%d0%b5%d1%82%d0%b8%d0%ba%d0%b0-%d0%bf%d1%80%d0%be%d1%81%d1%82%d0%b5%d0%b9%d1%88%d0%b8/

Console.WriteLine("Сколько прошло месяцев с января 2020?(+ 2 дня): ");
int n = Convert.ToInt32(Console.ReadLine());
int n2 = n + 1;
int january = 1;
int month = (january + n2) % 12;
switch(month)
{
    case 1:
    Console.WriteLine("Январь");
    break;
    case 2:
    Console.WriteLine("февраль");
    break;
    case 3:
    Console.WriteLine("март");
    break;
    case 4:
    Console.WriteLine("апрель");
    break;
    case 5:
    Console.WriteLine("май");
    break;
    case 6:
    Console.WriteLine("июнь");
    break;
    case 7:
    Console.WriteLine("июль");
    break;
    case 8:
    Console.WriteLine("август");
    break;
    case 9:
    Console.WriteLine("сентябрь");
    break;
    case 10:
    Console.WriteLine("октябрь");
    break;
    case 11:
    Console.WriteLine("ноябрь");
    break;
    case 12:
    Console.WriteLine("декабрь");
    break;
}