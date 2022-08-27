/*Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга

10 -> 4
20 -> 7
30 -> 8*/

Console.Clear();
Console.WriteLine( "введите R");
int R =int.Parse(Console.ReadLine());
double pi = Math.PI;
double S = pi * R * R;
Console.WriteLine(Math.Round(S));

Console.Write("Введите полученное число:");
string str = Console.ReadLine();
 int max = int.Parse(str[0].ToString());
 
for (int i = 1; i < str.Length; i++)
{
  if (max < int.Parse(str[i].ToString()))
  max = int.Parse(str[i].ToString());
}
 Console.WriteLine("большее из чисел = " + max);
 Console.ReadLine();