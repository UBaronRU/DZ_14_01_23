﻿//По двум заданным числам проверять является ли первое квадратом второго
// DZ_01
int Num1;
int Num2;
Console.Write("Введите число 1: ");
Num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
Num2 = int.Parse(Console.ReadLine());
if (Num1 == Num2*Num2)
{
   Console.WriteLine("Число "+ Num1 +" квадрат числа "+Num2); 
}
else
{
    Console.WriteLine(" Число "+ Num1 +" не является квадратом "+Num2);
}


//По заданному номеру дня недели вывести его название
// DZ_02
int day_week;
Console.Write("Введите номеру дня недели (1-7): ");
day_week = int.Parse(Console.ReadLine());
if (day_week > 0 & day_week < 8)
{
if (day_week == 1)  {Console.WriteLine("Понедельник");} 
if (day_week == 2)  {Console.WriteLine("Вторник");}
if (day_week == 3)  {Console.WriteLine("Среда");}
if (day_week == 4)  {Console.WriteLine("Четверг");}
if (day_week == 5)  {Console.WriteLine("Пятница");}
if (day_week == 6)  {Console.WriteLine("Суббота");}
if (day_week == 7)  {Console.WriteLine("Воскресение");}
}
else
{
    Console.WriteLine(" Ошибка при вводе значений. Нужно ввести число от 1 до 7.");
}

//Выяснить является ли число чётным
// DZ_03
int Num1;
int Num2;
Console.Write("Введите число, а мы определим четное ли оно : ");
Num1 = int.Parse(Console.ReadLine());
Num2 = Num1 /2;
if (Num1 == Num2*2) Console.WriteLine("Число "+ Num1 +" Четное "); 
else Console.WriteLine("Число "+ Num1 +" Нечетное ");

//Показать четные числа от 1 до N
// DZ_04
//Показать последнюю цифру трёхзначного числа
// DZ_05
//Показать вторую цифру трёхзначного числа
// DZ_06
//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// DZ_07
//Удалить вторую цифру трёхзначного числа
// DZ_08
//Выяснить, кратно ли число заданному, если нет, вывести остаток.
// DZ_09
//Найти третью цифру числа или сообщить, что её нет
// DZ_10