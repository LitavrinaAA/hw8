// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int InputNum(string mess)
{
    System.Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()!);
}



void FillArr(int[,] arr, int m, int n)
{
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(10);
        }
    }
}


void SortToLower(int[,] arr)
{
    int lengthCol = arr.GetLength(0);
    int lengthRow = arr.GetLength(1);
    for (int i = 0; i < lengthCol; i++)
    {
        for (int j = 0; j < lengthRow; j++)
        {
            for (int k = 0; k < lengthRow - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int max = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = max;
                }
            }
        }
        
    }
}


void PrintArr(int[,] arr)
{
    int length1 = arr.GetLength(0);
    int length2 = arr.GetLength(1);
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }

}


int m = InputNum("Введите m: ");
int n = InputNum("Введите n: "); 

int[,] arr = new int[m, n];
FillArr(arr, m, n);
PrintArr(arr);

Console.WriteLine("---");
SortToLower(arr);
PrintArr(arr);
