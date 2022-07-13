// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10, 100);
// int firstDigit = num / 10; //находим первое число, так как оно целочисленное
// int secondDigit = num % 10; //находим второе число, остаток от деления

// if(firstDigit == secondDigit) 
//     Console.WriteLine("Цифры одинаковые");
// else if(firstDigit > secondDigit) 
//     Console.WriteLine($"{num} -> {firstDigit}");
// else 
//     Console.WriteLine($"{num} -> {secondDigit}");

// Решение с помощью метода 

int num = new Random().Next(10, 100);
int MaxDigit(int number)
{
    int firstDigit = number / 10; 
    int secondDigit = number % 10; 
    if(firstDigit == secondDigit) return 0;
    else if(firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}

int maxDigit = MaxDigit(num);
if(maxDigit == 0) Console.WriteLine($"{num} -> Цифры одинаковые");
else Console.WriteLine($"{num} -> {maxDigit}");