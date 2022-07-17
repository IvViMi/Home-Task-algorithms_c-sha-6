/*
Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.Clear();
Console.WriteLine("Определение количества чисел, соответсвующих условию: '> 0', которые ввёл пользователь");
Console.Write("Введите целые числа через один пробел и нажмите ввод: ");
int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
int Nums(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}
Console.WriteLine($"Количество чисел '> 0': {Nums(array)} шт.");
