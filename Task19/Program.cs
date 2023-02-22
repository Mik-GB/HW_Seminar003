// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string number  = Console.ReadLine();
// if (number < 10000 || number > 99999)
// {
//    Console.WriteLine("Введено неверное число");
// }
    if ((number[0] == number [4]) && (number[1] == number[3]))
    {
       Console.WriteLine("Палиндром!");
    }
    else Console.WriteLine("Не палиндром!");