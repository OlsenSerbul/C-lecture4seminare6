// Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.

Console.Write("Сколько чисел вы будете вводить: М = ");
int Length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[Length];
for (int i = 0; i < Length; i++ )
{
  Console.Write($"Введите число под номером  {i + 1}: ");
  array[i] = Convert.ToInt32(Console.ReadLine());
}
int count = 0;
for (int i = 0; i < Length; i++)
{
    if(array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Вы ввели {count} числа больше 0");


