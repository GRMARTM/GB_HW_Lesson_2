//Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите порядковый номер дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());


// if(number > 5)
// {
//     Console.WriteLine("Да");
// }
// else 
// {
//     Console.WriteLine("НЕТ");
// }

Console.Write("Введите порядковый номер дня недели : ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <=5)
{
    Console.Write("Это не выходной");
}
if (num >= 6 && num <= 7)
{
    Console.Write("Это выходной");
}
if (num < 1 || num > 7)
{
    Console.Write("Ошибка ввода, попробуйте снова ");
}
