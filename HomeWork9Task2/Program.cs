// Задача 2: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int ReadInt(string message) // функция чтения целого числа
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNaturalNumbers(int number1, int number2) // функция по нахождению суммы натуральных чисел в заданном диапазоне
{
    if (number1 > number2 || number1 <=0 || number2 <= 0)
    {
        return 0;
    }
    return number1 + SumNaturalNumbers(number1+1, number2);
}

int numberM = ReadInt("Введите первое число > ");
int numberN = ReadInt("Введите второе число > ");

System.Console.WriteLine(SumNaturalNumbers(numberM, numberN));

