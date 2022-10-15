Console.WriteLine("Задайте длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];
Console.Write("Массив чисел: ");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for(int i = 0; i < array.Length/2; i++)
{
    int j = length - i - 1;
    if(j>=i) Console.Write($"{array[i]} x {array[j]} = {array[i] * array[j]}");
    Console.WriteLine();
}