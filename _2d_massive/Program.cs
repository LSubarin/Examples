// Двумерные массивы. 
// тип данных запятая говорит о 2х мерности имя        строки,столбцы
//      int         [,]                    matrix = new int[5,8];


// string[,] table = new string[2, 5]; // Строковый массив из 2 строк и 5 столбцов
// String.Empty - инициализация пустой строки

// Вид массива:
// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]

// table[1, 2] = "слово"; // Элемент массива второй строки, третьего столбца
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++) 
//     {
//         System.Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

void PrintArray(int[,] matr) // Метод вывода массива
{
    for (int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(0) - количество столбцов
    {
        for (int j = 0; j < matr.GetLength(1); j++) // matrix.GetLength(1) - количество строк
        {
            Console.Write($"{matr[i, j]} "); 
        }
        Console.WriteLine(); // переводим курсор на другую строку
    }
}
void FillArray(int[,] matr) // Метод заполнения массива 
{
    for (int i = 0; i<matr.GetLength(0); i++) // Проходим по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) // Проходим по столбцам
        {
            matr [i, j] = new Random().Next(1,10); // заполняем случайными числами от 1 до 9
        }
    }
}
int[,] matrix = new int[3, 4]; // Инициализируем массив из 3 строк (rows) и 4 столбцов (columns)
PrintArray(matrix); // Применяем метод вывода массива (Выводим пустой массив  0 0 0 0...)
FillArray(matrix);  // Применяем метод заполнения макссива 
Console.WriteLine();// Переводим строку
PrintArray(matrix); // Применяем метод вывода массива (Выводим заполненный случайными числами массив)
