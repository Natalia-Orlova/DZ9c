// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int FindSumNaturalNum(int num1, int num2)
{
    if (num1 > num2)
        return num1 + FindSumNaturalNum(num1 - 1, num2);
    else if (num1 < num2)
        return num1 + FindSumNaturalNum(num1 + 1, num2);
    else return num1;
}
int sum = FindSumNaturalNum(number1, number2);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {number1} до {number2} равна {sum}");
