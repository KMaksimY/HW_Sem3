// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// int number  = ReadLine();

// for int count 

using System;

class Program {
    static void Main() {
        Console.Write("Введите пятизначное число: ");
        string number = Console.ReadLine();
        
        // Проверка на длину числа
        if (number.Length != 5) {
            Console.WriteLine("Вы ввели число неправильной длины!");
        }
        else {
            // Проверка на палиндром
            char[] reversedNumber = number.ToCharArray();
            Array.Reverse(reversedNumber);
            string reversedString = new string(reversedNumber);
            
            if (number == reversedString) {
                Console.WriteLine("Число является палиндромом!");
            }
            else {
                Console.WriteLine("Число не является палиндромом!");
            }
        }
    }
}