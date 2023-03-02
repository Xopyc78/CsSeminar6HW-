// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int size = new Random().Next(5,11);
int[]array=new int[size];
int count=0;
Console.WriteLine($"Введите {size} числовых элементов массива");
for (int i = 0; i < size; i++)
{
    array[i]=Convert.ToInt32(Console.ReadLine());
    if (array[i]>0)
    {
        count++;
    }
}
Console.WriteLine($"В массиве [{String.Join("; ", array)}] {count} положительных чисел.");