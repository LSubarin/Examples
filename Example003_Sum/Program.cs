﻿int numberA = new Random().Next(1, 10); //  1 2 3...9
System.Console.WriteLine(numberA); // Вывод в консоль первого случайного числа
int numberB = new Random().Next(1, 10); 
System.Console.WriteLine(numberB); // Вывод в консоль второго случайного числа
int result = numberA + numberB;
System.Console.WriteLine(result); // Вывод в консоль суммы чисел