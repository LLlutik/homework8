// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] GetArray(int n, int m)
{
    int[,] myArray = new int[n, m];
    
    int s = 1;//чем будем заполнять
    int k=0;

    while (s <= n * m)
    {
        for (int j = k; j < m - k; j++)
        {
            int i = k;
            myArray[i, j] = s;
            s++;
        }
        if(s > n*m) break;
        for (int i = 1 + k; i < n - k; i++)
        {
            int j = (m - 1) - k;
            myArray[i, j] = s;
            s++;
        }
        for (int j = (m - 2) - k; j >= 0 + k; j--)
        {
            int i = (n - 1) - k;
            myArray[i, j] = s;
            s++;
        }
        for (int i = (n - 2) - k; i > 0 + k; i--)
        {
            int j = k;
            myArray[i, j] = s;
            s++;
        }
        k++;
    }
    return myArray;
}

void PrintArray(int[,] myArr)
{
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
            Console.Write($"{myArr[i, j]}\t");
        Console.WriteLine();
    }
}

int n = 11;
int m = 6;
int[,] newArray = GetArray(n, m);
PrintArray(newArray);