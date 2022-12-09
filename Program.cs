// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int Pow(int number, int pow)
{
    int result = number;
    for(int i = 1; i < pow; i++)
    {
        result = result * number;
    }
    return result;
}
Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter pow: ");
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number to the pow: {Pow(number, pow)}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int SumNumber(int number)
{
    int length = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        advance = number - number % 10;
        result = result + (number - advance);
        number = number / 10;
    }
    return result;
}
Console.Write("Enter number N: ");
int sumNumber = SumNumber(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"The sum of the digits in a number: {sumNumber}");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int[] CreateArray(int Lenght)
{
    int[] array = new int[Lenght];
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = InputNumber();
    }
    return array;
}
int InputNumber()
{
    Console.WriteLine("Enter number for array: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void GetArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("Enter the length of the array: ");
int[] array = CreateArray(Convert.ToInt32(Console.ReadLine()));
Console.Write($"Array: ");
GetArray(array);
*/