﻿//По двум заданным числам проверять является ли первое квадратом второго
// DZ_01
//По заданному номеру дня недели вывести его название
// DZ_02
//Выяснить является ли число чётным
// DZ_03
//Показать четные числа от 1 до N
// DZ_04
//Показать последнюю цифру трёхзначного числа
// DZ_05
//Показать вторую цифру трёхзначного числа
// DZ_06
//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// DZ_07
//Удалить вторую цифру трёхзначного числа
int Num_100;
int Num_10;
int Num_1;
int Num1;
int Num2;
Console.Write("Введите число от 100 до 999, а мы удалим вторую цифру : ");
Num1 = int.Parse(Console.ReadLine());
if (Num1 >= 100 & Num1 <= 999)
{
Num_100 =  Num1 / 100;
Num_10  = (Num1 - Num_100 * 100) / 10;
Num_1   = (Num1 - Num_100 * 100 - Num_10 * 10);
Console.WriteLine("Первая цифра "+ Num_100 +" вторая цифра " + Num_10 +" третья цифра " + Num_1);
Num2 = Num_100*10 + Num_1;
Console.WriteLine("Получилось число: "+Num2);
Num2 = Num_100*100 + Num_1;
Console.WriteLine("Возможен и такой вариант: "+Num2);
// этот вариант без вычислений
Console.WriteLine("Получилось число "+ Num_100 + Num_1);
Console.WriteLine("Возможен и такой вариант: "+ Num_100 + "0"+Num_1);



}
else
{
  Console.WriteLine("Ошибка! Число должно быть от 100 до 999");  
}


// DZ_08
//Выяснить, кратно ли число заданному, если нет, вывести остаток.
// DZ_09
//Найти третью цифру числа или сообщить, что её нет
// DZ_10