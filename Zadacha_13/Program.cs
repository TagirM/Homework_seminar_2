/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите любое число: ");
string inputNumber = Console.ReadLine(); 

if (inputNumber.Length >= 3) Console.WriteLine("Третья цифра введенного числа " + inputNumber[2]);
else Console.Write("В числе " + inputNumber + " нет третьей цифры");
