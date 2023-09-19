// Напишите программу, которая принимает на вход число и выдает, является ли оно четным
// (делится ли оно на 2 без остатка)


using System;
class HelloWorld {
  static void Main() {
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    int remDiv = number % 2;
    
    if(remDiv == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
  }
}