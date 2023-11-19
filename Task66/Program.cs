// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int GetSum (int start, int end)
{
    if (start > end)
    {
        return 0;
    }
    return start + GetSum(start+1,end);
}
Console.WriteLine("Введите число M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(GetSum(numM,numN));
