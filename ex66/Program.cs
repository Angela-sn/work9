// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine() ?? "");

Console.WriteLine("введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine() ?? "");

int result = SumElements(N, M);
Console.Write(result);

int SumElements(int num1, int num2)
{
    if (num1 == num2) return num1;
    else if (num1 < num2) return num2 + SumElements(num1, num2 - 1);
    else return num2 + SumElements(num1, num2 + 1);
}
    
