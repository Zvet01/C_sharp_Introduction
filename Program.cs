// Lesson2_C#_HOME_WORK2

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine( "Введите любое число от 100 до 999: ");
// int number = Convert.ToInt32(Console.ReadLine()); 
// int secondDigit = Convert.ToInt32(number);
// secondDigit = number/10 % 10; // 2 цифра
// Console.WriteLine("Вторая цифра этого числа: " + secondDigit);




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.WriteLine("Введите любое число ");
//         int number = Convert.ToInt32(Console.ReadLine());
//         if (number < 100)
//         {
//         Console.WriteLine("Третьей цифры нет");
//         }

//         int thirdDigit = Convert.ToInt32(number);
//         if (number >= 100 && number < 1000)
//         {
//         thirdDigit = number % 10; // 3 цифра
//         Console.WriteLine("Третья цифра этого числа: " + thirdDigit);
//         }

//         if (number >= 1000)
//         {
//             thirdDigit = thirdDigit / 100 % 10;
//             Console.WriteLine("Третья цифра этого числа: " + thirdDigit);
//         }
//     }

// }




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// if (dayNumber == 6 || dayNumber == 7) // или 6-й или 7-й день
// {
// Console.WriteLine("да, это  выходной день");
// }
// else Console.WriteLine("нет, это не выходной день");

