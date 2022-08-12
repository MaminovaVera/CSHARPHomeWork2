//Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.


void RemoveSecond(int number)
{
    int result = 10 * (number / 100) + (number % 10);
    Console.WriteLine(result);
}
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
RemoveSecond(number);