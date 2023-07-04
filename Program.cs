// Допущение для всех задач: Пользователь вводит адекватные значение 
// (если в условии задачи написано "возводит число A в натуральную степень B", то мы допускаем, 
// что число B на вход мы получим натуральное, а вот А может быть любое, иначе придется использовать слишком много проверок)

// Задача 29: Напишите программу, которая задаёт массив из произвольного количества элементов и выводит их на экран.

Console.WriteLine("Task 29:");
Console.WriteLine();

void ArrayMaker(int arrayLenght)
{
    int[] arr = new int[arrayLenght];
    for (int i = 0; i < arrayLenght; i++) arr[i] = new Random().Next(-arrayLenght, arrayLenght + 1);
    Console.Write("[");
    for (int i = 0; i < arrayLenght; i++)
    {
        if (i == 0) Console.Write(arr[i]);
        else Console.Write($", {arr[i]}");
    }
    Console.WriteLine("]");
}

Console.Write("Enter the number of array elements: ");
int arrayLenght = Convert.ToInt32(Console.ReadLine());

ArrayMaker(arrayLenght);