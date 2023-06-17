// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string number;

do
{
    System.Console.Write("Введите пятизначное число ");
    number = Console.ReadLine();             // считываем число в строковую переменную
    int numberYN = Convert.ToInt32(number);  // так проверим что точно число  :)

} while (number.Length != 5); // "выбиваем" из пользователя именно Пятизначное число 

bool polindrome = true;  // предположим что число полиндром

for (int i = 0; i < number.Length / 2; i++)         // цикл до середины строки для перебора символов по парно    
{
    if (number[i] != number[number.Length - i - 1]) // если символы не одинаковы
    {
        polindrome = false; // указываем, что число не полиндром
        break;              // и прерываем цикл
    }
}

if (polindrome)
{
    System.Console.WriteLine($"-> да - число {number} полиндром.");
}
else
{
    System.Console.WriteLine($"-> нет - число {number} НЕ полиндром.");
}
