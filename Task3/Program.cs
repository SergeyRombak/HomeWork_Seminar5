// Задача 3
/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.*/

Console.Clear();

//Создаем и заполняем двумерный массив
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
                matr[i,j] = new Random().Next(10,101);
            }
    }
}

// Вывод строки с минимальной суммой элементов???
void StringMinSum(int[] sum)
{
    for (int i = 0; i < sum.GetLength(0); i++)
            {int pos = 0;
             int min = sum[0];
             for (i =1; i < sum.Length; i++)
                {   
                    if(sum[i] < min)
                    {
                    min = sum[i];
                    pos = i;
                    }
                }
                if(pos == 1)
                {
                    Console.WriteLine($"\nНаменьшая сумма элементов, равная {min}, находится во {pos+1}й строке");
                }
                else
                {
                    Console.WriteLine($"\nНаменьшая сумма элементов, равная {min}, находится во {pos+1}й строке");
                }
            }
}


int[,] matrix = new int[8, 9];
FillArray(matrix);
Console.WriteLine("Исходный массив: ");
PrintArray(matrix);
StringMinSum(matrix); 
Console.WriteLine("Строка с наименьшей суммой элементов: ");
