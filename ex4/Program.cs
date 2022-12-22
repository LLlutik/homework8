// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] GetArray(int rows, int columns, int depth)  
{ 
    Random rnd = new Random(); 
    int [,,] myArray = new int [rows,columns, depth]; 
    for (int i = 0; i < myArray.GetLength(0); i++) 
        for (int j = 0; j < myArray.GetLength(1); j++) 
            for (int k = 0; k < myArray.GetLength(2); k++)
                myArray[i,j,k] = rnd.Next(0, 100); 
    return myArray;    
} 

void PrintArray (int [,,] myArr) 
{ 
    for (int i = 0; i < myArr.GetLength(0); i++) 
    { 
        for (int j = 0; j < myArr.GetLength(1); j++) 
        {
            for (int k = 0; k < myArr.GetLength(2); k++)
                Console.Write($"{myArr[i,j,k]}({i},{j},{k})\t"); 
            Console.WriteLine();     
        }
    }  
}
 
int [,,] threeDimentionArray = GetArray(2, 2, 2); 
PrintArray(threeDimentionArray);