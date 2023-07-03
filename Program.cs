﻿// Допущение для всех задач: Пользователь вводит адекватные значение 
// (если в условии задачи написано "возводит число A в натуральную степень B", то мы допускаем, 
// что число B на вход мы получим натуральное, а вот А может быть любое, иначе придется использовать слишком много проверок)

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Task 25:");
Console.WriteLine();

double Exponention(double num, int exp)
{
    double res = num;
    for (int i = 0; i < (exp - 1); i++) res *= num;
    
    return res;
}

Console.Write("Input numA: ");
double numA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input numB: ");
int numB = Convert.ToInt32(Console.ReadLine());

double result = Exponention(numA, numB);

Console.WriteLine($"numA ^ numB = {result}");