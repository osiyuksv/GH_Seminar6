// преобразовываем дестяичное число в двоичное

Console.WriteLine("Введите двоичное число N");
int num = Convert.ToInt32(Console.ReadLine());

string str = "";

while (num > 0)
{
  str = num % 2 + str;
  num = num / 2;
}


Console.WriteLine(str);