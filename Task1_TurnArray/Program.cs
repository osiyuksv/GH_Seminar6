// расположить в обратном порядке элементы рандомного массива
// из заданных L положительных элементов с разрядностью чисел D, начиная с 1

Console.WriteLine("Введите длину массива L");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr00 = new int[length];

Console.WriteLine("Введите разрядность D положительных элементов массиве (количество цифр элемента)");
int digit = Convert.ToInt32(Console.ReadLine());
double D0 = Math.Pow(10, digit);
int D = Convert.ToInt32(D0);

for (int i = 0; i < arr00.Length; i++)
  {
    arr00[i] = new Random().Next(1, D);
  }

Console.WriteLine(String.Join((", "), (arr00)));

for (int i = 0; i < (arr00.Length / 2); i++)
{
  int temp = arr00[arr00.Length - 1- i];
  arr00[arr00.Length - 1- i] = arr00[i];
  arr00[i] = temp;
}
 
Console.WriteLine(String.Join((", "), (arr00)));