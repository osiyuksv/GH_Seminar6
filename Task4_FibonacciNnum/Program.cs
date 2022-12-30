// вывести первые N чисел Фибоначи

Console.WriteLine("Введите число элемнтов N для Фибоначи");
int num = Convert.ToInt32(Console.ReadLine());
 
 int num1 = 0;
 int num2 = 1;

Console.WriteLine(num1);
Console.WriteLine(num2);

 for (int i = 3; i <= num; i++)
 {
  int NextNum = num1 + num2;
  Console.WriteLine(NextNum);
  num1 = num2;
  num2 = NextNum;
 }
