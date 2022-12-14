// Задайте двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

int m = 3;
int n = 4;
int[,] array = new int[m, n];
FillArray(array);
MinSumRows(array);
System.Console.WriteLine(MinSumRows(array));
void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int  MinSumRows(int[,] array)
{
    int minIndex = 0;
    int sumRow = 0;
    int minSumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        sumRow = 0; 
        for (int j = 0; j < array.GetLength(1); j++)
        {
             sumRow += array[i, j];
        }
            if (i == 0)
            minSumRow = sumRow;
            else
            {
                if(minSumRow > sumRow)
                {
                    sumRow = minSumRow;
                    minIndex = i;
                    
                }    
            }
    }
    return minIndex;
}

