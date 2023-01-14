//По двум заданным числам проверять является ли первое квадратом второго
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
int Num1;
int Num2;
int Num3 = 1;
Console.Write("Введите число, а мы покажем все четные числа от 1 и до введенного числа : ");
Num1 = int.Parse(Console.ReadLine());
if (Num1 > 0)
{
    while (Num3 <= Num1)
    {
        Num2 = Num3 /2;
        if (Num3 == Num2*2) Console.WriteLine(Num3); 
        Num3 = Num3 +1;
    }
    Console.WriteLine("Расчет окончен!");
}
else
{
  Console.WriteLine("Ошибка! Число должно быть 1 или больше!"); 
}

//Показать последнюю цифру трёхзначного числа
// DZ_05
//Показать вторую цифру трёхзначного числа
int Num_100;
int Num_10;
int Num_1;
int Num1;
Console.Write("Введите число от 100 до 999, а мы покажем вторую цифру : ");
Num1 = int.Parse(Console.ReadLine());
if (Num1 >= 100 & Num1 <= 999)
{
Num_100 =  Num1 / 100;
Num_10  = (Num1 - Num_100 * 100) / 10;
Num_1   = (Num1 - Num_100 * 100 - Num_10 * 10);
Console.WriteLine("Ввторая цифра " + Num_10 );
Console.WriteLine("И полное состав ");
Console.WriteLine("Первая цифра "+ Num_100 +" вторая цифра " + Num_10 +" третья цифра " + Num_1);
}
else
{
  Console.WriteLine("Ошибка! Число должно быть от 100 до 999");  
}
// DZ_06
//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int Num_10;
int Num_1;
int Num1;
Console.Write("Введите число от 10 до 99, а мы покажем наибольшую цифру числа : ");
Num1 = int.Parse(Console.ReadLine());
if (Num1 >= 10 & Num1 <= 99)
{
Num_10  = Num1 / 10;
Num_1   = Num1 - Num_10 * 10;
Console.WriteLine("Первая цифра " + Num_10 );
Console.WriteLine("Вторая цифра " + Num_1 );
if (Num_10 >= Num_1) {Console.WriteLine("Первая цифра "+Num_10+" больше или ровна второй " + Num_1 );}
 else { Console.WriteLine("Вторая цифра "+ Num_1 + "больше первой " + Num_10 ); }
}
else
{
  Console.WriteLine("Ошибка! Число должно быть от 10 до 99");  
}
// DZ_07
//Удалить вторую цифру трёхзначного числа
// DZ_08
//Выяснить, кратно ли число заданному, если нет, вывести остаток.
// DZ_09
//Найти третью цифру числа или сообщить, что её нет
// DZ_10