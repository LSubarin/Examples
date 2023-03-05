System.Console.Write("Введите ваше имя "); // Приглашение ввести имя
string? username = Console.ReadLine();     // Знак вопроса сообщает, что string может иметь значение NULL (быть пустой строкой)
System.Console.Write("Привет, ");
System.Console.WriteLine(username);
