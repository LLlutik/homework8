// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] GetArray(int rows, int columns)  
{ 
    Random rnd = new Random(); 
    int [,] myArray = new int [rows,columns]; 
    for (int i = 0; i < myArray.GetLength(0); i++) 
        for (int j = 0; j < myArray.GetLength(1); j++) 
            myArray[i,j] = rnd.Next(0, 5); 
    return myArray;    
} 

void PrintArray (int [,] myArr) 
{ 
    for (int i = 0; i < myArr.GetLength(0); i++) 
    { 
        for (int j = 0; j < myArr.GetLength(1); j++) 
            Console.Write($"{myArr[i,j]}\t"); 
    Console.WriteLine();     
    }  
} 

int [,] MultiplyArrays(int [,] firstArray, int [,] secondArray)
{
    int n = firstArray.GetLength(0);
    int m = secondArray.GetLength(1);
    int q = firstArray.GetLength(1);
    int [,] myArray = new int [n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            myArray[i, j] = 0;
            for (int k = 0; k < q; k++)
            {
                myArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    


    return myArray;
}



int n = 2; 
int m = 3; 
int [,] firstArray = GetArray(n,m); 
int [,] secondArray = GetArray(m,n); 
Console.WriteLine("Первый массив:");
PrintArray(firstArray);
Console.WriteLine("Второй массив:");
PrintArray(secondArray);
Console.WriteLine("Произведение:");
int [,] newArray = MultiplyArrays(firstArray, secondArray);
PrintArray(newArray);
