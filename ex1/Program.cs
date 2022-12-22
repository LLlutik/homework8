// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
//  каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
//Функция сортировки массива пузырьковым методом
int [,] SortArray(int [,] myArr)  
{   int n = myArr.GetLength(0);
    int m = myArr.GetLength(1);

    for (int i = 0; i < n; i++) 
    {
        for (int k = 0; k < m-1; k++)
        {
            for (int j = 0; j < m-1; j++) 
            {
                if(myArr[i,j] < myArr[i,j+1])
                {
                    int box = myArr[i,j];
                    myArr[i,j] = myArr[i, j+1];
                    myArr[i, j+1] = box;
                }
            } 
        }
    }
            
    return myArr;    
}


int n = 5; 
int m = 5; 
int [,] newArr = GetArray(n,m); 
Console.WriteLine("Исходный массив:");
PrintArray(newArr);
Console.WriteLine("Отсортированный массив:");
int [,] sortArr = SortArray(newArr); 
PrintArray(sortArr);