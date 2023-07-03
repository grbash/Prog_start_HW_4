// Допущение для всех задач: Пользователь вводит адекватные значение 
// (если в условии задачи написано "возводит число A в натуральную степень B", то мы допускаем, 
// что число B на вход мы получим натуральное, а вот А может быть любое, иначе придется использовать слишком много проверок)

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Task 27:");
Console.WriteLine();

int Summation(int num)
{
    int res = num % 10;

    while ((num / 10) > 0)
    {
        num /= 10;
        res += num % 10;
    }

    return res;
}

Console.Write("Input nummber: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = Summation(num);

Console.WriteLine($"Sum of digits of {num} = {result}");