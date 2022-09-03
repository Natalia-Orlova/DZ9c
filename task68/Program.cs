// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите целое положительное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int m1, int n1)
{
    if (m1 == 0) return n1 +1;
    if (m1 > 0 && n1 == 0) return AckermanFunction(m1-1, 1);
    if (m1 > 0 && n1 > 0) return AckermanFunction(m1-1, AckermanFunction(m1, n1-1));
    return AckermanFunction(m1, n1);
}

if ((m > 2 && n > 10) || (m > 3 && n > 0)) 
Console.WriteLine($"При m = {m} и n = {n} невозможно рассчитать функцию");
else Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {AckermanFunction(m,n)}");
