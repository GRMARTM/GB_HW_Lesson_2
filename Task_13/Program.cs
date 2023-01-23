// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else if (number >= 100 && number < 1000)
{
    int digit1 = number % 10;
    Console.WriteLine(digit1);
}
else if (number >= 1000 && number < 10000)
{
    int digit2 = number / 100;
    int digit3 = (number - digit2 * 100) / 10;
    Console.WriteLine(digit3);
}
else if (number >= 10000 && number < 100000)
{
    int digit4 = number / 1000;
    int digit5 = (number - digit4 * 1000) / 100;
    Console.WriteLine(digit5);

}
else if (number >= 100000 && number < 1000000)
{
    int digit6 = number / 10000;
    int digit7 = (number - digit6 * 10000) / 1000;
    Console.WriteLine(digit7);

}
else if (number >= 1000000 && number < 10000000)
{
    int digit8 = number / 100000;
    int digit9 = (number - digit8 * 100000) / 10000;
    Console.WriteLine(digit9);

}
else if (number >= 10000000 && number < 100000000)
{
    int digit10 = number / 1000000;
    int digit11 = (number - digit10 * 1000000) / 100000;
    Console.WriteLine(digit11);

}
else if (number >= 100000000 && number < 1000000000)
{
    int digit11 = number / 10000000;
    int digit12 = (number - digit11 * 10000000) / 1000000;
    Console.WriteLine(digit12);

}
else if (number >= 1000000000 && number <= 2147483647)
{
    int digit13 = number / 100000000;
    int digit14 = (number - digit13 * 100000000) / 10000000;
    Console.WriteLine(digit14);

}




//  Попробуй другой способ, с делением на 10, замутив цикл
// Console.Write("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100)
// {
//     Console.WriteLine("Нет третьей цифры");
// }
// else if (number >= 100 && number < 1000)
// {
//     int digit2 = number / 100;
//     int digit3 = (number - digit2 * 100) / 10;
//     Console.WriteLine(digit3);
// }
// else {
//     int x = 10;
//     number / x;
// }



// Console.Write("VVedite");
// int number = Convert.ToInt32(Console.ReadLine());
// int OO = String(number);

// // int arrayOfDigits = Array.from(String(number));
// Console.Write(OO);

// Console.log(arrayOfDigits);

// 

// string[] sArr = Console.ReadLine();
// int num1 = Convert.ToInt32(sArr[0]);
// Console.Write(sArr);

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
//  string n = number;
//  char[] nn = new char[n.Length];
//  nn = n.ToCharArray();
//  foreach(char s in nn)
//             {
//                Console.WriteLine(s); 
//             }
