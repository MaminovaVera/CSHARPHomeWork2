//Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int second = 10 * ( number / 100 )  + ( number % 10 ); 
Console.WriteLine(second);
