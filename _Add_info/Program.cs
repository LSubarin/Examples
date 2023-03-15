// Методы

// Вид 1
void Method1() // Ничего не принимает и не возвращает
{
    Console.WriteLine("Автор ...");
}

// Способ вызова
// Method1();  // Правилдьно
// Method1;    // Не правильнор

// Вид 2
void Method2(string msg) // принимает аргумент
{
    Console.WriteLine(msg);
}

// Спозоб вызова
// Method2(msg: "Текст сообщения"); 

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
//Способ вызова
// int year = Method3();
// Console.WriteLine(year);

// Вид 4
string Method4(int count, string text)  // Принимает аргументы и возвращает значения

// Цикл for

{
    string result = String.Empty;
    for(int i=0; i< count; i++)
    {
        result = result + text;
    }
    return result;
}
// Цикл while

// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// Способ вызова
string res = Method4(10, "Z");
Console.WriteLine(res);