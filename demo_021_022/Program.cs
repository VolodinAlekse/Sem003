// Напишите программу, 
// которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//Math.Pow(Число, количество квадратов)
//Math.Sqrt(Квадратный корень из указанного числа)

// int InputNumber(string str)
// {
//     System.Console.WriteLine(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int x1 = InputNumber("Введите координату x1: ");
// int y1 = InputNumber("Введите координату y1: ");

// int x2 = InputNumber("Введите координату x2: ");
// int y2 = InputNumber("Введите координату y2: ");

// System.Console.WriteLine(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));


// Напишите программу, 
// которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// while (count <= N)
// {
//     System.Console.Write(Math.Pow(count, 2) + " ");
//     count++;
// }

for(int count = 1; count <= N; count++)
{
    System.Console.Write(Math.Pow(count, 2) + " ");
}
