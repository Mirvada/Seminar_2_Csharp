// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого
// этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Мое решение
// int num = new Random().Next(100, 1000);
// int NewDigit(int number)
// {
//     int firstDigit = number / 100; 
//     return firstDigit;
// }
// int SecondNewDigit(int number)
// {
//     int secondDigit = number % 10;
//     return secondDigit;
// }

// int newDigital = NewDigit(num);
// int secondNewDigit = SecondNewDigit(num);
// Console.WriteLine($"{num} -> {newDigital}{secondNewDigital}");


// Решение преподователя
int num = new Random().Next(100, 1000);
int RemoveSecond(int num)
{
    int first = num / 100;
    int third = num % 10;
    return first * 10 + third;
}

int result = RemoveSecond(num);
Console.WriteLine($"{num} -> {result}");