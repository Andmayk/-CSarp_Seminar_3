// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки А -  x y z : ");
int[] pointA = Array.ConvertAll(Console.ReadLine()!.Split(" ", 3), int.Parse); // массив координат точки А x y z через пробел

Console.Write("Введите координаты точки B -  x y z : ");
int[] pointB = Array.ConvertAll(Console.ReadLine()!.Split(" ", 3), int.Parse); // массив координат точки B x y z через пробел

double SumOfSquared = 0;  // введем переменную для нахождения суммы квадратов - значение под корнем формулы

for (int i = 0; i < 3; i++)
{
    SumOfSquared = SumOfSquared + Math.Pow(pointB[i] - pointA[i], 2);  // возводим в квадрат разност координат и суммируем 
}

double distant = Math.Round(Math.Sqrt(SumOfSquared), 2);  // находим корень и округляем значение до 2 знаков после (,)

Console.WriteLine("Расстояние между точками -> " + distant);