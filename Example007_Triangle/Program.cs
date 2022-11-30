int xa = 40, ya = 1, xb = 1, yb = 30, xc = 80, yc = 30; // Определили начальные точки треугольника

Console.Clear();                            // Очистили окно терминала

Console.SetCursorPosition(xa, ya);          // Нарисовали исходные три точки тркугольника
Console.WriteLine("@");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("@");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("@");

int x = xa, y = xb;         // Выбираем исходный отрезок треугольника
int count = 0;          // Счётчик числа повторений отрисовки новых точек

while (count < 10000)
{
    int what = new Random().Next(0, 3);  // Выбираем случайным образом один из 3-х вариантов
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("@");
    count++;
}




