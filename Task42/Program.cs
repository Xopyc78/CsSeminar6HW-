// Задача 42 (необязательно): Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.Write("Введите десятичное число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber=firstNumber;
int sizeArray=1;
while (firstNumber/2>0)
{
   firstNumber/=2;
   sizeArray++;
}
int [] array=new int[sizeArray];
for (int i = 0; i < sizeArray; i++)
{
   int remainsNumber=secondNumber%2;
   secondNumber=secondNumber/2;
   array[i]=remainsNumber;
}
// Запись массива в обратном порядке в новый массив
int[] resultArray = CopyArray(array);
Console.WriteLine($"Оно же в двоичной системе счисления:  {String.Join("", resultArray)}");
int[] CopyArray(int[] inputArray)
{
   int size = inputArray.Length;
   int j = size - 1; 
   int[] inverseArray = new int[size]; 
   for (int i = 0;  i < size; i++, j--)
   {
      inverseArray[i] = inputArray[j];
   }
   return inverseArray;
}