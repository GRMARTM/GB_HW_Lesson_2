// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else while ( number >= 1000)
{
number = number / 10 ;
}


if  (number > 100 && number < 1000)
{
    int digit = number / 10;
    int digit2 = (number - digit * 10);
    Console.WriteLine(digit2);
}

