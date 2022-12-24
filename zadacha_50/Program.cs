// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//суть - задается значение элемента, нужно найти его индекс в массиве или вывести сообщение о его отсутствии



//1. задать массив
//2. спросить число
//3. проанализировать массив
//4. вывести ответ
Console.Clear();

void SearchPosition(int digit, int[,] array)
{
    int count = 0; // считаем позицию
    int rowsPosition = 0;  // сохраняем строку
    int columnsPosition = 0; // сохраняем столбец
    if (digit <= array.Length)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (count == digit - 1)
                {
                    rowsPosition = i;
                    columnsPosition = j;
                    System.Console.WriteLine($"На позиции {digit} находится число {array[rowsPosition, columnsPosition]}");
                    System.Console.WriteLine($"Индекс числа {array[rowsPosition, columnsPosition]} => [{rowsPosition},{columnsPosition}]");
                    count++;
                    break;
                }
                else
                {
                    count++;
                }
            }

        }
    }
    else
    {
        System.Console.WriteLine($" Не существует введенной позиции в массиве.\n Максимальная поцизия = {array.Length}");
    }
}


int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
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
}

int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//1. получить от пользователя м и н
int m = EnterNumber("введите значение m: ");
int n = EnterNumber("введите значение n: ");
//2. создаем двумерный массив и заполняем
int leftRange = 0;
int rightRange = 10;
//3. запрашваем позицию
int digit = EnterNumber("Введите номер позиции: ");
//4. поиск и вывод
int[,] matrix = CreateRandomArray(m, n, leftRange, rightRange);
ShowArray(matrix);
SearchPosition(digit, matrix);



// int m = 5; // количетсво строк в массиве
// int n = 5;  // количество столбцов в массиве
// int leftRange = 0;  // значение "от" целых чисел массива
// int rigthRange = 10;  // значение "до" целых чисел массива включительно
// int position = DataЕntry("Enter the item position => ");
// int[,] array = TwoDimArray(m, n, leftRange, rigthRange);   //создаем рандомный массив
// SearchPosition(position, array);  //решаем задачу с помощью этого метода












// int[,] TwoDimArray(int rows, int columns, int leftRange, int rigthRange)  // Метод для создания двумерного массива и заполнение его рандомными значениями
// {

//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(leftRange, rigthRange + 1);
//             array[0,0] = 2000;
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// int DataЕntry(string str)                                              // Метод - DataEntry - Ввод данных формата int

// {
//     Console.Write(str);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// void SearchPosition(int position, int[,] array)  // Метод поиска числа по позиции в массиве
// {
//     int count = 0; // счетчик для перещелкивания позиции
//     int rowsPosition = 0;  // для сохранения строки искомой позиции
//     int columnsPosition = 0; // для сохранения столбца искомой позиции
//     if (position <= array.Length)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (count == position-1)
//                 {
//                     rowsPosition = i;
//                     columnsPosition = j;
//                     System.Console.WriteLine($"На позиции {position} находится число {array[rowsPosition, columnsPosition]}");
//                     System.Console.WriteLine($"Индекс числа {array[rowsPosition, columnsPosition]} => [{rowsPosition},{columnsPosition}]");
//                     count++;
//                     break;
//                 }
//                 else
//                 {
//                     count++;
//                 }
//             }

//         }
//     }
//     else
//     {
//         System.Console.WriteLine($" Не существует введенной позиции в массиве.\n Максимальная поцизия = {array.Length}");
//     }
// }





