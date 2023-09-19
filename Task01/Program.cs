/* Напишите программу, которая на вход принимает два числа
и проверяет, является ли первое число квадратом второго.

а = 25, b = 5 -> да
a = 2,  b = 10 -> нет
a = 9,  b = -3 -> да
a = -3, b = 9 -> нет  */

int firstNumber, secondNumber

Console.Writeline("Введите первое число:");
firstNumber = Convert.ToInt32(Console.Readline());
Consoie.Writeline("Введите второе число:");
secondNumber = Convert.ToInt32(Console.Readline());

if (firstNumber == secondNumber*secondNumber)
{
    Console.Writeline($"первое число = {firstNamber}, второе число = {secondNumber} -> Да");
}
else 
{
    Console.Writeline($"первое число - {firstNumber}, второе число = {secondNumber} -> Нет");
}

.