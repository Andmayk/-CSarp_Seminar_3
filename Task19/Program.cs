
System.Console.WriteLine("Введите  пятизначное число ");
string number = Console.ReadLine();
int numberYN  = Convert.ToInt32(number);  

bool polindrome = true;

for (int i = 0; i < number.Length/2; i++)
{
    if (number[i] <> number[number.Length - i - 1])
    {
        polindrome = false;
        break;
    }
}

if polindrome
{
    System.Console.WriteLine($"Число {number} полиндром.");
}
else
{
    System.Console.WriteLine($"Число {number} НЕ полиндром.");
}