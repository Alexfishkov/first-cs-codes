int a=5, b=7, c=13, d=2, e=25;
Console.WriteLine("Программой заданы 5 чисел: " + a + " " + b + " " + c + " " + d + " " + e);
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.WriteLine("Максимальное значение среди них: " + max);
