// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter number 1-100: ");
//         if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= 100)
//         {
//             if (number % 3 == 0 && number % 5 == 0)
//                 Console.WriteLine("FizzBuzz");
//             else if (number % 3 == 0)
//                 Console.WriteLine("Fizz");
//             else if (number % 5 == 0)
//                 Console.WriteLine("Buzz");
//             else
//                 Console.WriteLine(number);
//         }
//         else
//         {
//             Console.WriteLine("Error");
//         }
//     }
// }

// 2
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("1st num: ");
//         if (double.TryParse(Console.ReadLine(), out double value1))
//         {
//             Console.Write("Enter %: ");
//             if (double.TryParse(Console.ReadLine(), out double percent))
//             {
//                 double result = (percent / 100) * value1;
//                 Console.WriteLine($"Res: {result}");
//             }
//             else
//             {
//                 Console.WriteLine("Error");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Error");
//         }
//     }
// }

// 3
// using System;

// class Program
// {
//     static void Main()
//     {
//         int result = 0;
//         for (int i = 0; i < 4; i++)
//         {
//             Console.Write($"{i + 1}: ");
//             if (int.TryParse(Console.ReadLine(), out int digit) && digit >= 0 && digit <= 9)
//             {
//                 result = result * 10 + digit;
//             }
//             else
//             {
//                 Console.WriteLine("Error");
//                 return; 
//             }
//         }

//         Console.WriteLine($"Res: {result}");
//     }
// }



//4
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter number: ");
//         if (int.TryParse(Console.ReadLine(), out int number) && number >= 100000 && number <= 999999)
//         {
//             Console.Write("Enter digit numbers to replace (eg 1 6): ");
//             string[] positions = Console.ReadLine().Split();

//             if (positions.Length == 2 && int.TryParse(positions[0], out int position1) && int.TryParse(positions[1], out int position2))
//             {
//                 if (position1 >= 1 && position1 <= 6 && position2 >= 1 && position2 <= 6)
//                 {
//                     int result = SwapDigits(number, position1, position2);
//                     Console.WriteLine($"Res: {result}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Error");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Error");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Error");
//         }
//     }

//     static int SwapDigits(int number, int position1, int position2)
//     {
//         int digit1 = (number / (int)Math.Pow(10, 6 - position1)) % 10;
//         int digit2 = (number / (int)Math.Pow(10, 6 - position2)) % 10;
//         number -= digit1 * (int)Math.Pow(10, 6 - position1);
//         number += digit2 * (int)Math.Pow(10, 6 - position1);

//         number -= digit2 * (int)Math.Pow(10, 6 - position2);
//         number += digit1 * (int)Math.Pow(10, 6 - position2);

//         return number;
//     }
// }


//5
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введіть дату у форматі dd.MM.yyyy: ");
//         if (DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
//         {
//             string season = GetSeason(date.Month);
//             string dayOfWeek = date.DayOfWeek.ToString();
//             Console.WriteLine($"{season} {dayOfWeek}");
//         }
//         else
//         {
//             Console.WriteLine("Помилка: некоректний формат дати.");
//         }
//     }

//     static string GetSeason(int month)
//     {
//         if (month >= 1 && month <= 2 || month == 12)
//             return "Winter";
//         else if (month >= 3 && month <= 5)
//             return "Spring";
//         else if (month >= 6 && month <= 8)
//             return "Summer";
//         else
//             return "Autumn";
//     }
// }

//6
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter Temp: ");
//         if (double.TryParse(Console.ReadLine(), out double temperature))
//         {
//             Console.Write("Select units (C for Celsius, F for Fahrenheit): ");
//             char choice = Console.ReadLine().ToUpper()[0];

//             if (choice == 'C')
//             {
//                 double fahrenheit = (temperature * 9 / 5) + 32;
//                 Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}°F");
//             }
//             else if (choice == 'F')
//             {
//                 double celsius = (temperature - 32) * 5 / 9;
//                 Console.WriteLine($"Temperature in Celsius: {celsius}°C");
//             }
//             else
//             {
//                 Console.WriteLine("Error");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Error");
//         }
//     }
// }

//7
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter two numbers separated by a space: ");
//         string[] input = Console.ReadLine().Split();

//         if (input.Length == 2 && int.TryParse(input[0], out int start) && int.TryParse(input[1], out int end))
//         {
//             if (start > end)
//             {
//                 int temp = start;
//                 start = end;
//                 end = temp;
//             }

//             Console.WriteLine($"Even numbers in the range from {start} to {end}:");
//             for (int i = start; i <= end; i++)
//             {
//                 if (i % 2 == 0)
//                 {
//                     Console.Write($"{i} ");
//                 }
//             }
//         }
//         else
//         {
//             Console.WriteLine("Error");
//         }
//     }
// }
