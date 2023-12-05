// Задача 2
/* Задайте двумерный массивю Напишите программу, которая 
поменяет местами первую и последнюю строку*/

Console.Clear();

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

// Меняем строчки местами
void ChangeArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(i > 0 && i < matr.GetLength(1))
            {
                int temporary = matr[i, j];
                matr[i, j] = matr[i, j];
                matr[i, j] = temporary;
            }
            else
            {
                int temporary = matr[i, j];
                matr[i, j] = matr[(matr.GetLength(1)-1), j];
                matr[(matr.GetLength(1)-1), j] = temporary;
            }
        } 
    }
    Console.WriteLine();
}

int[,] matrix = new int[4, 4];
 
Console.WriteLine("Исходный массив: ");
FillArray(matrix);
PrintArray(matrix);
Console.Write();
Console.WriteLine("Измененный массив: ");
ChangeArray(matrix);
PrintArray(matrix);