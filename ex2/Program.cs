// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] GetArray(int rows, int columns)  
{ 
    Random rnd = new Random(); 
    int [,] myArray = new int [rows,columns]; 
    for (int i = 0; i < myArray.GetLength(0); i++) 
        for (int j = 0; j < myArray.GetLength(1); j++) 
            myArray[i,j] = rnd.Next(0, 100); 
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

int GetRowOfMinSum(int [,] myArr)  
{   
    int n = myArr.GetLength(0);
    int m = myArr.GetLength(1);
    
    //берем начальное значение минимальной суммы
    int minSum = 0;
    int minIndex = 0;
    for (int j = 0; j < m; j++)
    {
        minSum += myArr[0,j];
    }
    Console.WriteLine($"Строка {1}, сумма элементов {minSum}");

    // бежим по циклу
    for (int i = 1; i < n; i++) 
    {   
        int sum = 0;
        for (int j = 0; j < m; j++) 
        {
            sum += myArr[i,j];
        } 
        System.Console.WriteLine($"Строка {i+1}, сумма элементов {sum}");
        if(sum < minSum)
        {
            minSum = sum;
            minIndex = i;
        }
    }
            
    return minIndex+1; //вернуть человеческую строку   
}


int n = 5; 
int m = 5; 
int [,] newArr = GetArray(n,m); 
Console.WriteLine("Исходный массив:");
PrintArray(newArr);
int rowOfMinSum = GetRowOfMinSum(newArr);
System.Console.WriteLine($"Строка с минимальной суммой: {rowOfMinSum}");