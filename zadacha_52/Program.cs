// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//1. задать массив
//2. вывести массив
//3. посчитать среднее арифметическое
//4. вывести результат

Console.Clear();

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{(array[i, j])} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);

        }
    }
    return array;
}

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//0. получить от пользователя м и н
int m = EnterNumber("введите значение m: ");
int n = EnterNumber("введите значение n: ");
int leftRange = 0;
int rightRange = 10;

//1. создаем двумерный массив и заполняем

int[,] matrix = CreateRandomArray(m, n, leftRange, rightRange);

//2. вывести двумерный массив
ShowArray(matrix);

//3. посчитать среднее, вывести результат

///вариант без метода

// double srednee = 0;
// double sum;
// for (int j = 0; j < matrix.GetLength(0); j++)
// {
//     sum = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         sum += matrix[i, j];                //равносильно sum = sum + matrix[i,j]
//         srednee = sum / matrix.GetLength(1);
//     }
//     //Console.WriteLine(srednee);
//     Console.Write($" Среднее в столбце {j}:  {Math.Round(srednee, 1)} ");
// }


//варинат с методом
double[] ArithmeticMean(int[,] array)
{
    double[] arrayArifmetic = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++) // цикл для столбцов
    {
        for (int i = 0; i < array.GetLength(0); i++)  //цикл для строк
        {
            arrayArifmetic[j] += array[i, j];
        }
        arrayArifmetic[j] /= (double)array.GetLength(0);
        arrayArifmetic[j] = Math.Round(arrayArifmetic[j],1); 
    }
    return arrayArifmetic;
}

double[] meanValues = ArithmeticMean(matrix); // массив, в котоырй будем складывать полученные Средние арифметические столбцов

System.Console.WriteLine($"Среднее арифметическое каждого столбца {'[' + string.Join("; ", meanValues) + ']'}"); // выводим в терминал массив со средними арифметическими стоблцов
