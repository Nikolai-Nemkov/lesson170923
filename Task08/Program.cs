// Напишите программу, которая на вход принимает число (N) а на выходе 
// показывает все четные числа от до N
// Например: 5 -> 2, 4
//           8 -> 2, 4, 6, 8

using System;
class HelloWorld {
  static void Main() {
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    int evenNumber = 2;
    
    if(number > 1)
    {
        while(evenNumber <= number)
        {
            Console.Write(evenNumber + " ");
            evenNumber = evenNumber + 2;
        }
    }
  }
}
