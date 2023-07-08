// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string message) // функция чтения целого числа
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbersEven(int number1, int number2) // функция по нахождению четных натуральных чисел в заданном диапазоне
{
    if (number1 > number2 || number1 <=0 || number2 <= 0)
    {
        return;
    }
    if (number1 % 2 == 1)
    {
        number1 ++;
    }
    System.Console.WriteLine(number1);
    NaturalNumbersEven(number1 + 2, number2);
}

int numberM = ReadInt("Введите первое число > ");
int numberN = ReadInt("Введите второе число > ");

NaturalNumbersEven(numberM, numberN);









