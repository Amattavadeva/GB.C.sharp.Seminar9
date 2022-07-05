/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N. 
Не стоит использовать в рекурсиях глобальные переменные, лучше передавать их в методе*/
System.Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите cтепень");
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
        return n;
}

Rec(number1, number2);