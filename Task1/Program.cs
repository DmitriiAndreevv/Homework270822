/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.Clear();
Console.WriteLine("введите число = ");
int num = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(num);
if (number[0]==number[2] || number[1]==number[3])
{
    Console.WriteLine("число является палиндромом");
}
else
{
    Console.WriteLine("число не является палиндромом");
}