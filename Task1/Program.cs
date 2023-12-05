// Задача 1
/* Напишите программу, которая на вход принимает позиции элемента в двумерном
массиве, и возвращает значение этого элемента или же указывает,
что такого элемента нет.*/

Console.Clear();
// Делаем запрос на ввод позиции элемента двумерного массива
Console.WriteLine("Введите позицию элемента в двумерном массиве: ");
Console.Write("Строка: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Столбец: ");
int m = int.Parse(Console.ReadLine()!);

// Создаем и заполняем двумерный массив
void PrintArray(int[,] matr) 
 {
    for (int i = 0; i < matr.GetLength(0); i++)
    {
            for (int j = 0; j < matr.GetLength(1); j++) 
            {
                Console.Write($"{matr[i, j]} ");
            }
    Console.WriteLine();
    }
 }

void FillArray(int[,] matr) 
 {
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
            for (int j = 0; j < matr.GetLength(1); j++) 
            {
                matr[i,j] = new Random().Next(1,10);
            }
    }
 }
int[,] matrix = new int[3, 4]; 
// PrintArray(matrix); // выводит массив с 0, решил что это лишнее!!!
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// Проверяем, существует ли элемент с такими позициями
int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);
if(n >= 0 && n < rows && m >= 0 && m < cols)
{
    int element = matrix[m, n];
    Console.WriteLine("Значение элемента: " + element);
}
else
{
    Console.WriteLine("Элемент не существует");
}