//Task 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($" max = {num1} , min = {num2} ");
}
else
{
    Console.WriteLine($" max = {num2} , min = {num1} ");
}


//Task 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 & num1 > num3)
{
   Console.WriteLine($" Max number = {num1} ");
}
else if(num2 > num1 & num2 > num3)
{
   Console.WriteLine($" Max number = {num2} "); 
}
else
{
    Console.WriteLine($" Max number = {num3} ");
}


//Task 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine($" Это четное число {num} ");
}
else
{
    Console.WriteLine($" Это нечетное число {num} ");
}
*/

//Task 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 2; i <= num; i = i + 2)
{
    Console.WriteLine(i);
}
