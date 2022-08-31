// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите позицию по вертикали: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию по горизонтали: ");
int columnPosition = Convert.ToInt32(Console.ReadLine());

int rows = 4;
int colums = 4;

if (rowPosition < rows -1 && rowPosition >= 0
   && columnPosition < colums - 1 && columnPosition >= 0)
{
    int[,] array = GetArray(rows,colums,-100,100);
    PrintArray(array);

    int[,] GetArray(int m, int n, int min, int max)
    {
        int[,] result = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(-100, 100);
            }
        }
        return result;
    }



    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
    }

    Console.WriteLine($"Число : {array[rowPosition, columnPosition]}");
}    

else Console.WriteLine(" Такого числа в массиве нет ");

// P.S Хотелось бы узнать как использовать Exception, самостоятельный поиск четкого понимания не дал.