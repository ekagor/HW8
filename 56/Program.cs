// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int [,] array = new int [rows,columns];
GetArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
FindRowSmallestSumElements(array);

void GetArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array [i,j] = new Random().Next(1,10);
        }   
    }
}

void PrintArray (int [,] arrray){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FindRowSmallestSumElements(int[,] array){
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++){
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            sumRow += array[i, j];
        }
        if (sumRow < minRow){
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {minSumRow + 1} строка");
}