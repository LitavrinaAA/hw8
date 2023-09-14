// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

//Например, задан массив:
// 1 4 7 2      14<--
// 5 9 2 3      19
// 8 4 2 4      18
// 5 2 6 7      20
// Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int MinSummNumInRow(int[,] arr){
    int length1 = arr.GetLength(0);
    int length2 = arr.GetLength(1);
    int sumRow = 0;
    int minSumRow =  int.MaxValue ;
    int indexminSumRow = 0;
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
          sumRow +=  arr[i,j]; 
        }
        if (minSumRow > sumRow){
            minSumRow = sumRow;
            indexminSumRow = i;
        }
        
        sumRow = 0;
    }
    
    return indexminSumRow + 1;
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
System.Console.WriteLine($"номер строки с наименьшей суммой элементов:  {MinSummNumInRow(arr)} строка");

