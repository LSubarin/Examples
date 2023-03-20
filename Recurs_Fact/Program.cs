/* Факториал. Рекурсия
    факториал - произведение чисел от 1 до заданного.
    5! = 5 * 4 * 3 * 2 * 1
         5 * 4!
             4 * 3!
                 3 * 2!
                     2 * 1!
*/


// Выводим факториал числа

// int Factorial(int n)
// {
//     // 1! = 1 // Факториал 1 = 1
//     // 0! = 1 // Факториал 0 = 1
//     if (n == 1) return 1;           //Если n равно 1 возвращаем 1
//     else return n * Factorial(n - 1); // иначе возвращаем (Рекурсия)
// }

// Console.WriteLine(Factorial(3));

 
/* Факториал - числа Фибоначи

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1; // Если n равно 1 или 2 возвращаем 1
    else return Fibonacci (n-1)+Fibonacci(n-2); // Иначе Возвращаем Fibonacci от формулы
}

for (int i=1; i<60; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

*/
