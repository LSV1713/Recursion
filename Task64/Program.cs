// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
//чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

void PrintNumbers(int start, int end)
{
    System.Console.Write(start + " ");

    if (start+2 <= end)
    {
        PrintNumbers(start+2,end);
    }
    else
    {
        return;
    }
}
Console.WriteLine("Введите число M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numN = Convert.ToInt32(Console.ReadLine());
if (numM % 2!=0)
{
    numM += 1;
}
PrintNumbers(numM,numN);