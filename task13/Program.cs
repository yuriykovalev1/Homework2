﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ReadInt(string msg)// Объявляем функцию и строковый параметр msg
{
    System.Console.WriteLine(msg);                          // Выводит на экран msg
    string numb = Console.ReadLine();                       // Функция считывания строки с консоли
    int namber;                                             // Объявление переменной
    namber = int.Parse(numb);                               // Как результат преобразования строки в число
    return namber;                                          // Возврат из функции
}                                                           // описание функии заканчивается
int namber = ReadInt("Введите число = ");                   // Вызываем функию Рединт, результат складываем во вновь объявленную переменную намбер

if (namber>99)                                              // Условие больше 3х цифр
{   int i = namber;                                         // присваивание переменной
    string str = i.ToString();                              // Перевод в строку
    System.Console.WriteLine("Третье число = " + str[2]);   // Берем третий индекс элемента
}
else System.Console.WriteLine("Третьей цифры нет");         // Условие если меньше трех символов