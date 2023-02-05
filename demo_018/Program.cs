// Напишите программу, 
// которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите номер четверти: ");
int q = Convert.ToInt32(Console.ReadLine());

if (q == 1)
{
    System.Console.WriteLine(" x > 0, y > 0");
}
else if (q == 2)
{
    System.Console.WriteLine(" x < 0, y > 0");
}
else if (q == 3)
{
    System.Console.WriteLine(" x < 0 && y < 0");
}
else if (q == 4)
{
    System.Console.WriteLine(" x > 0 && y < 0");
}
else
{
    System.Console.WriteLine("Начало координат");
}