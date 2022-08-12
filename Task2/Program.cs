//Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.


int RemoveSecond(int number)
{
    int result = 10 * (number / 100 % 10) + (number % 10);
    return result;
}
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
Console.WriteLine(RemoveSecond(number));