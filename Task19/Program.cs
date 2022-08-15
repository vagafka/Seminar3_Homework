// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Напишите число");
int N = Convert.ToInt32(Console.ReadLine());
N=Math.Abs(N);
string str = N.ToString();
int[] array = new int[5];

if (N>9999 && N<100000)
{
for (int i = 0; i < 5; i++)
{
    array[i] = int.Parse(str[i].ToString());
}
if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("Введенное число - палиндром");
}
else
{
    Console.WriteLine("Введенное число не является палиндромом");
}
}
else
{
    Console.WriteLine("Введенное число не пятизначное");
}

