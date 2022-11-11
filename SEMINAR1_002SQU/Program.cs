// Написать программу, которая на вход принимает число и выдаёт его квадрат

Console.WriteLine("Введите число, квадрат которого нужно найти: ");
int number = Convert.ToInt32(Console.ReadLine());   // int - целое число, преобразовать из числа в строку - Convert.ToInt32(32 кол-во цифр в числе)
int result = number * number;   
Console.WriteLine($"Квадрат {number} равен {result}");