//По двум заданным числам проверять является ли первое квадратом второго
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
// DZ_08
//Выяснить, кратно ли число заданному, если нет, вывести остаток.
// DZ_09
//Найти третью цифру числа или сообщить, что её нет
// DZ_10
int Num1; // Основное число
int Num_rzd; // Разрядность основного числа
var Num_rzd2 = 0.0; // 
var Num2 = 0.0; // 
var Num3 = 0.0; // 3 цифра числа
var Num4 = 0.0; // Число без первых 2 разрядов
Num_rzd = 1;
Console.Write("Введите число, а мы найдем третью цифру числа или сообщим что её нет : ");
Num1 = int.Parse(Console.ReadLine());
// Определяем количество разрядов в числе

while (Num1 / Math.Pow(10,Num_rzd) > 1 & Num_rzd < 10)
{
Num_rzd2 = Math.Pow(10,Num_rzd); 
Num2 = Num1 / Math.Pow(10,Num_rzd);
Num_rzd = Num_rzd + 1; 
}
Num_rzd = Num_rzd - 2; 
Num3 = Math.Truncate(Num1 / Math.Pow(10,Num_rzd));
Num3 = Num3 * Math.Pow(10,Num_rzd);
Num4 = Num1-Num3;
Num_rzd = 1;
while (Num4 / Math.Pow(10,Num_rzd) > 1 & Num_rzd < 10)
{
Num_rzd2 = Math.Pow(10,Num_rzd); 
Num2 = Num4 / Math.Pow(10,Num_rzd);
Num_rzd = Num_rzd + 1; 
}
Num_rzd = Num_rzd - 1; 
Num3 = Math.Truncate(Num4 / Math.Pow(10,Num_rzd));
if (Num3 > 0)
{
    Console.WriteLine(" У введенного числа " + Num1 + " третья цифра "+Num3);  
}
else
{
 Console.WriteLine(" Введенное число " + Num1 + " не содержит третей цифры");   
}


