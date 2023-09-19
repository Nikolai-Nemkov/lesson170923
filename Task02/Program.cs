//  Напишите программу, которая на в ход принимает два числа и выдает
//  какое число болшее, а какое меньшее.
//  a = 5;  b = 7;  max = 7
//  a = 2;  b = 10; max = 10
//  a = -9; b = -3; max = -3


using System;
class HelloWorld {
  static void Main() {
    int max = 0;
    int min = 0;
    
    Console.Write("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    
    if(firstNumber > secondNumber)
    {
        max = firstNumber;
        min = secondNumber;
    }
    else
    {
        max = secondNumber;
        min = firstNumber;
    }
    Console.WriteLine("max = " + max + " и " + "min = " + min);
  }
}
