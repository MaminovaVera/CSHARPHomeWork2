﻿//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int userNum = Prompt("Введите число  от 1 до 7 > ");



