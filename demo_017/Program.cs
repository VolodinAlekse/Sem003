// Задача №17. Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}                                             // string, bool, in[], double[], string, void

int x = InputNumber("Введите координату x");

int y = InputNumber("Введите координату y");

if (x > 0 && y > 0)
{
    System.Console.WriteLine(" Номер четверти 1");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine(" Номер четверти 2");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine(" Номер четверти 3");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine(" Номер четверти 4");
}
else
{
    System.Console.WriteLine(" Точка лежит в начале координат");
}