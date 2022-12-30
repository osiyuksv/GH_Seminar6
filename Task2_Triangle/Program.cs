// выводить возможен ли треугольник с 
// заданными пользователем тремя сторонами

Console.WriteLine("Введите длину A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину C");
int C = Convert.ToInt32(Console.ReadLine());
int hypotenuse = A;

if (A * A == C * C + B * B | B * B == A * A + C * C | C * C == A * A + B * B) 
{
if(A * A == C * C + B * B)Console.WriteLine("Это треугольник с гиппотенузой A = " + A);
if(B * B == A * A + C * C) Console.WriteLine("Это треугольник с гиппотенузой B = " + B);
if(C * C == A * A + B * B)Console.WriteLine("Это треугольник с гиппотенузой C = " + C);
}

else Console.WriteLine("Это не треугольник");


