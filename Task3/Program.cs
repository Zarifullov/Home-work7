// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 0;
int n = 0;

Console.Write("Введите количество строк: ");
int.TryParse(Console.ReadLine(), out m);

Console.Write("Введите количество столбцов: ");
int.TryParse(Console.ReadLine(), out n);

int [,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       array [i, j] = new Random().Next(1,9);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);


for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
        result = result + array[i,j];
        } 
        result = result/n;
        Console.Write(result + "; ");
    }
Console.WriteLine();
