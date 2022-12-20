// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 2)} ");
        }
        Console.WriteLine();
    }
}

double[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[,] array = new double[rows, columns];
        for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange) + new Random().NextDouble();

        }
    }
    return array;
}

int EnterNumber(string message)                   //мы передаем текст...какая то переменная какого то типа, которая может принять строку
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//1. получить от пользователя м и н
int m = EnterNumber("введите значение m: ");
int n = EnterNumber("введите значение n: ");

//2. создаем двумерный массив и заполняем

double[,] matrix = CreateRandomArray(m, n, 1, 10);                //так создается двумерный массив обратить внимание на [,]

//3. вывести массив
ShowArray(matrix);