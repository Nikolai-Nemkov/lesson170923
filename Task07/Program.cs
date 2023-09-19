//   Напишите программу, которая принимает на вход 
//   трехзначное число и на выходе показывает
//   последнюю цифру этого числа.
//   456 -> 6
//   782 -> 2
//   918 -> 8

Console.WriteLine("enter int number:");
int number = Convert.ToInt32(Console.ReadLine());

if(number <0)
{
    number *= -1;
}

if(number >=100 && number <=999)
{
    int lastnumber = number % 10;
    Console.WriteLine($"{number} -> {lastnumber}");
}
else
{
    
     Console.WriteLine("try again error");
    
}
