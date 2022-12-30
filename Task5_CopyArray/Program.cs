// выводить копию заданного массива
// с помощью поэлементного копирования

int[] array1 = {1, 5, 8, 10};
Console.WriteLine(String.Join((", "), (array1)));

int[] array2 = new int[array1.Length];

for (int i = 0; i < array1.Length; i++)
{
  array2[i] = array1[i];
}

Console.WriteLine(String.Join((", "), (array2)));