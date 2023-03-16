// Сортировка массива. Метод мин макс ....


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)    // Функция вывода массива
{
    int count = array.Length;   // Счетчик приравниваем к длинне массива

    for (int i = 0; i < count; i++) // Для i = 0, пока i < count, наращиваем i
    {
        Console.Write($"{array[i]} "); // Выводим элемент [i] массива
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
    }

}


// Применение метода PrintArray()
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


