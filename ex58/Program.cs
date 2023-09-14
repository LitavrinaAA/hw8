// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputNum(string mess)
{
    System.Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()!);
}



void FillArr(int[,] arr, int m, int n){
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(10);
        }
    }
}
void PrintArr(int[,] arr, string msg)
{
    System.Console.WriteLine(msg);

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
    System.Console.WriteLine();
}
int[,] arrMult(int[,] arr1, int[,]arr2){
    //  2 4 | 3 4
    //  3 2 | 3 3

    //  2 · 3 + 4 · 3 = 6 + 12  = 18 
    //  2 · 4 + 4 · 3 = 8 + 12  = 20

    //  3 · 3 + 2 · 3 = 9 + 6  = 15
    //  3 · 4 + 2 · 3 = 12 + 6 = 18
   
    int[,] result = new int[arr1.GetLength(0), arr1.GetLength(1)];

    

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
           for (int k = 0; k < arr1.GetLength(1); k++)
        result[i,j] += arr1[i,k] * arr2[k,j];
        }
    }
    return result;
}
int m = InputNum("Введите m: ");
int n = InputNum("Введите n: "); 

int[,] arr1 = new int[m, n];
int[,] arr2 = new int[m, n];
int[,] result = new int[m,n];

FillArr(arr1, m, n);
FillArr(arr2, m, n);
result = arrMult(arr1, arr2);

PrintArr(arr1, "Первая матрица: ");
PrintArr(arr2, "Вторая матрица: ");
PrintArr(result, "Произведение двух матриц: ");