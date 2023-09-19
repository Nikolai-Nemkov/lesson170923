/* Напишите программу, которая будет выдавать название
дня недели по заданному номеру
3 -> Среда
5 -> Пятница */

string dayNumber;
Console.EriteLine("Введите номер дня недели");

if (dayNumber == "1")
{
    Consoie.Writeline($"{dayNumber} -> Понедельник");
}
else if (dayNumber == "2")
{
    Consoie.Writeline($"{dayNumber} -> Вторник");
}
else if (dayNumber == "3")
{
    Consoie.Writeline($"{dayNumber} -> Среда");
}
else if (dayNumber == "4")
{
    Consoie.Writeline($"{dayNumber} -> Четверг");
}
else if (dayNumber == "5")
{
    Consoie.Writeline($"{dayNumber} -> Пятница");
}
else if (dayNumber == "6")
{
    Consoie.Writeline($"{dayNumber} -> Суббота");
}
else if (dayNumber == "7")
{
    Consoie.Writeline($"{dayNumber} -> Воскресенье");
}
else
{
    Consoie.Writeline("Дня недели с таким номером нет");
}