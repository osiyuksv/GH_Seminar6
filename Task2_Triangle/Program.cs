// выводить возможен ли треугольник с 
// заданными пользователем тремя сторонами

Console.WriteLine("Введите длину A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину C");
int C = Convert.ToInt32(Console.ReadLine());

if (A < C + B & B  < A + C & C < A + B) Console.WriteLine("Это треугольник");
else Console.WriteLine("Это не треугольник");