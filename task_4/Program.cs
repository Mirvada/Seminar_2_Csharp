// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да 

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 7;
int num3 = 23;
int result = num1 % num2;
int result2 = num1 % num3;

if(result == 0 & result2 == 0)
{
    Console.Write("Кратно");
}
else
{
    Console.Write("Не кратно");
}