/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8" */

/* System.Console.WriteLine("Введите 1 число");
int number1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите 2 число");
int number2 = int.Parse(Console.ReadLine());

int Rec(int m, int n)
{
    if (m < n)
    {
        Console.Write(m + " ");
        return Rec((m + 1), n);
    }
    else if (m > n)
    {
        Console.Write(m + " ");
        return Rec((m - 1), n);
    }
    else
        Console.Write(n);
    return (n);
}

Rec(number1, number2); */

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30 */

/* System.Console.WriteLine("Введите 1 число");
int number1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите 2 число");
int number2 = int.Parse(Console.ReadLine());

int sum(int n, int m) 
{
  return n == m? m : n + sum(n + 1, m);
}
Console.Write(sum(number1, number2)); */

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 29 */

System.Console.WriteLine("Введите 1 число");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите 2 число");
int num2 = int.Parse(Console.ReadLine());


int recursion(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return recursion(m - 1, 1);
    }
    else
    {
        return recursion(m - 1, recursion(m, n - 1));
    }
}

Console.Write($"Результат вычислений: {recursion(num1, num2)}");