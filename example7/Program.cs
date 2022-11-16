﻿// A1.8. Дано целое число k (1 ≤ k ≤ 365). Присвоить целочисленной 
// величине n значение 1, 2, …, 6 или 0 в зависимости от того, 
// на какой день недели (понедельник, вторник, …, субботу или воскресенье) 
// приходится k-й день года, в котором 1 января:
// а) понедельник;
// б) вторник;
// в) d-й день недели (если 1 января — понедельник, то d=1, 
// если вторник — d=2, …, если воскресенье — d=7).
// A1.9. С начала 2020 года по некоторый день прошло n месяцев и 2 дня. 
// Присвоить целочисленной величине x значение 1, 2, …, 11 или 12 
// в зависимости от того, каким месяцем (январем, февралем и т.п.) 
// является месяц этого дня. Например, при n=3 значение х равно 4.
Console.WriteLine("Введите любой день в году от 1 до 365:");
int k = Convert.ToInt32(Console.ReadLine());
if (k >= 1 && k <= 365)
{
    Console.WriteLine("укажите день недели, на который выпало 1 января: ");
    int dayear = Convert.ToInt32(Console.ReadLine());;
    if(dayear <=7 && dayear >=1)
    {
        Console.WriteLine("молодец, ввел правильный день недели");
    }
    else
    {
        Console.WriteLine("В неделе дни идут от 1 до 7, перезапускай программу мудень");
    }
}
else
{
    Console.WriteLine("вы ввели неправильно, перезапустите программу");
}