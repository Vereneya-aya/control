﻿// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = { "13", "no", "3", "hello", "war" };
int n = new Random().Next(0, 4);
string[] new_array = new string[n];
for (int i = 0; i < n; i++)
{
    new_array[i] = array[new Random().Next(0, array.Length)];
}
Console.WriteLine($"Новый массив: [ {string.Join("; ", new_array)} ]");
