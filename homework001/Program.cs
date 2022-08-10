// Написать на программу, которая на вход принимает два числа и выдает, какое число большее, какое меньшее
   
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
Console.Write(a);
else
Console.Write(b);
